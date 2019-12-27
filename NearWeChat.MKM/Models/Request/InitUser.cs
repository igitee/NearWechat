using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearWeChat.MKM.Models.Request
{
   public class InitUser:RequestBase
    {
        /// <summary>
        /// 同步key
        /// </summary>
        public int SyncKey { get; set; }

        /// <summary>
        /// buffer
        /// </summary>
        public string Buffer { get; set; }

    }
}
