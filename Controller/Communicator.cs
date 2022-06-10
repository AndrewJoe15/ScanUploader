﻿using System;
using System.Collections.Generic;
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

        private const string submit_Finish_ID = "FINISH";//插满提交后缀

        //*****PLC发过来字符串的标识符
#if CHEMICALSCAN
        //上料
        //-扫出
        private const string containerOut_ID_Left   = "L1";
        private const string containerOut_ID_Right  = "L2";
        //-解绑
        private const string unbind_ID_Left         = "L11";
        private const string unbind_ID_Right        = "L12";
        //主体
        //-玻璃
        private const string SN_ID_Left             = "L3";
        private const string SN_ID_Right            = "L4";
        //下料
        //-扫入
        private const string containerIn_OK_ID      = "L5";
        private const string containerIn_NG_ID      = "L6";
        //-放入玻璃
        private const string submit_OK_Left         = "OK2";
        private const string submit_OK_Right        = "OK1"; 
        private const string submit_NG_Left         = "NG2"; 
        private const string submit_NG_Right        = "NG1"; 
        //-提交
        private const string submit_OK_Left_Finish  = "OK2" + submit_Finish_ID;
        private const string submit_OK_Right_Finish = "OK1" + submit_Finish_ID; 
        private const string submit_NG_Left_Finish  = "NG2" + submit_Finish_ID; 
        private const string submit_NG_Right_Finish = "NG1" + submit_Finish_ID; 

#elif KIBBLESCAN
        //上料
        //-扫出载具
        private const string containerOut_ID_1 = "L1";
        private const string containerOut_ID_2 = "L2";
        private const string containerOut_ID_3 = "L3";
        private const string containerOut_ID_4 = "L4";
        //-解绑载具
        private const string unbind_ID_1 = "L11";
        private const string unbind_ID_2 = "L12";
        private const string unbind_ID_3 = "L13";
        private const string unbind_ID_4 = "L14";
        //主体
        //-玻璃
        private const string SN_ID_1 = "L5";
        private const string SN_ID_2 = "L6";
        //下料
        //-扫入载具
        private const string containerIn_NG_ID = "L7";
        private const string containerIn_OK_ID = "L8";
        //-放入玻璃
        private const string submit_OK = "OK";
        private const string submit_NG = "NG";
        //-提交
        private const string submit_OK_Finish = "OK" + submit_Finish_ID;
        private const string submit_NG_Finish = "NG" + submit_Finish_ID;

#elif BDSSCAN
        //主体
        //-玻璃
        private const string SN_ID_1 = "L1";
        private const string SN_ID_2 = "L2";
#endif

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
#if BDSSCAN
            BasicInfo.Instance.submitTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
#else
            BasicInfo.Instance.createTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
#endif
            string dataToMES = JsonUtil.ToJson(BasicInfo.Instance, deviceCodeKey, deviceCodeValue);


            Debug.WriteLine(dataToMES);
            LogUtil.WriteLog("发给MES端口的消息: \n" + dataToMES);

            JObject dataFromMes = HttpUtil.PostResponse(url, dataToMES);
            if (dataFromMes["code"] != null)
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
#if BDSSCAN
            BasicInfo.Instance.submitTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
#else
            BasicInfo.Instance.createTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
