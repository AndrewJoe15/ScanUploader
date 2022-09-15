using System;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using RestSharp;

using ScanUploader.View;
using ScanUploader.Controller;

namespace ScanUploader.Utils
{
    internal class HttpUtil
    {
        //post请求的Authorization，格式Bearer token
        //例如: Bearer 10a4b28d‐476d‐4166‐b65d‐651be75df9f8
        public static string authorization_MES = string.Empty; //初值为""
        public static string authorization_WMS = string.Empty; 

        /// <summary>
        /// Get请求 模板方法
        /// </summary>
        /// <typeparam name="T">模板类型</typeparam>
        /// <param name="url">请求链接</param>
        /// <returns>模板类型对象</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static T GetResponse<T>(string url) where T : class, new()
        {
            T result = default(T);
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("url");
            }
            //http客户端对象
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            if (authorization_MES.Length > 0)
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", authorization_MES);
            }
            try
            {
                //发送get请求
                HttpResponseMessage response = httpClient.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    Task<string> t = response.Content.ReadAsStringAsync();
                    string s = t.Result;
                    result = JsonConvert.DeserializeObject<T>(s);
                }
            }
            catch (Exception e)
            {
                string msg = e.InnerException.InnerException.Message;
                if (msg == "无法连接到远程服务器...")
                {
                    ShowUtil.ShowWarning("服务器无响应。");
                    //ExceptionUtil.ExceptionHandler(e);
                }
            }
            return result;
        }


        /// <summary>
        /// get请求 
        /// body中带一个参数 form-data格式
        /// </summary>
        /// <param name="url"></param>
        /// <param name="postData">post数据</param>
        /// <returns>json对象</returns>
        public static JObject GetResponse(string url, string key, string value)
        {
            if (string.IsNullOrEmpty(url))
            {
                ShowUtil.ShowError("URL不能为空。");
                return new JObject();
            }

            UIInfoManager.AppendDebugInfo("上位机->MES，" + key + ":" + value);

            if (url.StartsWith("https"))
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();

            request.Method = Method.Get;
            request.Timeout = -1;
            //request.AlwaysMultipartFormData = true;
            //request.AddHeader("content-type", "multipart/form-data");
            request.AddParameter(key, value);

            if (authorization_MES.Length > 0)
            {
                request.AddHeader("Authorization", authorization_MES);
            }
            try
            {
                RestResponse response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    string result = response.Content;
                    JObject jo = (JObject)JsonConvert.DeserializeObject(result);

                    UIInfoManager.AppendDebugInfo("MES->上位机，" + jo.ToString());

                    return jo;
                }
                else if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    //处理令牌为空的报错                    
                    MainForm.thisForm.UpdateHttpStatus(false);
                    JObject jo = new JObject();
                    jo.Add("code", (int)HttpStatusCode.Unauthorized);
                    jo.Add("msg", "MES登录失效，请重新登录。");

                    UIInfoManager.AppendDebugInfo("MES->上位机，" + jo.ToString());

                    return jo;
                }
            }
            catch (Exception e)
            {
                ExceptionUtil.ExceptionHandler(e);
            }
            return new JObject();
        }

        /// <summary>
        /// post请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="postData">post数据</param>
        /// <returns>json对象</returns>
        public static JObject PostResponse(string url, string postData)
        {
            if (string.IsNullOrEmpty(url))
            {
                return new JObject();
            }

            UIInfoManager.AppendDebugInfo("上位机->MES，" + postData);

            if (url.StartsWith("https"))
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;

            HttpContent httpContent = new StringContent(postData);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpClient httpClient = new HttpClient();
            if (authorization_MES.Length > 0)
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", authorization_MES);
            }
            try
            {
                HttpResponseMessage response = httpClient.PostAsync(url, httpContent).Result;

                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    JObject jo = (JObject)JsonConvert.DeserializeObject(result);

                    UIInfoManager.AppendDebugInfo("MES->上位机，" + jo.ToString());
                    
                    return jo;
                }
                else if(response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    //处理令牌为空的报错                    
                    MainForm.thisForm.UpdateHttpStatus(false);
                    JObject jo = new JObject();
                    jo.Add("code", (int)HttpStatusCode.Unauthorized);
                    jo.Add("msg", "MES登录失效，请重新登录。");

                    UIInfoManager.AppendDebugInfo("MES->上位机，" + jo.ToString());

                    return jo;
                }
            }
            catch (Exception e)
            {
                ExceptionUtil.ExceptionHandler(e);
            }
            return new JObject();
        }

        public static JObject PostResponse_WMS(string url, string postData)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("url");
            }
            if (url.StartsWith("https"))
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;

            HttpContent httpContent = new StringContent(postData);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpClient httpClient = new HttpClient();
            if (authorization_WMS.Length > 0)
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", authorization_WMS);
            }
            try
            {
                HttpResponseMessage response = httpClient.PostAsync(url, httpContent).Result;

                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    //WMS发来的数据可能带有中括号，移除中括号
                    if (result.Contains("["))
                        result.Remove(result.IndexOf("["), 1);
                    if (result.Contains("]"))
                        result.Remove(result.IndexOf("]"), 1);

                    JObject jo = (JObject)JsonConvert.DeserializeObject(result);
                    return jo;
                }
            }
            catch (Exception e)
            {
                ExceptionUtil.ExceptionHandler(e);
            }
            return new JObject();
        }


        /// <summary>
        /// 发起post请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url">url</param>
        /// <param name="postData">post数据</param>
        /// <returns></returns>
        public static T PostResponse<T>(string url, string postData) where T : class, new()
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("url");
            }
            if (url.StartsWith("https"))
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;

            HttpContent httpContent = new StringContent(postData);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpClient httpClient = new HttpClient();

            T result = default(T);
            if (authorization_MES.Length > 0)
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", authorization_MES);
            }
            try
            {
                HttpResponseMessage response = httpClient.PostAsync(url, httpContent).Result;

                if (response.IsSuccessStatusCode)
                {
                    Task<string> t = response.Content.ReadAsStringAsync();
                    string s = t.Result;

                    result = JsonConvert.DeserializeObject<T>(s);
                }
            }
            catch (Exception e)
            {
                string msg = e.InnerException.InnerException.Message;
                if (msg == "无法连接到远程服务器")
                {
                    ShowUtil.ShowWarning("服务器无响应，请重新配置环境");
                    ExceptionUtil.ExceptionHandler("连接失败");
                }
            }
            return result;
        }


        /// <summary>
        /// put请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="putData">put数据</param>
        /// <returns></returns>
        public static JObject PutResponse(string url, string putData = "")
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("url");
            }
            if (url.StartsWith("https"))
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;

            HttpContent httpContent = new StringContent(putData);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpClient httpClient = new HttpClient();
            if (authorization_MES.Length > 0)
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", authorization_MES);
            }
            try
            {
                HttpResponseMessage response = httpClient.PutAsync(url, httpContent).Result;
                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    JObject jo = (JObject)JsonConvert.DeserializeObject(result);
                    return jo;
                }
            }
            catch (Exception e)
            {
                string msg = e.InnerException.InnerException.Message;
                if (msg == "无法连接到远程服务器")
                {
                    ShowUtil.ShowWarning("服务器无响应，请重新配置环境");
                    ExceptionUtil.ExceptionHandler("连接失败");
                }
            }
            return new JObject();
        }

        /// <summary>
        /// delete请求
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static JObject DeleteResponse(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("url");
            }
            if (url.StartsWith("https"))
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;

            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            if (authorization_MES.Length > 0)
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", authorization_MES);
            }
            try
            {
                HttpResponseMessage response = httpClient.DeleteAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;

                    JObject jo = (JObject)JsonConvert.DeserializeObject(result);
                    return jo;
                }
            }
            catch (Exception e)
            {
                string msg = e.InnerException.InnerException.Message;
                if (msg == "无法连接到远程服务器")
                {
                    ShowUtil.ShowWarning("服务器无响应，请检测连接配置。");
                    ExceptionUtil.ExceptionHandler("连接失败");
                }
            }
            return new JObject();
        }

    }
}
