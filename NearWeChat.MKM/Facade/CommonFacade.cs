using NearWeChat.MKM.Config;
using NearWeChat.MKM.Models.Request;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearWeChat.MKM.Facade
{
    public class CommonFacade : FacadeBase
    {
        public bool SyncMessage(ref string json, string WxId)
        {

            try
            {

                json = Tool.HttpHelper.HttpPost(AppConfig.BaseUrl + AppConfig.SyncMessage + "/" + WxId, string.Empty);
                Msg = json;
                return true;
            }
            catch (Exception e)
            {

                return false;
            }



        }


        public bool ForkOfficialAccountMessage(ref string json, ForkOfficialAccount postData)
        {

            try
            {

                string requsetjson = JsonConvert.SerializeObject(postData);
                json = Tool.HttpHelper.HttpPost(AppConfig.BaseUrl + AppConfig.Login_GetQrCode, requsetjson);

                Msg = json;


                return true;
            }
            catch (Exception e)
            {

                return false;
            }


        }




    }
}