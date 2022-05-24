﻿using System;
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
            User httpUser = new User(User.httpUserName, User.httpUserPassword);
            //发送登录post请求
            JObject result = HttpUtil.PostResponse(URL.login, JsonConvert.SerializeObject(httpUser));
            if(result.Count > 0)
            {
                //提取返回的状态码
                int code = result["code"].ToObject<int>();
                if(code == ReturnData.code_success)
                {
                    //登陆成功，更新Authorization
                    //提取token
                    string token = result["data"]["token"].ToObject<string>();
                    UpdateAuthorization(token);
                }else if(code == ReturnData.code_error)
                {
                    //登录失败，显示失败信息
                    MessageUtil.ShowWarning(result["msg"].ToObject<string>());
                }
            }
            else
            {
                MessageUtil.ShowWarning("网络异常...");
            }
            
        }

        /// <summary>
        /// 更新Authorization
        /// </summary>
        private static void UpdateAuthorization(string token)
        {
            //使用"Bearer "拼接token组成authorization
            HttpUtil.authorization = "Bearer " + token;
        }
    }
}