#endif
            //添加<码,值> 生成json数据
            string dataToMES = JsonUtil.ToJson(BasicInfo.Instance, deviceCodeKey, deviceCodeValue);

            if (dataToMES != null && dataToMES.Trim() != "")
            {
                Debug.WriteLine(dataToMES);
                LogUtil.WriteLog("发给MES端口的消息: \n" + dataToMES);

                dataFromMes = HttpUtil.PostResponse(url, dataToMES);
            }

            if (dataFromMes != null)
            {
                //确保发回来的body有内容才赋值
                if (dataFromMes["code"] != null)
                {
                    rdata = new ReturnData();
                    rdata.code = dataFromMes["code"].ToString();
                    rdata.msg = dataFromMes["msg"].ToString();
                    if (dataFromMes["data"] != null)
                    {
                        //化抛架扫码，返回化抛架绑定的玻璃数量
                        if(dataFromMes["data"]["bandQty"] != null)
                            rdata.data = dataFromMes["data"]["bandQty"].ToString();
                    }
                    LogUtil.WriteLog("收到MES端口的消息: \n" + dataFromMes.ToString());
                }
            }
            return rdata;
        }

        /// <summary>
        /// 向WMS查询、验证
        /// </summary>
        public static ReturnData GetReturnFromWMS(string deviceCodeValue)
        {
            ReturnData rdata = new ReturnData();
            JObject dataFromWMS = null;
            
            //载具码
            Query_WMS.Instance.holderNo = deviceCodeValue;
            BasicInfo_WMS.Instance.upperMaterialLoadNumber = deviceCodeValue;

            string dataToWMS = JsonConvert.SerializeObject(Query_WMS.Instance);
            
            if (dataToWMS != "{}")//空 Json
            {
                Debug.WriteLine(dataToWMS);
                LogUtil.WriteLog("给WMS端口发送查询请求: \n" + dataToWMS);
                //向WMS查询
                JObject jsonRetrun = HttpUtil.PostResponse_WMS(Properties.URL.Default.stockQuery_WMS, dataToWMS);
                if(jsonRetrun["code"] != null)
                {
                    LogUtil.WriteLog("收到WMS端口的消息: \n" + jsonRetrun.ToString());

                    if (jsonRetrun["code"].ToString() == ReturnData.code_success)//查询成功
                        //获取可用数量
                        BasicInfo_WMS.Instance.upperMaterialQty = jsonRetrun["usable_qty"].ToString();
                    else if(jsonRetrun["code"].ToString() == ReturnData.code_error)//查询失败
                    {
                        //查询失败，保存信息 返回
                        rdata.code = ReturnData.code_error;
                        if (jsonRetrun["code"] != null)
                            rdata.msg = jsonRetrun["msg"].ToString();
                        return rdata;
                    }
                }
                
            }

            //发给WMS检验的字符串以[]包裹
            //[
            dataToWMS = "[";
            //生成json数据
            dataToWMS += JsonConvert.SerializeObject(BasicInfo_WMS.Instance);
            //]
            dataToWMS += "]";

            if (dataToWMS != "[{}]" && dataToWMS != "[{{}}]")
            {
                Debug.WriteLine(dataToWMS);
                LogUtil.WriteLog("向WMS端口发送校验请求: \n" + dataToWMS);

                dataFromWMS = HttpUtil.PostResponse_WMS(Properties.URL.Default.validate_WMS, dataToWMS);
            }

            if (dataFromWMS != null)
            {
                //确保发回来的body有内容才赋值
                if (dataFromWMS["omasgType"] != null)
                {                    
                    if (dataFromWMS["omasgType"].ToString() == "1")//校验通过
                        rdata.code = ReturnData.code_success;
                    else if(dataFromWMS["omasgType"].ToString() == "0")//校验失败
                        rdata.code = ReturnData.code_error;
                    
                    if(dataFromWMS["omasg"] != null)
                        rdata.msg = dataFromWMS["omasg"].ToString();

                    LogUtil.WriteLog("收到WMS端口的消息: \n" + dataFromWMS.ToString());
                }
            }
            return rdata;
        }

        public static ReturnData SubmitToMES(String submitData, string url)
        {
            ReturnData rdata = null;

            Debug.WriteLine(submitData);
            LogUtil.WriteLog("数据提交，发给MES端口的消息: \n" + submitData);

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

#if !BDSSCAN
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

            glasses.Clear();//最后清空list

            return dataToMachine;
        }
#endif

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
            string operationID = subs[0].ToUpper();
            string deviceCode = subs[1].ToUpper();
            //string dataToMachine = deviceID;//字符串最开始为 "L1..." "L2..."
            ReturnData dataToMachine = new ReturnData();

            //条件编译
#if CHEMICALSCAN
            //化抛
            ChemicalScanHandler(port, subs, operationID, deviceCode, ref dataToMachine);
            
#elif KIBBLESCAN
            KibbleScanHandler(port, subs, operationID, deviceCode, ref dataToMachine);

#elif BDSSCAN
            BDSScanHandler(port, operationID, deviceCode, ref dataToMachine);
#endif
            return dataToMachine;
        }
#if BDSSCAN
        private static ReturnData BDSScanHandler(int port, string operationID, string deviceCode, ref ReturnData dataToMachine)
        {
            //丝印前BDS
            //涂油扫码端口
            if (port == ConnectManager.port_main)
            {
                //上传玻璃码
                if (operationID == SN_ID_1 || operationID == SN_ID_2)
                {
                    dataToMachine = GetReturnFromMES("snNumber", deviceCode, URL.scanSn);
                }
            }

            return dataToMachine;
        }
#endif

        //粗磨项目扫码上传业务逻辑
