using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ScanUploader.Utils
{
    public static class JsonUtil
    {
        /// <summary>
        /// 将对象序列化为Json
        /// </summary>
        /// <param name="obj">对象</param>
        /// <returns></returns>
        public static JObject ToJObject(object obj)
        {
            return JObject.Parse(JsonConvert.SerializeObject(obj));
        }

        /// <summary>
        /// 添加一个键值对
        /// </summary>
        /// <param name="obj">要转为Json的对象</param>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        /// <returns>添加属性后的对象</returns>
        public static string ToJson(object obj, string key, object value)
        {
            JObject jObj = ToJObject(obj);
            jObj.Add(new JProperty(key, value));
            return jObj.ToString();
        }

        public static JObject ToJson(object obj, Dictionary<string, string> kvDic)
        {
            JObject jObj = ToJObject(obj);
            foreach(var kv in kvDic)
            {
                jObj.Add(new JProperty(kv.Key, kv.Value));
            }
            return jObj;
        }
    }
}
