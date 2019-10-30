using NearWechat.Common;
using NearWeChat.API.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NearWeChat
{
    public partial class Form1 : Form
    {

        //网页版uuid
        string web_uuid;
        //网页版登录成功跳转地址
        string redirect_uri;
        static bool threadflag = true;

        //redirect_uri="https://wx2.qq.com/cgi-bin/mmwebwx-bin/webwxnewloginpage?ticket=Aw-hpu05laJfpuzU3SXmkJDt@qrticket_0&uuid=QZv6ubJUeQ==&lang=zh_CN&scan=1572332389";


        public Form1()
        {
            InitializeComponent();

        }


        private void Btn_login_web_Click(object sender, EventArgs e)
        {

            

            Facade.Web.LoginFacade loginFacade = new Facade.Web.LoginFacade();
            string url = loginFacade.GetLoginQrCode(WebApi.GetLoginQrCode, ref web_uuid);

            WebRequest webreq = WebRequest.Create(url);
            WebResponse webres = webreq.GetResponse();
            Stream stream = webres.GetResponseStream();

            this.tb_log.Text += url;

            Image img = Image.FromStream(stream);
            img = ImageHelper.resizeImage(img, 250, 250);

            this.img_qrcode_web.Image = img;

            Thread td = new Thread(() =>
            {
                Timer_islogin_Tick();
            });

            td.Start();
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

        private void Timer_islogin_Tick()
        {

            while (threadflag)
            {

                Thread.Sleep(2000);
                string url = string.Format(WebApi.CheckIsLogin, web_uuid);
                string result = HttpHelper.HttpGet(url, string.Empty);

                Log(result);

                if (result.Contains("window.code=201"))
                {
                    Log("===========================扫码成功，等待登录==============================");
                }

                if (result.Contains("window.code=200"))
                {
                    redirect_uri = result.Substring(result.IndexOf("redirect_uri"));
                    redirect_uri = redirect_uri.Substring(redirect_uri.IndexOf("https")).TrimStart('\"').TrimEnd(';').TrimEnd('\"');


                    Log("===============================登录成功！====================================");
                    Log(redirect_uri);
                    threadflag = false;
                    LoginSuccess();
                }
            }


        }

        private void LoginSuccess()
        {
            string result= HttpHelper.Get(redirect_uri);
            Log(result);

        }

      
    }
}
