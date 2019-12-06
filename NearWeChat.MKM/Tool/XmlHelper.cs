using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace NearWeChat.MKM.Tool
{
  public static  class XmlHelper
    {

        /// <summary>
        /// 序列化object对象为XML字符串
        /// </summary>
        /// <param name="obj">实体类或List集合类</param>
        /// <returns></returns>
        public static string Serialize(object obj)
        {
            return Serialize(obj, false, true);
        }
        /// <summary>
        /// 序列化object对象为XML字符串
        /// </summary>
        /// <param name="obj">实体类或List集合类</param>
        /// <param name="isOmitXmlDeclaration"><![CDATA[是否去除Xml声明<?xml version="1.0" encoding="utf-8"?>]]></param>
        /// <param name="isIndent">是否缩进显示</param>
        /// <returns></returns>
        public static string Serialize(object obj, bool isOmitXmlDeclaration, bool isIndent)
        {
            try
            {
                string xmlString;
                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();

                //去除xml声明
                //<?xml version="1.0" encoding="utf-8"?>
                xmlWriterSettings.OmitXmlDeclaration = isOmitXmlDeclaration;
                //不换行不缩进
                xmlWriterSettings.Indent = isIndent;
                //默认为UTF8编码
                xmlWriterSettings.Encoding = Encoding.UTF8;

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings))
                    {
                        //去除默认命名空间xmlns:xsd和xmlns:xsi
                        XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                        ns.Add("", "");

                        //序列化对象
                        XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());
                        xmlSerializer.Serialize(xmlWriter, obj, ns);
                    }
                    xmlString = Encoding.UTF8.GetString(memoryStream.ToArray());
                }
                return xmlString.TrimStart('?');
            }
            catch (Exception)
            {
                return null;
            }
        }

        ///////////////////////////////////////////////////////////////
        /// <summary>
        /// XMLHelper
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static string Serialize<T>(T model) where T : class
        {
            string xml;
            using (var ms = new MemoryStream())
            {
                XmlSerializer xmlSer = new XmlSerializer(typeof(T));
                xmlSer.Serialize(ms, model);
                ms.Position = 0;
                StreamReader sr = new StreamReader(ms);
                xml = sr.ReadToEnd();
            }
            return xml;
        }

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="strXml">xml文件</param>
        /// <returns></returns>
        public static T Deserialize<T>(string strXml) where T : class
        {
            try
            {
                object obj;
                using (MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(strXml)))
                {
                    using (XmlReader xmlReader = XmlReader.Create(memoryStream))
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                        obj = xmlSerializer.Deserialize(xmlReader);
                    }
                }
                return obj as T;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="stream">流文件</param>
        /// <returns></returns>
        public static T Deserialize<T>(Stream stream) where T : class
        {
            try
            {
                object obj;
                XmlSerializer xmldes = new XmlSerializer(typeof(T));
                obj = xmldes.Deserialize(stream);

                return obj as T;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
