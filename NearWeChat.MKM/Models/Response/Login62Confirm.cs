using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NearWeChat.MKM.Models.Response
{
    /*
    <xml>
    <ShowType>8</ShowType>
    <Content><![CDATA[系统检测到环境存在异常，为了你的帐号安全， 请轻触“确定”进行安全验证。]]></Content>
    <Url><![CDATA[https://weixin110.qq.com/security/readtemplate?t=login_verify_entrances/w_tcaptcha&wechat_real_lang=zh_CN&aid=2000000038&clientype=1&lang=2052&apptype=undefined&captype=7&disturblevel=1&secticket=3_50397325932382587787630267936615]]></Url>
    <DispSec>0</DispSec>
    <Title><![CDATA[]]></Title>
    <Action>1</Action>
    <DelayConnSec>0</DelayConnSec>
    <Countdown>0</Countdown>
    <Ok><![CDATA[]]></Ok>
    <Cancel><![CDATA[]]></Cancel>
    </xml>
    */
    // 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
    /// <remarks/>


    [XmlRoot(ElementName = "e")]
    public partial class Login62Confirm
    {

        private string showTypeField;

        private string contentField;

        private string urlField;

        private string dispSecField;

        private string titleField;

        private string actionField;

        private string delayConnSecField;

        private string countdownField;

        private string okField;

        private string cancelField;

        [XmlElement("ShowType")]
        /// <remarks/>
        public string ShowType
        {
            get
            {
                return this.showTypeField;
            }
            set
            {
                this.showTypeField = value;
            }
        }
        [XmlElement("Content")]
        /// <remarks/>
        public string Content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
            }
        }
        [XmlElement("Url")]
        /// <remarks/>
        public string Url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }
        [XmlElement("DispSec")]
        /// <remarks/>
        public string DispSec
        {
            get
            {
                return this.dispSecField;
            }
            set
            {
                this.dispSecField = value;
            }
        }
        [XmlElement("Title")]
        /// <remarks/>
        public string Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
        [XmlElement("Action")]
        /// <remarks/>
        public string Action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }
        [XmlElement("DelayConnSec")]
        /// <remarks/>
        public string DelayConnSec
        {
            get
            {
                return this.delayConnSecField;
            }
            set
            {
                this.delayConnSecField = value;
            }
        }
        [XmlElement("Countdown")]
        /// <remarks/>
        public string Countdown
        {
            get
            {
                return this.countdownField;
            }
            set
            {
                this.countdownField = value;
            }
        }
        [XmlElement("Ok")]
        /// <remarks/>
        public string Ok
        {
            get
            {
                return this.okField;
            }
            set
            {
                this.okField = value;
            }
        }
        [XmlElement("Cancel")]
        /// <remarks/>
        public string Cancel
        {
            get
            {
                return this.cancelField;
            }
            set
            {
                this.cancelField = value;
            }
        }
    }



   
}
