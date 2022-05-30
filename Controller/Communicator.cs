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
using ChemicalScan.View;

namespace ChemicalScan.Controller
{
    /// <summary>
    /// 数据处理类
    /// </summary>
    public class Communicator
    {
        //PLC发来字符串数据分割符号
        private const char splitChar = ',';
        
        //*****PLC发过来字符串的标识符
        //上料
        //-扫出
        private const string containerOut_ID_Left   = "L1";
        private const string containerOut_ID_Right   = "L2";
        //-解绑
        private const string unbind_ID_Left = "L11";
        private const string unbind_ID_Right = "L12";
        //主体
        //-玻璃
        private const string SN_ID_Left            = "L3";
        private const string SN_ID_Right            = "L4";
        //下料
        //-扫入
        private const string containerIn_OK_ID  = "L5";
        private const string containerIn_NG_ID  = "L6";
        //-提交
        private const string submit_OK_Left  = "OK2";
        private const string submit_OK_Right  = "OK1"; 
        private const string submit_NG_Left  = "NG2"; 
        private const string submit_NG_Right  = "NG1"; 
        private const string submit_OK_Left_Finish  = "OK2FINISH";
        private const string submit_OK_Right_Finish  = "OK1FINISH"; 
        private const string submit_NG_Left_Finish  = "NG2FINISH"; 
        private const string submit_NG_Right_Finish  = "NG1FINISH"; 

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
            JObject dataFromMes = null;

            //更新BasicInfo的生成时间
            BasicInfo.Instance.createTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //添加<码,值> 生成json数据
            string dataToMES = JsonUtil.ToJson(BasicInfo.Instance, deviceCodeKey, deviceCodeValue);

            if (dataToMES != null && dataToMES.Trim()!="")
            {
                Debug.WriteLine(dataToMES);
                LogUtil.WriteLog("发给MES端口的消息: \n" + dataToMES);

                dataFromMes = HttpUtil.PostResponse(url, dataToMES);
            }

            if (dataFromMes != null)
            {
                if (dataFromMes["code"] != null)
                {
                    //确保发回来的body有内容才赋值
                    rdata = new ReturnData();
                    rdata.code = dataFromMes["code"].ToString();
                    rdata.msg = dataFromMes["msg"].ToString();
                    if (dataFromMes["data"] != null)
                        rdata.data = dataFromMes["data"].ToString();
                    LogUtil.WriteLog("收到MES端口的消息: \n" + dataFromMes.ToString());
                }
            }
            return rdata;
        }

        public static ReturnData SubmitToMES(String submitData, string url)
        {
            ReturnData rdata = null;

            Debug.WriteLine(submitData);
            LogUtil.WriteLog("提交，发给MES端口的消息: \n" + submitData);

            JObject dataFromMes = HttpUtil.PostResponse(url, submitData);

            if (dataFromMes["code"] != null)
            {
                //确保发回来的body有内容才赋值
                rdata = new ReturnData();
                rdata.code = dataFromMes["code"].ToString();
                rdata.msg = dataFromMes["msg"].ToString();
                if (dataFromMes["data"] != null)
                    rdata.data = dataFromMes["data"].ToString();
                LogUtil.WriteLog("收到MES端口的消息: \n" + dataFromMes.ToString());
            }

            return rdata;
        }

        /// <summary>
        /// 提交数据，清空list
        /// </summary>
        /// <param name="glasses"></param>
        /// <returns></returns>

        private static ReturnData SubmitToMES(ref List<Glass> glasses)
        {
            ReturnData dataToMachine;
            SubmitData submitData = new SubmitData();

            BasicInfo.Instance.createTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            submitData.logNumber = LogUtil.logNumber;
            submitData.mo = MainForm.thisForm.textBox_mo.Text;//工单号

            submitData.qty = glasses.Count.ToString();//qty 载具内玻璃数量
            submitData.supplementList = glasses;


            //拼接Json数据
            JObject submitJson = JsonUtil.ToJObject(BasicInfo.Instance);
            JObject tmp = JsonUtil.ToJObject(submitData);
            submitJson.Merge(tmp);

            dataToMachine = SubmitToMES(submitJson.ToString(), URL.scanSubmit);

            glasses.Clear();//清空list
            
            return dataToMachine;
        }

        /// <summary>
        /// 将玻璃添加到list中
        /// </summary>
        /// <param name="glass"></param>
        /// <param name="glassList"></param>
        /// <returns></returns>
/*        private static void AddGlassToContainer(Glass glass, ref List<Glass> glassList)
        {
            glassList.Add(glass);
        }*/

        /// <summary>
        /// Communicator <-> MES 
        /// 解析Machine发来的数据，发送给MES，并整理MES传回的数据
        /// 不端口，统一处理
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
            if (deviceID == containerOut_ID_Left || deviceID == containerOut_ID_Right)
            {
                dataToMachine = GetReturnFromMES("containerCode", deviceCode, URL.scanContainerOut);
            }
            //玻璃
            if (deviceID == SN_ID_Left || deviceID == SN_ID_Right)
            {
                dataToMachine = GetReturnFromMES("snNumber", deviceCode, URL.scanSn);
                if (deviceCode == "NoRead")
                    dataToMachine.code = ReturnData.code_error;
            }
            //载具 扫入
            if (deviceID == containerIn_OK_ID || deviceID == containerIn_NG_ID)
            {
                dataToMachine = GetReturnFromMES("containerCode", deviceCode, URL.scanContainerIn);
            }

