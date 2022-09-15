using System;
using System.Collections.Generic;
using System.Diagnostics;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ScanUploader.Model;
using ScanUploader.Utils;
using ScanUploader.View;
using System.Text;

namespace ScanUploader.Controller
{
    /// <summary>
    /// 数据处理类
    /// </summary>
    public class Communicator
    {
        //PLC发来字符串数据分割符号
        private const char splitChar = ',';

        private const string scan_noRead = "NOREAD";

        private const string submit_finish_ID = "FINISH";//插满提交后缀

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
        private const string SN_ID_1             = "L3";
        private const string SN_ID_2            = "L4";
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
        private const string submit_OK_Left_Finish  = "OK2" + submit_finish_ID;
        private const string submit_OK_Right_Finish = "OK1" + submit_finish_ID; 
        private const string submit_NG_Left_Finish  = "NG2" + submit_finish_ID; 
        private const string submit_NG_Right_Finish = "NG1" + submit_finish_ID;

#elif BDSSCAN
        //主体
        //-玻璃
        private const string SN_ID_1 = "L1";
        private const string SN_ID_2 = "L2";
#endif


        /// <summary>
        /// Communicator <-> MES 
        /// 解析Machine发来的数据，发送给MES，并整理MES传回的数据
        /// 分端口号处理
        /// </summary>
        /// <param name="str">Machine 发来的字符串</param>
        public static ReturnData GetDataFromMES(string str, int port)
        {
            ReturnData dataToMachine = new ReturnData();

            //设备编号,设备码  L1,220421XSH01,
            string[] subs = str.Split(splitChar);

            if (subs.Length < 2)
                return dataToMachine;

            string operationID = subs[0].ToUpper();
            string deviceCode = subs[1].ToUpper();


            //条件编译
#if CHEMICALSCAN
            //化抛
            ChemicalScanHandler(port, subs, operationID, deviceCode, ref dataToMachine);
#elif BDSSCAN
            BDSScanHandler(port, operationID, deviceCode, ref dataToMachine);
#endif
            return dataToMachine;
        }
        

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
                    dataToMachine = GetReturnFromMES("containerCode", deviceCode, URL.Instance.scanContainerOut);

                    string verifyResult;
                    if (dataToMachine.code == ReturnData.code_success)
                    {
                        verifyResult = "校验通过, 绑定玻璃数：" + dataToMachine.data + "，";
                    }
                    else
                        verifyResult = "校验不通过，";

                    //写入日志
                    if (operationID == containerOut_ID_Left)
                        LogUtil.WriteLog("【化抛架扫码】左通道，" + verifyResult + dataToMachine.msg);
                    else
                        LogUtil.WriteLog("【化抛架扫码】右通道，" + verifyResult + dataToMachine.msg);

