using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearWeChat.MKM.Config
{
   public class AppConfig
    {
        public static string BaseUrl = "http://192.168.0.91:62629/";

        public static string Login_GetQrCode = "api/Login/GetQrCode";

        public static string Login_CheckLogin = "api/Login/CheckLogin";

        public static string Login_HeartBeat = "api/Login/HeartBeat";

        public static string Get62Data = "api/Login/Get62Data";

        public static string Login_62Data = "api/Login/Data62Login";

    }
}
