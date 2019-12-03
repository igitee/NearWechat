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

namespace NearWeChat.MKM
{
    public partial class Form1 : Form
    {


        System.Timers.Timer Timer_CheckLogin = new System.Timers.Timer();
        object Lock_Islogin = new object();
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_getqrcode_Click(object sender, EventArgs e)
        {
            Facade.LoginFacde loginFacde = new Facade.LoginFacde();

            Models.Response.LoginQrCode Responsemodel = new Models.Response.LoginQrCode();
            if (!loginFacde.GetLoginQrCode(ref Responsemodel))
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
            Timer_CheckLogin.Interval = 1000;
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

                this.lb_Wxid.Text = ResposecheckLogin.Data.WxId;
                Timer_CheckLogin.Stop();
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

        private void Btn_debug_Click(object sender, EventArgs e)
        {
           
        }
    }
}
