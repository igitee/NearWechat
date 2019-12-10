
using CefSharp;
using CefSharp.WinForms;
using NearWeChat.MKM.Models.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using System.Windows.Forms;
using ZXing;

namespace NearWeChat.MKM
{
    public partial class Form1 : Form
    {


        System.Timers.Timer Timer_CheckLogin = new System.Timers.Timer();
        private static readonly object Lock_Islogin = new object();
        private ChromiumWebBrowser browser = null;
        public Form1()
        {
            InitializeComponent();
            var setting = new CefSettings();
            setting.Locale = "zh-CN";
            setting.CefCommandLineArgs.Add("disable-gpu", "1");//去掉gpu，否则chrome显示有问题
            Cef.Initialize(setting);
            browser = new ChromiumWebBrowser("https://liulanmi.com/labs/core.html");
            this.groupBox1.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }

        private void Btn_getqrcode_Click(object sender, EventArgs e)
        {
            Facade.LoginFacde loginFacde = new Facade.LoginFacde();
            LoginQrCode postData = new LoginQrCode() { ProxyIp = Config.ProxyConfig.Ip, DeviceId = Config.ProxyConfig.DeviceId, ProxyUserName = Config.ProxyConfig.UserName, ProxyPassword = Config.ProxyConfig.UserPwd };
            Models.Response.LoginQrCode Responsemodel = new Models.Response.LoginQrCode();
            if (!loginFacde.GetLoginQrCode(ref Responsemodel,postData))
            {
                Log("网络异常请求失败！");
                return;

            }

            if (!Responsemodel.Success)
            {
                Log(Responsemodel.Message+":"+Responsemodel.Code);
                return;
            }

            Image qrcode = Tool.ImageHelper.resizeImage(Tool.ImageHelper.Base64StringToImage(Responsemodel.Data.QrBase64), 200, 200);

            this.pic_qrcode.Image = qrcode;
            Log("Uuid:");
            Log(Responsemodel.Data.Uuid);
            Log("过期时间：");
            Log(Responsemodel.Data.ExpiredTime);
            this.lb_Uuid.Text = Responsemodel.Data.Uuid;

            Timer_CheckLogin.Elapsed += Timer_CheckLogin_Elapsed;
            Timer_CheckLogin.Interval = 2000;
            Timer_CheckLogin.Start();

        }

        private void Timer_CheckLogin_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
          

            lock (Lock_Islogin) {

                Facade.LoginFacde loginFacde = new Facade.LoginFacde();
                Models.Response.ResponseBase<Models.Response.CheckLogin> ResposecheckLogin = new Models.Response.ResponseBase<Models.Response.CheckLogin>();
                string uuid = this.lb_Uuid.Text;
                if (!loginFacde.CheckLogin(ref ResposecheckLogin, uuid))
                {
                    Log("404网络异常，请检查ip或端口配置");
                    Timer_CheckLogin.Stop();
                    return;
                }

                if (!ResposecheckLogin.Success)
                {
                    Log("协议异常，请检查服务端协议");
                    Timer_CheckLogin.Stop();
                    return;
                }

                if (ResposecheckLogin.Data.State == 0)
                {
                    Log("未扫码，等待中");
                    return;
                }
                if (ResposecheckLogin.Data.State == 1)
                {
                    Log("已扫码，待确认");
                    return;
                }


                Log("Uuid====" + ResposecheckLogin.Data.Uuid);
                Log("WxId====" + ResposecheckLogin.Data.WxId);
                Log("NickName====" + ResposecheckLogin.Data.NickName);
                Log("State====" + ResposecheckLogin.Data.State);
                Log("Device====" + ResposecheckLogin.Data.Device);
                Log("HeadUrl====" + ResposecheckLogin.Data.HeadUrl);
                Log("Mobile====" + ResposecheckLogin.Data.Mobile);
                Log("Email====" + ResposecheckLogin.Data.Email);
                Log("Alias====" + ResposecheckLogin.Data.Alias);

                SetWwId( ResposecheckLogin.Data.WxId);


                Timer_CheckLogin.Stop();


                System.Timers.Timer Timer_CheckLogin_Heatbeat = new System.Timers.Timer();
                Timer_CheckLogin_Heatbeat.Elapsed += Timer_CheckLogin_Heart_Elapsed;
                Timer_CheckLogin_Heatbeat.Interval = 10000;
                Timer_CheckLogin_Heatbeat.Start();
            }
        }

        private void Timer_CheckLogin_Heart_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            string uuid = this.lb_Uuid.Text;
            string wwxid = this.lb_Wxid.Text;
            Facade.LoginFacde loginFacde = new Facade.LoginFacde();
            Models.Response.ResponseBase<Models.Response.HeartBeat> ResponseModel = new Models.Response.ResponseBase<Models.Response.HeartBeat>();
            if (!loginFacde.HeartBeat(ref ResponseModel, wwxid))
            {
                Log("404网络异常，请检查ip或端口配置");
                ((System.Timers.Timer)sender).Stop();
            }