                    return;
                }
                //解绑
                if (operationID == unbind_ID_Left || operationID == unbind_ID_Right)
                {
                    //请求解绑
                    dataToMachine = GetReturnFromMES("containerCode", deviceCode, URL.Instance.scanContainerUnbind);

                    //记录解绑状态
                    if (operationID == unbind_ID_Left)
                        LogUtil.WriteLog("【化抛架解绑】左通道，" + dataToMachine.msg);
                    else
                        LogUtil.WriteLog("【化抛架解绑】右通道，" + dataToMachine.msg);


                    //拿空了一个化抛架，新建一个日志文件
                    LogFile.logFile = new LogFile();

                    return;
                }
            }

            //主体单片扫码端口
            else if (port == ConnectManager.port_main)
            {
                //玻璃
                CheckSnNumber(operationID, deviceCode, ref dataToMachine);
            }

            //下料端口
            else if (port == ConnectManager.port_down)
            {
                //载具 扫入
                if (operationID == containerIn_OK_ID || operationID == containerIn_NG_ID)
                {
                    dataToMachine = GetReturnFromMES("containerCode", deviceCode, URL.Instance.scanContainerIn);

                    if (operationID == containerIn_OK_ID)
                        LogUtil.WriteLog("【清洗架扫码】OK载具，" + dataToMachine.msg);
                    else
                        LogUtil.WriteLog("【清洗架扫码】NG载具，" + dataToMachine.msg);

                    return;
                }
            }

            //插架端口
            else if (port == ConnectManager.port_insert)
            {
                if (subs.Length >= 4)
                {
                    Glass glass = new Glass();
                    glass.sourceVehicle = subs[1];
                    glass.targetVehicle = subs[2];
                    glass.snNumber = subs[3];

                    bool inserted = false;

                    //插架
                    //OK1,cOut,cIn,SN,
                    //NG1,...

                    if (operationID == submit_OK_Left)
                    {
                        inserted = InsertGlass(glass, true, true, ref GlobalValue.GlassList_OK_Left);
                    }
                    else if (operationID == submit_OK_Right)
                    {
                        inserted = InsertGlass(glass, false, true, ref GlobalValue.GlassList_OK_Right);
                    }
                    else if (operationID == submit_NG_Left)
                    {
                        inserted = InsertGlass(glass, true, false, ref GlobalValue.GlassList_NG_Left);
                    }
                    else if (operationID == submit_NG_Right)
                    {
                        inserted = InsertGlass(glass, false, false, ref GlobalValue.GlassList_NG_Right);
                    }
                    else
                    {
                        dataToMachine.code = ReturnData.code_wrongData_PLC; 
                        dataToMachine.msg = "机器->上位机命令有误。";
                        return;
                    }

                    if(inserted)
                        dataToMachine.code = ReturnData.code_success;
                    else
                        dataToMachine.code = ReturnData.code_error;
                }
                return;
            }

            //提交端口
            else if (port == ConnectManager.port_submit)
            {
                //提交
                //OK1FINISH,
                //OK2FINISH,
                if (operationID.ToUpper().Contains(submit_finish_ID))
                {
                    //批量提交
                    //- OK
                    if (operationID.ToUpper() == submit_OK_Left_Finish)
                    {
                        dataToMachine = SubmitToMES(ref GlobalValue.GlassList_OK_Left, LogFile.logFile.logNumber);
                    }
                    if (operationID.ToUpper() == submit_OK_Right_Finish)
                    {
                        dataToMachine = SubmitToMES(ref GlobalValue.GlassList_OK_Right, LogFile.logFile.logNumber);
                    }
                    //- NG  预留提交功能
                    if (operationID.ToUpper() == submit_NG_Left_Finish)
                    {
                        dataToMachine = SubmitToMES(ref GlobalValue.GlassList_NG_Left, LogFile.logFile.logNumber);
                    }
                    if (operationID.ToUpper() == submit_NG_Right_Finish)
                    {
                        dataToMachine = SubmitToMES(ref GlobalValue.GlassList_NG_Right, LogFile.logFile.logNumber);
                    }

                    return;
                }
            }
        }

#endif


        private static bool InsertGlass(Glass glass, bool isLeft, bool isOK, ref List<Glass> glasses)
        {
            string glassResult = isOK ? "OK" : "NG";

            //如果没有读到码，插架不判重
            if (glass.snNumber.ToUpper() == scan_noRead)
            {
                //换成中文
                glass.snNumber = "未读到码";

                AddGlass(glass, isLeft, isOK, ref glasses, glassResult);
                return true;
            }
            //读到码了，插架要判重
            else
            {
                if (!glasses.Contains(glass))
                {
                    AddGlass(glass, isLeft, isOK, ref glasses, glassResult);
                    return true;
                }
                else
                {
                    LogUtil.WriteLog("【单片插架】" + glassResult + "，玻璃 " + glass.snNumber + " 已存在。\r\n");
                    return false;
                }
            }
        }

        private static void AddGlass(Glass glass, bool isLeft, bool isOK, ref List<Glass> glasses, string glassResult)
        {
            //玻璃数据列表
            glasses.Add(glass);

            //-界面列表
            AppendMaterialListView(glass, isOK);
            //-良率统计
            UpdateMaterialStatistics(isLeft, isOK);

#if CHEMICALSCAN
            LogUtil.WriteLog("【单片插架】" + glassResult + "，玻璃 " + glass.snNumber + " 放入清洗架 " + glass.targetVehicle + " 中。");
#endif
        }

#if BDSSCAN
        private static void BDSScanHandler(int port, string operationID, string deviceCode, ref ReturnData dataToMachine)
        {
            //丝印前BDS
            //涂油扫码端口
            if (port == ConnectManager.port_main)
            {
                CheckSnNumber(operationID, deviceCode, ref dataToMachine);
            }

            return;
        }

