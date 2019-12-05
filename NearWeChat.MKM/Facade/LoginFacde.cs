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
    public class LoginFacde: FacadeBase
    {
        public bool GetLoginQrCode(ref Models.Response.LoginQrCode Responsemodel, LoginQrCode postData)
        {

            try
            {

                string requsetjson = JsonConvert.SerializeObject(postData);
                string json = Tool.HttpHelper.HttpPost(AppConfig.BaseUrl + AppConfig.Login_GetQrCode, requsetjson);

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

        public bool HeartBeat(ref Models.Response.ResponseBase< Models.Response.HeartBeat> ResponseModel, string Wwid)
        {

            try
            {

                 string json = Tool.HttpHelper.HttpPost(AppConfig.BaseUrl + AppConfig.Login_HeartBeat + "/" + Wwid, string.Empty);
                 ResponseModel = JsonConvert.DeserializeObject< Models.Response.ResponseBase <Models.Response.HeartBeat>> (json);
                return true;
            }
            catch (Exception e)
            {

                return false;
            }


        }

        public bool Get62Data(ref string data62, string Wxid)
        {

            try
            {

                data62 = Tool.HttpHelper.HttpPost(AppConfig.BaseUrl + AppConfig.Get62Data + "/" + Wxid, string.Empty);

                return true;
            }
            catch (Exception e)
            {

                return false;
            }


        }

        public bool LoginBy62(ref Models.Response.ResponseBase<Models.Response.Login62Data> responseModel, Login62Data requestModel)
        {

            try
            {
                string requsetjson = JsonConvert.SerializeObject(requestModel);

                string json = Tool.HttpHelper.HttpPost(AppConfig.BaseUrl + AppConfig.Login_62Data, requsetjson, "application/json");

                responseModel = JsonConvert.DeserializeObject<Models.Response.ResponseBase<Models.Response.Login62Data>>(json);


                return true;
            }
            catch (Exception e)
            {
                Msg = "404,网络异常请检查ip或端口";
                return false;
            }


        }

        public bool LoginOut(ref  string json, string Wxid)
        {
            try
            {
                json = Tool.HttpHelper.HttpPost(AppConfig.BaseUrl + AppConfig.LoginOut + "/" + Wxid, string.Empty);
                return true;
            }
            catch (Exception e)
            {
                Msg = "404,网络异常请检查ip或端口";
                return false;
            }


        }
    }
}
