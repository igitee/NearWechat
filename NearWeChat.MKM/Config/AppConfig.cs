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

        /// <summary>
        /// 二维码登录
        /// </summary>
        public static string Login_GetQrCode = "api/Login/GetQrCode";

        /// <summary>
        /// 检查是否登录
        /// </summary>
        public static string Login_CheckLogin = "api/Login/CheckLogin";

        /// <summary>
        /// 心跳
        /// </summary>
        public static string Login_HeartBeat = "api/Login/HeartBeat";

        /// <summary>
        /// 获取62数据
        /// </summary>
        public static string Get62Data = "api/Login/Get62Data";

        /// <summary>
        /// 62登录
        /// </summary>
        public static string Login_62Data = "api/Login/Data62Login";

        /// <summary>
        /// 退出
        /// </summary>
        public static string LoginOut = "api/Login/LogOut";

        /// <summary>
        /// 二次登录
        /// </summary>
        public static string TwiceLogin = "api/Login/TwiceLogin";

        /// <summary>
        /// 确认登录
        /// </summary>
        public static string ExtDeviceLoginConfirmOK = "api/Login/ExtDeviceLoginConfirmOK";

        /// <summary>
        /// 获取授权登录
        /// </summary>
        public static string ExtDeviceLoginConfirmGet = "api/Login/ExtDeviceLoginConfirmGet";

        /// <summary>
        /// 初始化用户信息
        /// </summary>
        public static string NewInit = "api/Login/NewInit";

    }
}