            //解绑
            if(deviceID == unbind_ID_Left || deviceID == unbind_ID_Right)
            {
                dataToMachine = GetReturnFromMES("containerCode", deviceCode, URL.scanContainerUnbind);
            }

            //提交
            // OK1,cOut,cIn,SN,
            if (subs.Length >= 4)
            {
                Glass glass = new Glass();
                glass.sourceVehicle = subs[1];
                glass.targetVehicle = subs[2];
                glass.snNumber = subs[3];

                if (deviceID == submit_OK_Left)
                    GlobalValue.GlassList_OK_Left.Add(glass);
                if (deviceID == submit_OK_Right)
                    GlobalValue.GlassList_OK_Right.Add(glass);
                if (deviceID == submit_NG_Left)
                    GlobalValue.GlassList_NG_Left.Add(glass);
                if (deviceID == submit_NG_Right)
                    GlobalValue.GlassList_NG_Right.Add(glass);
            }

            if(deviceID.ToUpper() == submit_OK_Left_Finish)
                dataToMachine = SubmitToMES(ref GlobalValue.GlassList_OK_Left);
            if (deviceID.ToUpper() == submit_OK_Right_Finish)
                dataToMachine = SubmitToMES(ref GlobalValue.GlassList_OK_Right);
            if (deviceID.ToUpper() == submit_NG_Left_Finish)
                dataToMachine = SubmitToMES(ref GlobalValue.GlassList_NG_Left);
            if (deviceID.ToUpper() == submit_NG_Right_Finish)
                dataToMachine = SubmitToMES(ref GlobalValue.GlassList_NG_Right);

            return dataToMachine;
        }

        /// <summary>
        /// Communicator <-> MES 
        /// 解析Machine发来的数据，发送给MES，并整理MES传回的数据
        /// 分端口号处理
        /// </summary>
        /// <param name="str">Machine 发来的字符串</param>
        public static ReturnData GetDataFromMES(string str, int port)
        {
            //设备编号,设备码  L1,220421XSH01 
            string[] subs = str.Split(splitChar);
            string operationID = subs[0];
            string deviceCode = subs[1];
            //string dataToMachine = deviceID;//字符串最开始为 "L1..." "L2..."
            ReturnData dataToMachine = new ReturnData();
            
            //上料端口
            if (port == ConnectManager.port_L1L2)
            {
                //化抛架 载具扫出
                if (operationID == containerOut_ID_Left || operationID == containerOut_ID_Right)
                {
                    dataToMachine = GetReturnFromMES("containerCode", deviceCode, URL.scanContainerOut);
                }
                //解绑
                if (operationID == unbind_ID_Left || operationID == unbind_ID_Right)
                {
                    dataToMachine = GetReturnFromMES("containerCode", deviceCode, URL.scanContainerUnbind);
                }
            }

            //主体端口
            if (port == ConnectManager.port_L3L4)
            {
                //玻璃
                if (operationID == SN_ID_Left || operationID == SN_ID_Right)
                {
                    dataToMachine = GetReturnFromMES("snNumber", deviceCode, URL.scanSn);
                    if (deviceCode == "NoRead")
                        dataToMachine.code = ReturnData.code_error;
                }
            }

            //下料端口
            if (port == ConnectManager.port_L5L6)
            {
                //载具 扫入
                if (operationID == containerIn_OK_ID || operationID == containerIn_NG_ID)
                {
                    dataToMachine = GetReturnFromMES("containerCode", deviceCode, URL.scanContainerIn);
                }
            }

            //提交端口
            if (port == ConnectManager.port_L7L8)
            {
                //提交
                //OK1,cOut,cIn,SN,
                //OK2,cOut,cIn,SN,
                //NG1,...
                //NG2
                //OK1FINISH
                if (subs.Length >= 4 && (operationID.Contains("OK") || operationID.Contains("NG")))//要改
                {
                    Glass glass = new Glass();
                    glass.sourceVehicle = subs[1];
                    glass.targetVehicle = subs[2];
                    glass.snNumber = subs[3];

                    if (operationID == submit_OK_Left)
                        GlobalValue.GlassList_OK_Left.Add(glass);
                    if (operationID == submit_OK_Right)
                        GlobalValue.GlassList_OK_Right.Add(glass);
                    if (operationID == submit_NG_Left)
                        GlobalValue.GlassList_NG_Left.Add(glass);
                    if (operationID == submit_NG_Right)
                        GlobalValue.GlassList_NG_Right.Add(glass);

                    dataToMachine.code = ReturnData.code_success;
                    LogUtil.WriteLog("玻璃 " + glass.snNumber + " 放入载具 " + glass.targetVehicle + " 中。"); ;
                }
                if(operationID.ToUpper().Contains("FINISH"))
                {
                    //批量提交
                    if (operationID.ToUpper() == submit_OK_Left_Finish)
                        dataToMachine = SubmitToMES(ref GlobalValue.GlassList_OK_Left);
                    if (operationID.ToUpper() == submit_OK_Right_Finish)
                        dataToMachine = SubmitToMES(ref GlobalValue.GlassList_OK_Right);
                    if (operationID.ToUpper() == submit_NG_Left_Finish)
                        dataToMachine = SubmitToMES(ref GlobalValue.GlassList_NG_Left);
                    if (operationID.ToUpper() == submit_NG_Right_Finish)
                        dataToMachine = SubmitToMES(ref GlobalValue.GlassList_NG_Right);

                    dataToMachine.code = ReturnData.code_success;
                    LogUtil.WriteLog(operationID + "批量提交成功。");
                }


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