#if KIBBLESCAN

        private static ReturnData KibbleScanHandler(int port, string[] subs, string operationID, string deviceCode, ref ReturnData dataToMachine)
        {
            //粗磨
            //上料端口
            if (port == ConnectManager.port_up)
            {
                //扫出载具
                if (operationID == containerOut_ID_1 ||
                    operationID == containerOut_ID_2 ||
                    operationID == containerOut_ID_3 ||
                    operationID == containerOut_ID_4)
                {
                    dataToMachine = GetReturnFromWMS(deviceCode);
                }
            }

            //涂油扫码端口
            if (port == ConnectManager.port_main)
            {
                //上传玻璃码
                if (operationID == SN_ID_1 || operationID == SN_ID_2)
                {
                    dataToMachine = GetReturnFromMES("snNumber", deviceCode, URL.scanSn);
                    //良率统计
                    if (operationID == SN_ID_1)
                    {
                        if (dataToMachine.code == ReturnData.code_success)
                            Statistics.OK1++;
                        if (dataToMachine.code == ReturnData.code_error)
                            Statistics.NG1++;

                        //更新界面良率
                        MainForm.thisForm.UpdateStatistics(1);
                    }
                    if (operationID == SN_ID_2)
                    {
                        if (dataToMachine.code == ReturnData.code_success)
                            Statistics.OK2++;
                        if (dataToMachine.code == ReturnData.code_error)
                            Statistics.NG2++;

                        //更新界面良率
                        MainForm.thisForm.UpdateStatistics(2);
                    }
                }
            }

            //下料端口
            if (port == ConnectManager.port_down)
            {
                //载具 扫入
                if (operationID == containerIn_OK_ID || operationID == containerIn_NG_ID)
                {
                    dataToMachine = GetReturnFromMES("containerCode", deviceCode, URL.scanContainerIn);
                }
            }

            //提交端口
            if (port == ConnectManager.port_submit)
            {
                //提交
                //OK1,cOut,cIn,SN,
                //OK2,cOut,cIn,SN,
                //NG1,...
                //NG2
                if (subs.Length >= 4 && (operationID.Contains("OK") || operationID.Contains("NG")))//要改
                {
                    Glass glass = new Glass();
                    glass.sourceVehicle = subs[1];
                    glass.targetVehicle = subs[2];
                    glass.snNumber = subs[3];

                    if (operationID == submit_OK)
                        GlobalValue.GlassList_OK.Add(glass);
                    if (operationID == submit_NG)
                        GlobalValue.GlassList_NG.Add(glass);

                    dataToMachine.code = ReturnData.code_success;
                    LogUtil.WriteLog("玻璃 " + glass.snNumber + " 放入载具 " + glass.targetVehicle + " 中。"); ;
                }

                //OKFINISH
                //NGFINISH
                if (operationID.ToUpper().Contains(submit_Finish_ID))
                {
                    //批量提交
                    if (operationID.ToUpper() == submit_OK_Finish)
                        dataToMachine = SubmitToMES(ref GlobalValue.GlassList_OK);
                    if (operationID.ToUpper() == submit_NG_Finish)
                        dataToMachine = SubmitToMES(ref GlobalValue.GlassList_NG);

                    LogUtil.WriteLog(operationID + "已执行批量提交。");

                    //更新日志流水号
                    LogUtil.setNextSerialNumber();
                }
            }

            return dataToMachine;
        }
#endif
        //化抛项目扫码上传业务逻辑
#if CHEMICALSCAN
        /// <summary>
        /// 化抛项目扫码上传处理逻辑
        /// </summary>
        /// <param name="port">socket端口</param>
        /// <param name="subs">PLC发来数据</param>
        /// <param name="operationID">操作标识符</param>
        /// <param name="deviceCode">扫到的码</param>
        /// <param name="dataToMachine">返给PLC的数据</param>
        private static void ChemicalScanHandler(int port, string[] subs, string operationID, string deviceCode, ref ReturnData dataToMachine)
        {

            //上料端口
            if (port == ConnectManager.port_up)
            {
                //化抛架 扫出载具
                if (operationID == containerOut_ID_Left || operationID == containerOut_ID_Right)
                {
                    dataToMachine = GetReturnFromMES("containerCode", deviceCode, URL.scanContainerOut);
                    //将化抛架绑定的数量 赋给 code 发给PLC
                    if(dataToMachine != null)
                        dataToMachine.code = dataToMachine.data;
                }
                //解绑
                if (operationID == unbind_ID_Left || operationID == unbind_ID_Right)
                {
                    dataToMachine = GetReturnFromMES("containerCode", deviceCode, URL.scanContainerUnbind);
                }
            }

            //主体端口
            if (port == ConnectManager.port_main)
            {
                //玻璃
                if (operationID == SN_ID_Left || operationID == SN_ID_Right)
                {
                    dataToMachine = GetReturnFromMES("snNumber", deviceCode, URL.scanSn);
                    /*if (deviceCode == "NoRead")
                        dataToMachine.code = ReturnData.code_error;*/
                }
            }

            //下料端口
            if (port == ConnectManager.port_down)
            {
                //载具 扫入
                if (operationID == containerIn_OK_ID || operationID == containerIn_NG_ID)
                {
                    dataToMachine = GetReturnFromMES("containerCode", deviceCode, URL.scanContainerIn);
                }
            }

            //提交端口
            if (port == ConnectManager.port_submit)
            {
                //提交
                //OK1,cOut,cIn,SN,
                //OK2,cOut,cIn,SN,
                //NG1,...
                //NG2
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

                //OK1FINISH
                //NG1FINISH
                if (operationID.ToUpper().Contains(submit_Finish_ID))
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

                    //dataToMachine.code = ReturnData.code_success;
                    LogUtil.WriteLog(operationID + "已执行批量提交。");
                }
            }
        }
#endif





        /// <summary>
        /// 从MES端获取数据，整理成字符串准备发给Machine
        /// </summary>
        /// <param name="dataToMachine">准备发给Machine的字符串</param>
        /// <param name="deviceCodeKey">MES返回Json中码的键</param>
        /// <param name="deviceCodeValue">Json中码的值</param>
        /// <param name="url">链接</param>
        private static void GetData(ref string dataToMachine, string deviceCodeKey, string deviceCodeValue, string url)
        {
#if BDSSCAN
            BasicInfo.Instance.submitTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
#else
            BasicInfo.Instance.createTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
#endif
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
