using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearWeChat.MKM.Models.Response
{
   
        public class Login62Data
        {
            public Baseresponse baseResponse { get; set; }
            public int unifyFlag { get; set; }
            public Authparam authParam { get; set; }
            public Accountinfo accountInfo { get; set; }
            public Dnsinfo dnsInfo { get; set; }
        }

        public class Baseresponse
        {
            public Errmsg errMsg { get; set; }
            public int ret { get; set; }
        }

        public class Errmsg
        {
           [JsonProperty("string")]
            public string _string { get; set; }
        }

        public class Authparam
        {
            public int uin { get; set; }
            public Ecdh ecdh { get; set; }
            public Session session { get; set; }
            public Autoauthkey autoAuthKey { get; set; }
            public int wtloginRspBuffFlag { get; set; }
            public Wtloginrspbuff wtloginRspBuff { get; set; }
            public Wtloginimgrespinfo wtloginImgRespInfo { get; set; }
            public Wxverifycoderespinfo wxVerifyCodeRespInfo { get; set; }
            public Clidbencryptkey cliDbencryptKey { get; set; }
            public Clidbencryptinfo cliDbencryptInfo { get; set; }
            public string authKey { get; set; }
            public A2key a2Key { get; set; }
            public Showstylekey showStyleKey { get; set; }
            public string authTicket { get; set; }
            public int newVersion { get; set; }
            public int updateFlag { get; set; }
            public int authResultFlag { get; set; }
            public string fsurl { get; set; }
            public int mmtlsControlBitFlag { get; set; }
            public int serverTime { get; set; }
        }

        public class Ecdh
        {
            public int nid { get; set; }
            public Ecdhkey ecdhkey { get; set; }
        }

        public class Ecdhkey
        {
            public int len { get; set; }
            public string key { get; set; }
        }

        public class Session
        {
            public int len { get; set; }
            public string key { get; set; }
        }

        public class Autoauthkey
        {
            public int iLen { get; set; }
            public string buffer { get; set; }
        }

        public class Wtloginrspbuff
        {
            public int iLen { get; set; }
            public string buffer { get; set; }
        }

        public class Wtloginimgrespinfo
        {
            public string Imgsid { get; set; }
            public string Imgcode { get; set; }
            public string Imgencrtptkey { get; set; }
            public Ksid Ksid { get; set; }
        }

        public class Ksid
        {
            public int iLen { get; set; }
            public string buffer { get; set; }
        }

        public class Wxverifycoderespinfo
        {
            public string Verifysignatur { get; set; }
            public string Verifycontent { get; set; }
        }

        public class Clidbencryptkey
        {
            public int iLen { get; set; }
            public string buffer { get; set; }
        }

        public class Clidbencryptinfo
        {
            public int iLen { get; set; }
            public string buffer { get; set; }
        }

        public class A2key
        {
            public int iLen { get; set; }
            public string buffer { get; set; }
        }

        public class Showstylekey
        {
            public int keycount { get; set; }
            public string key { get; set; }
        }

        public class Accountinfo
        {
            public string wxid { get; set; }
            public string nickName { get; set; }
            public int bindUin { get; set; }
            public string bindMail { get; set; }
            public string bindMobile { get; set; }
            public string Alias { get; set; }
            public int status { get; set; }
            public int pluginFlag { get; set; }
            public int registerType { get; set; }
            public string deviceInfoXml { get; set; }
            public int safeDevice { get; set; }
            public string officialNamePinyin { get; set; }
            public string officialNameZh { get; set; }
            public int pushMailStatus { get; set; }
            public string fsUrl { get; set; }
        }

        public class Dnsinfo
        {
            public Newhostlist newHostList { get; set; }
            public Networkcontrol networkControl { get; set; }
            public Builtiniplist builtinIplist { get; set; }
        }

        public class Newhostlist
        {
            public int count { get; set; }
            public string list { get; set; }
        }

        public class Networkcontrol
        {
            public string portList { get; set; }
            public string timeoutList { get; set; }
            public int mimNoopInterval { get; set; }
            public int maxNoopInterval { get; set; }
            public int typingInterval { get; set; }
            public int noopIntervalTime { get; set; }
        }

        public class Builtiniplist
        {
            public int longConnectIpcount { get; set; }
            public int shortconnectIpcount { get; set; }
            public int seq { get; set; }
            public string longConnectIplist { get; set; }
            public string shortConnectIplist { get; set; }
        }

    }
  


