﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ChemicalScan.Model;
using ChemicalScan.Utils;

namespace ChemicalScan.Controller
{
    /// <summary>
    /// 数据处理类
    /// </summary>
    public class Communicator
    {
        //Machine发来字符串数据分割符号
        private const char splitChar = ',';
        private const string containerOut_ID_0   = "L1";
        private const string containerOut_ID_1   = "L2";
        private const string SN_ID_0            = "L3";
        private const string SN_ID_1            = "L4";
        private const string containerIn_ID_0  = "L5";
        private const string containerIn_ID_1  = "L6";
        private const string submit_ID  = "L7";
        private const string unbind_ID  = "L8";

        /// <summary>
        /// 向MES请求数据
        /// </summary>
        /// <param name="deviceCodeKey"></param>
        /// <param name="deviceCodeValue"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string GetCodeFromMES(string deviceCodeKey, string deviceCodeValue, string url)
        {
            string code = "";

            BasicInfo.Instance.createTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string dataToMES = JsonUtil.ToJson(BasicInfo.Instance, deviceCodeKey, deviceCodeValue);

            Debug.WriteLine(dataToMES);
            LogUtil.WriteLog("发给MES端口的消息: \n" + dataToMES);

            JObject dataFromMes = HttpUtil.PostResponse(url, dataToMES);
            if(dataFromMes["code"] != null)
            {
                code = dataFromMes["code"].ToString();
                LogUtil.WriteLog("收到MES端口的消息: \n" + dataFromMes);
            }

            return code;
        }

        public static ReturnData GetReturnFromMES(string deviceCodeKey, string deviceCodeValue, string url)
        {
            ReturnData rdata = null;

            BasicInfo.Instance.createTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string dataToMES = JsonUtil.ToJson(BasicInfo.Instance, deviceCodeKey, deviceCodeValue);

            Debug.WriteLine(dataToMES);
            LogUtil.WriteLog("发给MES端口的消息: \n" + dataToMES);

            JObject dataFromMes = HttpUtil.PostResponse(url, dataToMES);
            
            if (dataFromMes["code"] != null)
            {
                //确保发回来的body有内容才赋值
                rdata = new ReturnData();
                rdata.code = dataFromMes["code"].ToString();
                rdata.msg = dataFromMes["msg"].ToString();
                if(dataFromMes["data"] != null)
                    rdata.data = dataFromMes["data"].ToString();
                LogUtil.WriteLog("收到MES端口的消息: \n" + dataFromMes.ToString());
            }

            return rdata;
        }

        /// <summary>
        /// Communicator <-> MES 
        /// 解析Machine发来的数据，发送给MES，并整理MES传回的数据
        /// </summary>
        /// <param name="str">Machine 发来的字符串</param>
        public static ReturnData GetDataFromMES(string str)
        {
            //设备编号,设备码  L1,220421XSH01 
            string[] subs = str.Split(splitChar);
            string deviceID = subs[0];
            string deviceCode = subs[1];
            //string dataToMachine = deviceID;//字符串最开始为 "L1..." "L2..."
            ReturnData dataToMachine = new ReturnData();
            //化抛架 载具扫出
            if (deviceID == containerOut_ID_0 || deviceID == containerOut_ID_1)
            {
                //GetData(ref dataToMachine, "containerCode", deviceCode, URL.scanContainerOut);
                //dataToMachine = GetCodeFromMES("containerCode", deviceCode, URL.scanContainerOut);
                dataToMachine = GetReturnFromMES("containerCode", deviceCode, URL.scanContainerOut);
            }
            //玻璃
            if (deviceID == SN_ID_0 || deviceID == SN_ID_1)
            {
                //GetData(ref dataToMachine, "snNumber", deviceCode, URL.scanSn);
                //dataToMachine = GetCodeFromMES("snNumber", deviceCode, URL.scanSn);
                dataToMachine = GetReturnFromMES("snNumber", deviceCode, URL.scanSn);
            }
            //载具 扫入
            if (deviceID == containerIn_ID_0 || deviceID == containerIn_ID_1)
            {
                //GetData(ref dataToMachine, "containerCode", deviceCode, URL.scanContainerIn);
                //dataToMachine = GetCodeFromMES("containerCode", deviceCode, URL.scanContainerIn);
                dataToMachine = GetReturnFromMES("containerCode", deviceCode, URL.scanContainerIn);
            }

            //解绑
            if(deviceID == unbind_ID)
            {
                //dataToMachine = GetCodeFromMES("containerCode", deviceCode, URL.scanContainerUnbind);
                dataToMachine = GetReturnFromMES("containerCode", deviceCode, URL.scanContainerUnbind);
            }

            //提交
            if (deviceID == submit_ID)
            {
                //dataToMachine = GetCodeFromMES("containerCode", deviceCode, URL.scanSubmit);
                dataToMachine = GetReturnFromMES("containerCode", deviceCode, URL.scanSubmit);
            }

            return dataToMachine;
        }


        /// <summary>
        /// 从MES端获取数据，整理成字符串准备发给Machine
        /// </summary>
        /// <param name="dataToMachine">准备发给Machine的字符串</param>
        /// <param name="deviceCodeKey">MES返回Json中码的键</param>
        /// <param name="deviceCodeValue">Json中码的值</param>
        /// <param name="url">链接</param>
        private static void GetData(ref string dataToMachine, string deviceCodeKey ,string deviceCodeValue, string url)
        {
            BasicInfo.Instance.createTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string dataToMES = JsonUtil.ToJson(BasicInfo.Instance, deviceCodeKey, deviceCodeValue);

            Debug.WriteLine(dataToMES);
            LogUtil.WriteLog("发给MES端口的消息: " + dataToMES);

            JObject dataFromMes = HttpUtil.PostResponse(url, dataToMES);

            LogUtil.WriteLog("收到MES端口的消息: " + dataFromMes);

            ConcatData(ref dataToMachine, deviceCodeKey, deviceCodeValue);
            ConcatData(ref dataToMachine, "code", dataFromMes["code"].ToString());
        }

        /// <summary>
        /// 在字符串后添加数据 L1,键:值,键:值
        /// </summary>
        private static void ConcatData(ref string str, string key, string value)
        {
            str += ("," + key + ":" + value);
        }
    }
}
