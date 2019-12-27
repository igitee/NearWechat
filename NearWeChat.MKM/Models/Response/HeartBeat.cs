using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearWeChat.MKM.Models.Response
{
  
    public class HeartBeat
    {
        public BaseResponse baseResponse;
        public int NextTime;
        public decimal Selector;
        public BlueToothBroadCastContent blueToothBroadCastContent;
    }

    public class BaseResponse {

        public int Ret;
        public ErrMsg ErrMsg;


    }
    public class ErrMsg {
        public string String;
    }
    public class BlueToothBroadCastContent
    {
        public int iLen;
        public string Buffer;
    }
}
