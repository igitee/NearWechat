using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearWeChat.MKM.Models.Request
{
  public  class TxtMessage:RequestBase
    {
        public IList<string> ToWxIds { get; set; }

        /// <summary>
        /// 发送内容
        /// </summary>
      
        public string Content { get; set; }
    }
}
