using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearWeChat.MKM.Models.Request
{
  public  class Login62Data
    { 
        /// <summary>
      /// 用户名
      /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// data62数据
        /// </summary>
        public string Data62 { get; set; }

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
    }
}
