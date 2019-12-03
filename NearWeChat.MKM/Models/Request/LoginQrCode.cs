using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearWeChat.MKM.Models.Request
{
   public class LoginQrCode
    {
        /// <summary>
        /// 代理Ip
        /// </summary>
        public string ProxyIp { get; set; }


        /// <summary>
        /// 代理用户名
        /// </summary>
        public string ProxyUserName { get; set; }

        /// <summary>
        /// 代理密码
        /// </summary>
        public string ProxyPassword { get; set; }

        /// <summary>
        /// 设备Id
        /// </summary>
        public string DeviceId { get; set; }

    }
}