#endif


        private static void CheckSnNumber(string operationID, string deviceCode, ref ReturnData dataToMachine)
        {
            string snCode = deviceCode;
            //如果没有扫到码
            if (deviceCode.ToUpper() == scan_noRead)
            {
                dataToMachine.code = ReturnData.code_error;
                dataToMachine.msg = "读码失败。";
                snCode = "未读到码";
            }
            else
            {
                //上传玻璃码
                dataToMachine = GetReturnFromMES("snNumber", deviceCode, URL.Instance.scanSn);
            }

            string snResult;
            if (dataToMachine.code == ReturnData.code_success || dataToMachine.code == ReturnData.code_repeat)
            {
                snResult = "OK";
            }
            else
            {
                snResult = "NG";
            }

            if (operationID == SN_ID_1)
                LogUtil.WriteLog("【单片扫码】左通道，" + snCode + "，" + snResult + "，" + dataToMachine.msg);
            else if (operationID == SN_ID_2)
                LogUtil.WriteLog("【单片扫码】右通道，" + snCode + "，" + snResult + "，" + dataToMachine.msg);
            else
            {
                dataToMachine.code = ReturnData.code_wrongData_PLC;
                dataToMachine.msg = "设备发给上位机命令有误。";
                LogUtil.WriteLog("【单片扫码】失败，" + dataToMachine.msg);
                return;
            }
            //更新 OK NG 列表
            AppendMaterialListView(snCode, dataToMachine);
#if BDSSCAN
            //BDS项目在此进行良率统计
            UpdateMaterialStatistics(operationID, dataToMachine);
#endif

            return;
        }

        /// <summary>
        /// 向MES发送数据，并接收回传数据
        /// </summary>
        /// <param name="deviceCodeKey">数据字段名</param>
        /// <param name="deviceCodeValue">数据，如玻璃码，架子码</param>
        /// <param name="url">http链接</param>
        /// <returns></returns>
        public static ReturnData GetReturnFromMES(string deviceCodeKey, string deviceCodeValue, string url)
        {
            ReturnData rdata = new ReturnData();
            JObject dataFromMes = null;

            //添加<码,值> 生成json数据
            string dataToMES = JsonUtil.ToJson(BasicInfo.Instance, deviceCodeKey, deviceCodeValue);

            if (dataToMES != null && dataToMES.Trim() != "")
            {
                dataFromMes = HttpUtil.PostResponse(url, dataToMES);
            }

            if (dataFromMes != null)
            {
                
                //确保发回来的body有内容才赋值
                if (dataFromMes["code"] != null)
                {
                    rdata.code = dataFromMes["code"].ToString();
                    rdata.msg = dataFromMes["msg"].ToString();

                    if (rdata.code == ReturnData.code_success)
                    {
                        if (dataFromMes["data"] != null && (bool)dataFromMes["data"]?["isBand"] == true)
                        {
                            //化抛架扫码，返回化抛架绑定的玻璃数量
                            rdata.data = dataFromMes["data"]?["bandQty"].ToString();
                        }
                        else
                        {
                            rdata.data = string.Empty;
                        }
                    }
                    
                }
                else
                {
                    rdata.code = ReturnData.code_wrongData_MES;
                    rdata.msg = "MES连接异常，返回数据为空。" + dataFromMes.ToString();
                }
            }
            else
            {
                rdata.code = ReturnData.code_wrongData_MES;
                rdata.msg = "MES返回数据为空。";
            }
#if DEBUGx
            //随机成功失败
            Random random = new Random();
            if (random.Next(0, 99) < 80)
            {
                rdata.code = ReturnData.code_success;
                rdata.msg = deviceCodeValue + " OK";
            }
            else
            {
                rdata.code = ReturnData.code_error;
                rdata.msg = deviceCodeValue + " NG";
            }
            rdata.data = rdata.code;
#endif
            return rdata;
        }
        
        /// <summary>
        /// 清洗架提交 接收MES的返回数据
        /// </summary>
        /// <param name="submitData">提交的json数据</param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static ReturnData GetReturnMES(String submitData, string url)
        {
            ReturnData rdata = new ReturnData();

#if !DEBUGx
            JObject dataFromMes = HttpUtil.PostResponse(url, submitData);

            if (dataFromMes["code"] != null)
            {
                //确保发回来的body有内容才赋值
                rdata.code = dataFromMes["code"].ToString();
                rdata.msg = dataFromMes["msg"].ToString();
                if (dataFromMes["data"] != null)
                    rdata.data = dataFromMes["data"].ToString();
                else
                    rdata.data = rdata.code;

            }
            else
            {
                rdata.code = ReturnData.code_wrongData_MES;
                rdata.msg = "MES返回数据为空，请检查与MES的网络连接。";
            }
#else
            rdata = new ReturnData();
            rdata.code = ReturnData.code_success;
            rdata.data = rdata.code;
            rdata.msg = "数据提交";
#endif

            return rdata;
        }


