using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearWeChat.API.Web
{
   public static class WebApi
    {

        /// <summary>
        /// 获取web登录的url，get方式访问
        /// </summary>
        public const string GetLoginQrCode = "https://login.wx.qq.com/jslogin?appid=wx782c26e4c19acffb&redirect_uri=https%3A%2F%2Fwx.qq.com%2Fcgi-bin%2Fmmwebwx-bin%2Fwebwxnewloginpage&fun=new&lang=zh_CN&_=1540887586026";

        /// <summary>
        /// 检查登录状态，是否登录
        /// </summary>
        public const string CheckIsLogin = "https://login.wx.qq.com/cgi-bin/mmwebwx-bin/login?loginicon=true&uuid={0}&tip=1&r=-39422633&_=1571997452369";


    }
}
