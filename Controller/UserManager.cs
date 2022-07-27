using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ScanUploader.Model;
using ScanUploader.Utils;
using ScanUploader.View;

namespace ScanUploader.Controller
{
    internal static class UserManager
    {
        public static HttpUser httpUser_MES = new HttpUser(Properties.User_Http.Default.username_MES,
                                     Properties.User_Http.Default.password_MES,
                                     Properties.User_Http.Default.site_MES);
        /// <summary>
        /// 登录MES 获取token
        /// </summary>
        public static bool HttpLogin(HttpUser httpUser)
        {
            string pData = JsonConvert.SerializeObject(httpUser);

            LogUtil.WriteLog("尝试登录MES。");
            UIInfoManager.AppendDebugInfo("上位机->MES，\r\n" + pData);
            //发送登录post请求
            JObject result = HttpUtil.PostResponse(URL.httpLogin, pData);            

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
                    //更新界面Http登录状态
                    MainForm.thisForm.UpdateHttpStatus(true);
                    LogUtil.WriteLog("MES登录成功。");
                    UIInfoManager.AppendDebugInfo("MES->上位机，\r\n" + result);

                    return true;
                }
                else
                {
                    //更新界面Http登录状态
                    MainForm.thisForm.UpdateHttpStatus(false);
                    //登录失败，显示失败信息
                    ShowUtil.ShowWarning(result?["msg"].ToObject<string>());

                    return false;
                }
            }
            else
            {
                //更新界面Http登录状态
                MainForm.thisForm.UpdateHttpStatus(false);
                ShowUtil.ShowWarning("MES登录失败。");

                return false;
            }
            
        }

        /// <summary>
        /// 登录WMS接口
        /// </summary>
        public static void HttpLogin_WMS()
        {
            HttpUser httpUser_WMS = new HttpUser(Properties.User_Http.Default.userName_http_WMS,
                                     Properties.User_Http.Default.password_http_WMS,
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
