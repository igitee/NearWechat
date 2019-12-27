﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearWeChat.MKM.Models.Response
{
    public class InitUserResponse
    {
        /// <summary>
        /// buffer
        /// </summary>
        public string Buffer { get; set; }

        /// <summary>
        /// 同步Key
        /// </summary>
        public int SyncKey { get; set; }

    }
}
