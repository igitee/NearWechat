using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearWeChat.MKM.Models.Response
{
    public class Login62Data
    {
        public BaseResponse baseResponse;
        public int unifyFlag;
        public authParam authParam;


    }
    public class authParam {

        public int uin;

    }


}
