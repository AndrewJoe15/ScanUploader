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
        private static Properties.User_Http httpUserSetting = Properties.User_Http.Default;
        
        public static HttpUser httpUser_MES = new HttpUser(httpUserSetting.username_MES, httpUserSetting.password_MES, httpUserSetting.site_MES);
        /// <summary>
        /// 登录MES 获取token
        /// </summary>
        public static bool HttpLogin(HttpUser httpUser)
        {
            string pData = JsonConvert.SerializeObject(httpUser);

            LogUtil.WriteLog("尝试登录MES。");
            //发送登录post请求
            JObject result = HttpUtil.PostResponse(URL.Instance.httpLogin, pData);            

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
