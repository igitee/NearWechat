using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearWeChat.MKM.Models.Response
{





  
    public class PassVerify
    {
        public VBaseresponse baseResponse { get; set; }
        public int unifyFlag { get; set; }
        public VAuthparam authParam { get; set; }
        public VAccountinfo accountInfo { get; set; }
        public VDnsinfo dnsInfo { get; set; }
    }

    public class VBaseresponse
    {
        public VErrmsg errMsg { get; set; }
        public int ret { get; set; }
    }

    public class VErrmsg
    {
        public string _string { get; set; }
    }

    public class VAuthparam
    {
        public long uin { get; set; }
        public VEcdh ecdh { get; set; }
        public VSession session { get; set; }
        public VAutoauthkey autoAuthKey { get; set; }
        public int wtloginRspBuffFlag { get; set; }
        public VWtloginrspbuff wtloginRspBuff { get; set; }
        public VWtloginimgrespinfo wtloginImgRespInfo { get; set; }
        public VWxverifycoderespinfo wxVerifyCodeRespInfo { get; set; }
        public VClidbencryptkey cliDbencryptKey { get; set; }
        public VClidbencryptinfo cliDbencryptInfo { get; set; }
        public object authKey { get; set; }
        public VA2key a2Key { get; set; }
        public VShowstylekey showStyleKey { get; set; }
        public object authTicket { get; set; }
        public int newVersion { get; set; }
        public int updateFlag { get; set; }
        public int authResultFlag { get; set; }
        public string fsurl { get; set; }
        public int mmtlsControlBitFlag { get; set; }
        public int serverTime { get; set; }
    }

    public class VEcdh
    {
        public int nid { get; set; }
        public VEcdhkey ecdhkey { get; set; }
    }

    public class VEcdhkey
    {
        public int len { get; set; }
        public string key { get; set; }
    }

    public class VSession
    {
        public int len { get; set; }
        public string key { get; set; }
    }

    public class VAutoauthkey
    {
        public int iLen { get; set; }
        public string buffer { get; set; }
    }

    public class VWtloginrspbuff
    {
        public int iLen { get; set; }
        public object buffer { get; set; }
    }

    public class VWtloginimgrespinfo
    {
        public object Imgsid { get; set; }
        public string Imgcode { get; set; }
        public object Imgencrtptkey { get; set; }
        public VKsid Ksid { get; set; }
    }

    public class VKsid
    {
        public int iLen { get; set; }
        public object buffer { get; set; }
    }

    public class VWxverifycoderespinfo
    {
        public object Verifysignatur { get; set; }
        public string Verifycontent { get; set; }
    }

    public class VClidbencryptkey
    {
        public int iLen { get; set; }
        public object buffer { get; set; }
    }

    public class VClidbencryptinfo
    {
        public int iLen { get; set; }
        public object buffer { get; set; }
    }

    public class VA2key
    {
        public int iLen { get; set; }
        public object buffer { get; set; }
    }

    public class VShowstylekey
    {
        public int keycount { get; set; }
        public object key { get; set; }
    }

    public class VAccountinfo
    {
        public string wxid { get; set; }
        public string nickName { get; set; }
        public int bindUin { get; set; }
        public object bindMail { get; set; }
        public string bindMobile { get; set; }
        public string Alias { get; set; }
        public int status { get; set; }
        public int pluginFlag { get; set; }
        public int registerType { get; set; }
        public object deviceInfoXml { get; set; }
        public int safeDevice { get; set; }
        public string officialNamePinyin { get; set; }
        public string officialNameZh { get; set; }
        public int pushMailStatus { get; set; }
        public string fsUrl { get; set; }
    }

    public class VDnsinfo
    {
        public VNewhostlist newHostList { get; set; }
        public VNetworkcontrol networkControl { get; set; }
        public VBuiltiniplist builtinIplist { get; set; }
    }

    public class VNewhostlist
    {
        public int count { get; set; }
        public VList[] list { get; set; }
    }

    public class VList
    {
        public string origin { get; set; }
        public string substitute { get; set; }
        public int priority { get; set; }
    }

    public class VNetworkcontrol
    {
        public string portList { get; set; }
        public string timeoutList { get; set; }
        public int mimNoopInterval { get; set; }
        public int maxNoopInterval { get; set; }
        public int typingInterval { get; set; }
        public int noopIntervalTime { get; set; }
    }

    public class VBuiltiniplist
    {
        public int longConnectIpcount { get; set; }
        public int shortconnectIpcount { get; set; }
        public int seq { get; set; }
        public VLongconnectiplist[] longConnectIplist { get; set; }
        public VShortconnectiplist[] shortConnectIplist { get; set; }
    }

    public class VLongconnectiplist
    {
        public int type { get; set; }
        public int port { get; set; }
        public string ip { get; set; }
        public string domain { get; set; }
    }

    public class VShortconnectiplist
    {
        public int type { get; set; }
        public int port { get; set; }
        public string ip { get; set; }
        public string domain { get; set; }
    }

  
}
