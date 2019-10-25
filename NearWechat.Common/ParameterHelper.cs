using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace NearWechat.Common
{
    public static  class ParameterHelper
    {

        /// <summary>
        /// 根据分号;获取参数
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static Dictionary<string,string> GetParameterByChat(string str)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            string[] array = str.Split(';');

            foreach (var item in array)
            {
                string key, value;

                if (item.Split('=').Length > 1)
                {
                    key = item.Substring(0, item.IndexOf('='));
                    value = item.Substring(item.IndexOf('='), item.Length);
                }
                else {
                    key = item.Split('=')[0];
                    value = item.Split('=')[1];

                }

                dic.Add(key, value);
            }
            return dic;

        }

       /// <summary>
       /// 获取url参数
       /// </summary>
       /// <param name="str"></param>
       /// <returns></returns>
        public static Dictionary<string, string> GetParameterByUrl(string queryString,Encoding encoding, bool isEncoded)
        {
            queryString = queryString.Replace("?", "");
            Dictionary<string, string> result = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(queryString))
            {
                int count = queryString.Length;
                for (int i = 0; i < count; i++)
                {
                    int startIndex = i;
                    int index = -1;
                    while (i < count)
                    {
                        char item = queryString[i];
                        if (item == '=')
                        {
                            if (index < 0)
                            {
                                index = i;
                            }
                        }
                        else if (item == '&')
                        {
                            break;
                        }
                        i++;
                    }
                    string key = null;
                    string value = null;
                    if (index >= 0)
                    {
                        key = queryString.Substring(startIndex, index - startIndex);
                        value = queryString.Substring(index + 1, (i - index) - 1);
                    }
                    else
                    {
                        key = queryString.Substring(startIndex, i - startIndex);
                    }
                    if (isEncoded)
                    {
                        result[MyUrlDeCode(key, encoding)] = MyUrlDeCode(value, encoding);
                    }
                    else
                    {
                        result[key] = value;
                    }
                    if ((i == (count - 1)) && (queryString[i] == '&'))
                    {
                        result[key] = string.Empty;
                    }
                }
            }
            return result;



        }

        private static string MyUrlDeCode(string str, Encoding encoding)
        {
            if (encoding == null)
            {
                Encoding utf8 = Encoding.UTF8;
                //首先用utf-8进行解码                     
                string code = HttpUtility.UrlDecode(str.ToUpper(), utf8);
                //将已经解码的字符再次进行编码.
                string encode = HttpUtility.UrlEncode(code, utf8).ToUpper();
                if (str == encode)
                    encoding = Encoding.UTF8;
                else
                    encoding = Encoding.GetEncoding("gb2312");
            }
            return HttpUtility.UrlDecode(str, encoding);
        }

        }
    }
