
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_getqrcode_Click(object sender, EventArgs e)
        {
            Facade.LoginFacde loginFacde = new Facade.LoginFacde();
            LoginQrCode postData = new LoginQrCode() { ProxyIp = "", DeviceId = "", ProxyUserName = "", ProxyPassword = "" };
            Models.Response.LoginQrCode Responsemodel = new Models.Response.LoginQrCode();
            if (!loginFacde.GetLoginQrCode(ref Responsemodel,postData))
            {
                Log("网络异常请求失败！");
                return;

            }

            if (!Responsemodel.Success)
            {
                Log(Responsemodel.Message+":"+Responsemodel.Code);
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
                Timer_CheckLogin_Heatbeat.Elapsed += Timer_CheckLogin_Elapsed1;
                Timer_CheckLogin_Heatbeat.Interval = 10000;
                Timer_CheckLogin_Heatbeat.Start();
            }
        }

        private void Timer_CheckLogin_Elapsed1(object sender, System.Timers.ElapsedEventArgs e)
        {
            string uuid = this.lb_Uuid.Text;
            string wwxid = this.lb_Wxid.Text;
            Facade.LoginFacde loginFacde = new Facade.LoginFacde();
            string json = string.Empty;
            if (!loginFacde.HeartBeat(ref json, wwxid))
            {
                Log("404网络异常，请检查ip或端口配置");
                ((System.Timers.Timer)sender).Stop();
            }

            Log2(json);

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
            DataLogin();
        }

        private void DataLogin()
        {
           
        }

        private void AccountLogin()
        {
          
        }
    }
}
