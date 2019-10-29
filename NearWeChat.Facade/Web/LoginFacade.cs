using NearWechat.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NearWeChat.Facade.Web
{
   public class LoginFacade
    {

        public string GetLoginQrCode(string api,ref string uuid)
        {
         
      
            string result= HttpHelper.HttpGet(api, string.Empty);

            string code = result.Split(';')[0].Split('=')[1].Trim();
            uuid= result.Split(';')[1].Split('=')[1].Trim().Trim('"').Trim(';')+"==";

            return "https://login.weixin.qq.com/qrcode/"+ uuid;

        }

     

    }
}
