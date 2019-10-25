using NearWechat.Common;
using NearWeChat.API.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void btn_qrcode_login_Click(object sender, EventArgs e)
        {

      
        }

        private void Btn_login_web_Click(object sender, EventArgs e)
        {
            HttpHelper httpHelper = new NearWechat.Common.HttpHelper();

            string result = httpHelper.HttpGet(WebApi.GetLoginQrCode, string.Empty);

            this.tb_log.Text = result;

        }
    }
}
