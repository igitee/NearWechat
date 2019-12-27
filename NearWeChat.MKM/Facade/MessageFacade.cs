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
    public  class MessageFacade:FacadeBase
    {
        public bool SendTxtMessage(ref string json,  TxtMessage requestModel)
        {

            try
            {
                string requsetjson = JsonConvert.SerializeObject(requestModel);

                json = Tool.HttpHelper.HttpPost(AppConfig.BaseUrl + AppConfig.SendTxtMessage, requsetjson);
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
