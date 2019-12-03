using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearWeChat.MKM.Models.Response
{
   public class LoginQrCode
    {
        public Data Data;

        public bool Success;

        public string Code;

        public string Message;

    }


    public class Data {

        public string QrBase64;
        public string Uuid;
        public string ExpiredTime;

    }
}