            Log2(ResponseModel.Data.NextTime.ToString());

        }

        private void SetWwId(string text)
        {
            if (lb_Wxid.InvokeRequired)
            {
                Action<string> action = new Action<string>(SetWwId);
                Invoke(action, new object[] { text });
            }
            else
            {
                lb_Wxid.Text = text;
                //定位到最后一行
            }
        }

        private void SetConfirmUrl(string text)
        {
            if (lb_Wxid.InvokeRequired)
            {
                Action<string> action = new Action<string>(SetConfirmUrl);
                Invoke(action, new object[] { text });
            }
            else
            {
                lb_ConfirmUrl.Text = text;
                tb_url.Text = text;
                //定位到最后一行
            }
        }


        private void Log(string text)
        {
            if (tb_log.InvokeRequired)
            {
                Action<string> action = new Action<string>(Log);
                Invoke(action, new object[] { text });
            }
            else
            {
                tb_log.Text += "\r\n";
                tb_log.AppendText(text);
                //定位到最后一行
            }
        }


        private void Log2(string text)
        {
            if (tb_log.InvokeRequired)
            {
                Action<string> action = new Action<string>(Log2);
                Invoke(action, new object[] { text });
            }
            else
            {
                tb_heart.Text += "\r\n";
                tb_heart.AppendText(text);
                //定位到最后一行
            }
        }

        private void Btn_debug_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_liulan_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件夹";
            dialog.Filter = "(*.jpg,*.png,*.jpeg,*.bmp,*.gif)|*.jgp;*.png;*.jpeg;*.bmp;*.gif|All files(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = dialog.FileName;
                this.pic_scan.ImageLocation = dialog.FileName;

                BarcodeReader reader = new BarcodeReader();
                reader.Options.CharacterSet = "UTF-8";
                Bitmap map = new Bitmap(file);
                Result result = reader.Decode(map);
                Log("识别二维码：" + result.Text);
            }
        }

        private void Btn_scan_Click(object sender, EventArgs e)
        {
            this.tb_APPID.Text = lb_appid.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Btn_get62_Click(object sender, EventArgs e)
        {
            Facade.LoginFacde loginFacde = new Facade.LoginFacde();
            
     
            string Wwid = this.lb_Wxid.Text;
            string data62 = string.Empty;
               
            if (!loginFacde.Get62Data(ref data62, Wwid))
            {
                Log("404网络异常，请检查ip或端口配置");
                return;
            }

            Log(data62);
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_62.Text))
            {
                AccountLogin();
                return;
            }
            DataLogin(false);
        }

        private void DataLogin(bool isVerify)
        {

            Facade.LoginFacde loginFacde = new Facade.LoginFacde();


            Models.Request.Login62Data login62Requestl = new Login62Data();
            login62Requestl.Data62 = this.tb_62.Text;
            login62Requestl.UserName = this.tb_username.Text;
            login62Requestl.Password = this.tb_pwd.Text;
            login62Requestl.ProxyIp = Config.ProxyConfig.Ip;
            login62Requestl.ProxyUserName = Config.ProxyConfig.UserName;
            login62Requestl.ProxyPassword = Config.ProxyConfig.UserPwd;


            if (!isVerify)
            {
                Models.Response.ResponseBase<Models.Response.Login62Data> login62Response = new Models.Response.ResponseBase<Models.Response.Login62Data>();
                if (!loginFacde.LoginBy62(ref login62Response, login62Requestl))
                {
                    Log(loginFacde.Msg);
                    return ;
                }
                if (!login62Response.Success)
                {
                    Log(login62Response.Message);
                    return ;
                }


                if (string.IsNullOrEmpty(login62Response.Data.accountInfo.wxid))
                {
                    Log(login62Response.Data.baseResponse.errMsg._string);

                    Models.Response.Login62Confirm login62Confirm = Tool.XmlHelper.Deserialize<Models.Response.Login62Confirm>(login62Response.Data.baseResponse.errMsg._string.Replace("\n", ""));

                    SetConfirmUrl(login62Confirm.Url);
                    return ;
                }
                SetWwId(login62Response.Data.accountInfo.wxid);

                return;
            }

            Models.Response.ResponseBase<Models.Response.PassVerify> PassVerifyResponse = new Models.Response.ResponseBase<Models.Response.PassVerify>();
            if (!loginFacde.VerifyLoginBy62(ref PassVerifyResponse, login62Requestl))
            {
                Log(loginFacde.Msg);
                return;
            }
            if (!PassVerifyResponse.Success)
            {
                Log(PassVerifyResponse.Message);
                return;
            }
            if (string.IsNullOrEmpty(PassVerifyResponse.Data.accountInfo.wxid))
            {
                Log(PassVerifyResponse.Data.baseResponse.errMsg._string);
                return;
            }
            SetWwId(PassVerifyResponse.Data.accountInfo.wxid);


            //TODO:调心跳
        }

      



        private void AccountLogin()
        {
            MessageBox.Show(" 暂不支持账号密码登录！");
        }

        private void Btn_loginout_Click(object sender, EventArgs e)
        {
            Facade.LoginFacde loginFacde = new Facade.LoginFacde();
            string Wwid = this.lb_Wxid.Text;
            string json = string.Empty;
            if (!loginFacde.LoginOut(ref json, Wwid))
            {
                Log("404网络异常，请检查ip或端口配置");
                return;
            }

            Log(json);
        }

        private void Btn_twcLogin_Click(object sender, EventArgs e)
        {
            Facade.LoginFacde loginFacde = new Facade.LoginFacde();
            string Wwid = this.lb_Wxid.Text;
            string json = string.Empty;
            if (!loginFacde.TwiceLogin(ref json, Wwid))
            {
                Log("404网络异常，请检查ip或端口配置");
                return;
            }

            Log(json);
        }
    

        private void Btn_confim_Click(object sender, EventArgs e)
        {
            Facade.LoginFacde loginFacde = new Facade.LoginFacde();
            ExtDeviceLoginConfirmOK extDeviceLoginConfirmOK = new ExtDeviceLoginConfirmOK
            {
                LoginUrl = lb_ConfirmUrl.Text,
                WxId = string.Empty
            };
            string json = string.Empty;

            if (!loginFacde.ConfirmLogin(ref json, extDeviceLoginConfirmOK))
            {
                Log(loginFacde.Msg);
                return;
            }
            Log(json);
        }

        private void Btn_browser_Click(object sender, EventArgs e)
        {
            browser.Load(this.tb_url.Text);
        }

        private void Btn_NewInit_Click(object sender, EventArgs e)
        {
            Facade.LoginFacde loginFacde = new Facade.LoginFacde();
            string Wwid = this.lb_Wxid.Text;
            string json = string.Empty;
            if (!loginFacde.NewInit(ref json, Wwid))
            {
                Log(loginFacde.Msg);
                return;
            }

            Log(json);
        }

        private void Btn_verify_Click(object sender, EventArgs e)
        {
            DataLogin(true);
        }

        private void Btn_native_Click(object sender, EventArgs e)
        {
            browser.Load(this.lb_ConfirmUrl.Text);
        }

        private void Btn_heart_Click(object sender, EventArgs e)
        {
            Timer_CheckLogin_Heart_Elapsed(null, null);
        }

        private void Btn_InitUser_Click(object sender, EventArgs e)
        {
            Facade.LoginFacde loginFacde = new Facade.LoginFacde();
            string Wwid = this.lb_Wxid.Text;
            Models.Request.InitUser initUser = new InitUser();

            string json = string.Empty;

            if (!loginFacde.NewInit(ref json, Wwid))
            {
                Log(loginFacde.Msg);
                return;
            }

            Log(json);
        }

        private void Btn_Sync_Click(object sender, EventArgs e)
        {
            Facade.CommonFacade   commonFacade = new Facade.CommonFacade();
            string Wwid = this.lb_Wxid.Text;
            Models.Request.InitUser initUser = new InitUser();

            string json = string.Empty;

            if (!commonFacade.SyncMessage(ref json, Wwid))
            {
                Log(commonFacade.Msg);
                return;
            }

            Log(json);
        }

        private void Btn_foiiow_Click(object sender, EventArgs e)
        {
            Facade.CommonFacade commonFacade = new Facade.CommonFacade();
           
            Models.Request.ForkOfficialAccount fork = new ForkOfficialAccount();
            fork.WxId = this.lb_Wxid.Text;
            fork.AppId = this.tb_APPID.Text;
            string json = string.Empty;

            if (!commonFacade.ForkOfficialAccountMessage(ref json, fork))
            {
                Log(commonFacade.Msg);
                return;
            }

            Log(json);
        }

        private void Btn_sendtext_Click(object sender, EventArgs e)
        {
            Facade.MessageFacade messageFacade = new Facade.MessageFacade();

            Models.Request.TxtMessage fork = new TxtMessage();
            fork.WxId = this.lb_Wxid.Text;
            fork.Content = this.tb_debug.Text;
            fork.ToWxIds = new List<string>() { this.tb_towxid.Text };

            string json = string.Empty;

            if (!messageFacade.SendTxtMessage(ref json, fork))
            {
                Log(messageFacade.Msg);
                return;
            }

            Log(json);
        }

        private void Btn_getfriendlist_Click(object sender, EventArgs e)
        {
            Facade.FriendFacade messageFacade = new Facade.FriendFacade();

        
             string WxId = this.lb_Wxid.Text;
      

            string json = string.Empty;

            if (!messageFacade.GetContractList(ref json, WxId))
            {
                Log(messageFacade.Msg);
                return;
            }

            Log(json);
        }
    }
}