#if !BDSSCAN
        /// <summary>
        /// 提交数据，清空list
        /// </summary>
        /// <param name="glasses"></param>
        /// <returns></returns>
        private static ReturnData SubmitToMES(ref List<Glass> glasses, string logNumber)
        {
            ReturnData dataToMachine = new ReturnData();
            SubmitData submitData = new SubmitData();
            JObject submitJson = new JObject();


            if (glasses.Count > 0)
            {
                submitData.logNumber = logNumber;
                submitData.qty = glasses.Count.ToString();//qty 载具内玻璃数量
                submitData.supplementList = glasses;

                //拼接Json数据
                submitJson = JsonUtil.ToJObject(BasicInfo.Instance);
                JObject tmp = JsonUtil.ToJObject(submitData);
                submitJson.Merge(tmp);

                dataToMachine = GetReturnMES(submitJson.ToString(), ((URL)URL.Instance).scanSubmit);
            }
            else
            {
                dataToMachine.code = ReturnData.code_wrongData_PLC;
                dataToMachine.msg = "提交列表中没有玻璃数据。";
            }


            //Log记录
            if (dataToMachine?.code == ReturnData.code_success)
            {
                string logStr = "【下料载具提交】成功，" + dataToMachine?.msg + "，共" + submitData.qty + "片。\r\n";

                foreach (var item in submitData.supplementList)
                {
                    logStr += "\t\t玻璃码：" + item.snNumber + " 上料载具码：" + item.sourceVehicle + " 下料载具码：" + item.targetVehicle + "\r\n";
#endif
                }
                LogUtil.WriteLog(logStr);
            }
            else
                LogUtil.WriteLog("【提交失败】，" + dataToMachine?.msg);


            glasses.Clear();//最后清空list

            return dataToMachine;
        }
#endif

                    /// <summary>
                    /// BDS项目 良率统计 在单片扫码时调用
                    /// </summary>
                    /// <param name="operationID"></param>
                    /// <param name="dataToMachine"></param>
                    private static void UpdateMaterialStatistics(string operationID, ReturnData dataToMachine)
        {
            //良率统计
            if (operationID == SN_ID_1)
            {
                if (dataToMachine.code == ReturnData.code_success || dataToMachine.code == ReturnData.code_repeat)
                    Statistics.OK_1++;
                else
                    Statistics.NG_1++;

                //-更新界面良率
                MainForm.thisForm.UpdateStatistics(1);
            }
            else if (operationID == SN_ID_2)
            {
                if (dataToMachine.code == ReturnData.code_success || dataToMachine.code == ReturnData.code_repeat)
                    Statistics.OK_2++;
                else
                    Statistics.NG_2++;

                //-更新界面良率
                MainForm.thisForm.UpdateStatistics(2);
            }
        }

        /// <summary>
        /// 化抛项目 物料良率统计 插架的时候调用
        /// </summary>
        /// <param name="isLeft">左通道</param>
        /// <param name="isOK">OK</param>
        private static void UpdateMaterialStatistics(bool isLeft, bool isOK)
        {
            //良率统计
            if (isLeft)
            {
                if (isOK)
                    Statistics.OK_1++;
                else
                    Statistics.NG_1++;

                //-更新界面良率
                MainForm.thisForm.UpdateStatistics(1);
            }
            else
            {
                if (isOK)
                    Statistics.OK_2++;
                else
                    Statistics.NG_2++;

                //-更新界面良率
                MainForm.thisForm.UpdateStatistics(2);
            }
        }

        /// <summary>
        /// 扫码校验信息表
        /// 玻璃OK NG信息显示到窗体表格中
        /// </summary>
        /// <param name="deviceCode"></param>
        /// <param name="dataToMachine"></param>
        private static void AppendMaterialListView(string deviceCode, ReturnData dataToMachine)
        {
            //OK信息表
            if (dataToMachine.code == ReturnData.code_success || dataToMachine.code == ReturnData.code_repeat)
                MainForm.thisForm.AddGlassScanInfo(deviceCode, dataToMachine.code, dataToMachine.msg, true);
            //NG信息表
            else
                MainForm.thisForm.AddGlassScanInfo(deviceCode, dataToMachine.code, dataToMachine.msg, false);
        }

        /// <summary>
        /// 插架信息表
        /// </summary>
        /// <param name="glass"></param>
        /// <param name="isOK"></param>
        private static void AppendMaterialListView(Glass glass, bool isOK)
        {
            if (glass == null)
                return;

            if (isOK)
                MainForm.thisForm.AddGlassInfo(glass, true);
            else
                MainForm.thisForm.AddGlassInfo(glass, false);            
        }


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

            string dataToMES = JsonUtil.ToJson(BasicInfo.Instance, deviceCodeKey, deviceCodeValue);



            JObject dataFromMes = HttpUtil.PostResponse(url, dataToMES);
            if (dataFromMes["code"] != null)
            {
                code = dataFromMes["code"].ToString();
            }

            return code;
        }


        /// <summary>
        /// 从MES端获取数据，整理成字符串准备发给Machine
        /// </summary>
        /// <param name="dataToMachine">准备发给Machine的字符串</param>
        /// <param name="deviceCodeKey">MES返回Json中码的键</param>
        /// <param name="deviceCodeValue">Json中码的值</param>
        /// <param name="url">链接</param>
        private static void GetData(ref string dataToMachine, string deviceCodeKey, string deviceCodeValue, string url)
        {
            string dataToMES = JsonUtil.ToJson(BasicInfo.Instance, deviceCodeKey, deviceCodeValue);


            JObject dataFromMes = HttpUtil.PostResponse(url, dataToMES);


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
