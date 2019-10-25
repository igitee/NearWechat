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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NearWeChat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        HttpHelper httpHelper = new HttpHelper();

        //网页版uuid
        string web_uuid;
        //网页版登录成功跳转地址
        string redirect_uri;

        Timer timer_web = new Timer();


        private void Btn_login_web_Click(object sender, EventArgs e)
        {

            Facade.Web.LoginFacade loginFacade = new Facade.Web.LoginFacade();
            string url = loginFacade.GetLoginQrCode(WebApi.GetLoginQrCode,ref web_uuid);

            WebRequest webreq = WebRequest.Create(url);
            WebResponse webres = webreq.GetResponse();
            Stream stream = webres.GetResponseStream();

            this.tb_log.Text += url;

            Image img = Image.FromStream(stream);
            img= ImageHelper.resizeImage(img, 250, 250);

            this.img_qrcode_web.Image = img;

            timer_web.Interval = 500;
            timer_web.Tick += Timer_web_Tick;
            timer_web.Start();
        }

        private void Timer_web_Tick(object sender, EventArgs e)
        {
            string url = WebApi.CheckIsLogin.Replace("{0}", web_uuid);
            string result= httpHelper.HttpGet(url, string.Empty);

            Dictionary<string, string> dic = NearWechat.Common.ParameterHelper.GetParameterByChat(result);

            string code = dic["window.code"];

            if (!string.IsNullOrEmpty(code)&& code=="200")
            {
                redirect_uri = dic["window.redirect_uri"];
                timer_web.Stop();
            }

        }
    }
}
