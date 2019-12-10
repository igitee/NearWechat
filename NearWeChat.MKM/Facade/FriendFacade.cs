using NearWeChat.MKM.Config;
using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearWeChat.MKM.Facade
{
   public class FriendFacade:FacadeBase
    {
        
         public bool GetContractList(ref  string json, string wxid,int CurrentWxcontactSeq=0,int CurrentChatRoomContactSeq=0)
        {

            try
            {
                 json = Tool.HttpHelper.HttpPost(AppConfig.BaseUrl + AppConfig.GetContractList+"/"+wxid, string.Empty);
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
