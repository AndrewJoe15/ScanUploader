using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ChemicalScan.Model;
using ChemicalScan.Utils;

namespace ChemicalScan.Controller
{
    internal static class UserManager
    {
        /// <summary>
        /// 登录MES接口
        /// </summary>
        public static void HttpLogin()
        {
            User httpUser_MES = new User(Properties.UserData.Default.userName_http_MES,
                                     Properties.UserData.Default.password_http_MES,
                                     Properties.UserData.Default.site_http_MES);
            
            //发送登录post请求
            JObject result = HttpUtil.PostResponse(URL.httpLogin, JsonConvert.SerializeObject(httpUser_MES));

            if(result.Count > 0)
            {
                //提取返回的状态码
                string code = result["code"].ToString();
                if(code == ReturnData.code_success)
                {
                    //登陆成功，更新Authorization
                    //提取token
                    string token = result["data"]["access_token"].ToObject<string>();
                    UpdateAuthorization(token);                           
                }else if(code == ReturnData.code_error)
                {
                    //登录失败，显示失败信息
                    ShowUtil.ShowWarning(result["msg"].ToObject<string>());
                }
            }
            else
            {
                ShowUtil.ShowWarning("MES登录失败，网络异常...");
            }
            
        }

        /// <summary>
        /// 登录MES接口
        /// </summary>
        public static void HttpLogin_WMS()
        {
            User httpUser_WMS = new User(Properties.UserData.Default.userName_http_WMS,
                                     Properties.UserData.Default.password_http_WMS,
                                     "");

            //发送登录post请求
            JObject result = HttpUtil.PostResponse(Properties.URL.Default.httpLogin_WMS, JsonConvert.SerializeObject(httpUser_WMS));

            if (result.Count > 0)
            {
                //提取返回的状态码
                string code = result["code"].ToString();
                if (code == ReturnData.code_success)
                {
                    //登陆成功，更新Authorization
                    //提取token
                    string token = result["data"]["access_token"].ToObject<string>();
                    //更新WMS的token
                    UpdateAuthorization(token, ref HttpUtil.authorization_WMS);
                }
                else if (code == ReturnData.code_error)
                {
                    //登录失败，显示失败信息
                    ShowUtil.ShowWarning(result["msg"].ToObject<string>());
                }
            }
            else
            {
                ShowUtil.ShowWarning("网络异常，WMS登录失败...");
            }
        }

        /// <summary>
        /// 更新Authorization
        /// </summary>
        private static void UpdateAuthorization(string token)
        {
            //使用"Bearer "拼接token组成authorization
            HttpUtil.authorization_MES = "Bearer " + token;
        }

        /// <summary>
        /// 更新Authorization
        /// </summary>
        private static void UpdateAuthorization(string token, ref string auth)
        {
            //使用"Bearer "拼接token组成authorization
            auth = "Bearer " + token;
        }
    }
}
