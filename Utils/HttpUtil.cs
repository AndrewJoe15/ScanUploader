using System;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

using ScanUploader.Model;

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
                //根据状态码做处理
                StatusCodeHandler(response);

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
                    ShowUtil.ShowWarning("服务器无响应，请重新配置环境...");
                    ExceptionUtil.ExceptionHandler("连接失败。");
                }
            }
            return result;
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
                throw new ArgumentNullException("url");
            }
            if (url.StartsWith("https"))
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;

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
                StatusCodeHandler(response);

                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
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
                StatusCodeHandler(response);

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
                StatusCodeHandler(response);

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
                StatusCodeHandler(response);
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
                StatusCodeHandler(response);
                string statusCode = response.StatusCode.ToString();
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

        #region Handles

        /// <summary>
        /// 根据状态码弹出提示框
        /// </summary>
        /// <param name="response">http的返回</param>
        /// <returns></returns>
        private static Boolean StatusCodeHandler(HttpResponseMessage response)
        {
            Boolean ct = true;
            String statusCode = response.StatusCode.ToString();
            string result = response.Content.ReadAsStringAsync().Result;
            JObject jo = (JObject)JsonConvert.DeserializeObject(result);

            if (statusCode == HttpStatusCode.Unauthorized.ToString())
            {
                ShowUtil.ShowWarning("Token过期，重新登录...");
            }
            else if (statusCode == HttpStatusCode.Forbidden.ToString())
            {
                ShowUtil.ShowWarning("禁止访问" + jo["data"]["msg"]);
            }
            else if (statusCode == HttpStatusCode.NotFound.ToString())
            {
                ShowUtil.ShowWarning("404，请求失败。");
            }
            else if (statusCode == HttpStatusCode.BadRequest.ToString())
            {
                ShowUtil.ShowWarning("400");
            }

            return ct;
        }

        #endregion
    }
}
