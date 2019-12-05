using NearWeChat.MKM.Config;
using NearWeChat.MKM.Models.Request;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace NearWeChat.MKM.Facade
{
    public class LoginFacde
    {
        public bool GetLoginQrCode(ref Models.Response.LoginQrCode Responsemodel)
        {

            try
            {

                LoginQrCode postData = new LoginQrCode() { ProxyIp = "", DeviceId = "", ProxyUserName = "", ProxyPassword = "" };
                string json = Tool.HttpHelper.HttpPost(AppConfig.BaseUrl + AppConfig.Login_GetQrCode, postData.ToString());

                Responsemodel = JsonConvert.DeserializeObject<Models.Response.LoginQrCode>(json);


                return true;
            }
            catch (Exception e)
            {

                return false;
            }

        }

        public bool CheckLogin(ref Models.Response.ResponseBase<Models.Response.CheckLogin> ResponseModel, string Uuid)
        {
            try
            {
              
                string json = Tool.HttpHelper.HttpPost(AppConfig.BaseUrl + AppConfig.Login_CheckLogin+"/"+Uuid, string.Empty);

                ResponseModel = JsonConvert.DeserializeObject<Models.Response.ResponseBase<Models.Response.CheckLogin>>(json);


                return true;
            }
            catch (Exception e)
            {

                return false;
            }

        }

        public bool HeartBeat(ref string json,string Wwid)
        {

            try
            {

                 json = Tool.HttpHelper.HttpPost(AppConfig.BaseUrl + AppConfig.Login_HeartBeat + "/" + Wwid, string.Empty);

                return true;
            }
            catch (Exception e)
            {

                return false;
            }


        }

    }
}
