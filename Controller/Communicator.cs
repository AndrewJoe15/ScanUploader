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

#elif KIBBLESCAN
        //上料
        //-扫出载具
        private const string containerOut_ID_1 = "L1";
        private const string containerOut_ID_2 = "L2";
        private const string containerOut_ID_3 = "L3";
        private const string containerOut_ID_4 = "L4";
        //-解绑载具 用不到
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
        /// Communicator <-> MES 
        /// 解析Machine发来的数据，发送给MES，并整理MES传回的数据
        /// 分端口号处理
        /// </summary>
        /// <param name="str">Machine 发来的字符串</param>
        public static ReturnData GetDataFromMES(string str, int port)
        {
            ReturnData dataToMachine = new ReturnData();

            //设备编号,设备码  L1,220421XSH01 
            string[] subs = str.Split(splitChar);
            string operationID = subs[0].ToUpper();
            string deviceCode = subs[1].ToUpper();


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

                    //写入日志
                    if (operationID == containerOut_ID_Left)
                        LogUtil.WriteLog("【化抛架扫码】左通道，" + dataToMachine.msg);
                    else
                        LogUtil.WriteLog("【化抛架扫码】右通道，" + dataToMachine.msg);

                    return;
                }
                //解绑
                if (operationID == unbind_ID_Left || operationID == unbind_ID_Right)
                {
                    //请求解绑
                    dataToMachine = GetReturnFromMES("containerCode", deviceCode, URL.scanContainerUnbind);

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
                if (operationID == SN_ID_1 || operationID == SN_ID_2)
                {
                    //如果没有扫到码
                    if (deviceCode.ToUpper() == scan_noRead)
                    {
                        dataToMachine.code = ReturnData.code_error;
                        dataToMachine.msg = "化抛扫描,单片SN号 NoRead,读码失败";
                    }
                    else
                    {
                        dataToMachine = GetReturnFromMES("snNumber", deviceCode, URL.scanSn);
                    }

                    //写入日志
                    if (operationID == SN_ID_1)
                        LogUtil.WriteLog("【单片扫码】左通道，" + dataToMachine.msg);
                    else
                        LogUtil.WriteLog("【单片扫码】右通道，" + dataToMachine.msg);

                    return;
                }
            }

            //下料端口
            else if (port == ConnectManager.port_down)
            {
                //载具 扫入
                if (operationID == containerIn_OK_ID || operationID == containerIn_NG_ID)
                {
                    dataToMachine = GetReturnFromMES("containerCode", deviceCode, URL.scanContainerIn);

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
                    //插架
                    //OK1,cOut,cIn,SN,
                    //NG1,...

                    if (operationID == submit_OK_Left)
                    {
                        InsertGlass(glass, true, ref GlobalValue.GlassList_OK_Left);
                    }
                    else if (operationID == submit_OK_Right)
                    {
                        InsertGlass(glass, true, ref GlobalValue.GlassList_OK_Right);
                    }
                    else if (operationID == submit_NG_Left)
                    {
                        InsertGlass(glass, false, ref GlobalValue.GlassList_NG_Left);
                    }
                    else if (operationID == submit_NG_Right)
                    {
                        InsertGlass(glass, false, ref GlobalValue.GlassList_NG_Right);
                    }
                    else
                    {
                        dataToMachine.code = ReturnData.code_wrongData_PLC; 
                        dataToMachine.msg = "机器->上位机命令有误。";
                        return;
                    }

                    dataToMachine.code = ReturnData.code_success;
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
                        dataToMachine = SubmitToMES(ref GlobalValue.GlassList_OK_Right, LogFile.debugFile.logNumber);
                    }
                    //- NG  预留提交功能
                    if (operationID.ToUpper() == submit_NG_Left_Finish)
                    {
                        dataToMachine = SubmitToMES(ref GlobalValue.GlassList_NG_Left, LogFile.logFile.logNumber);
                    }
                    if (operationID.ToUpper() == submit_NG_Right_Finish)
                    {
                        dataToMachine = SubmitToMES(ref GlobalValue.GlassList_NG_Right, LogFile.debugFile.logNumber);
                    }

                    return;
                }
            }
        }

        private static void InsertGlass(Glass glass, bool isOK, ref List<Glass> glasses)
        {
            string position = isOK ? "OK" : "NG";

            if (!glasses.Contains(glass))
            {
                //玻璃数据列表
                glasses.Add(glass);
                
                //界面列表
                if(isOK)
                    AppendMaterialListView(glass, true);
                else
                    AppendMaterialListView(glass, false);

                LogUtil.WriteLog("【单片插架】" + position + "，玻璃 " + glass.snNumber + " 放入清洗架 " + glass.targetVehicle + " 中。");
            }
            else
            {
                LogUtil.WriteLog("【单片插架】" + position + "，玻璃 " + glass.snNumber + " 已存在。\r\n");
            }
        }
#endif

#if BDSSCAN
        private static void BDSScanHandler(int port, string operationID, string deviceCode, ref ReturnData dataToMachine)
        {
            //丝印前BDS
            //涂油扫码端口
            if (port == ConnectManager.port_main)
            {
                //如果没有扫到码
                if (deviceCode.ToUpper() == scan_noRead)
                {
                    dataToMachine.code = ReturnData.code_error;
                    dataToMachine.msg = "单片SN号 NoRead, 读码失败";
                }
                else
                {               
                    //上传玻璃码
                    dataToMachine = GetReturnFromMES("snNumber", deviceCode, URL.scanSn);
                }

                if (operationID == SN_ID_1)
                    LogUtil.WriteLog("【单片扫码】左通道，" + "返回码：" + dataToMachine.code + "，" + dataToMachine.msg);
                else if (operationID == SN_ID_2)
                    LogUtil.WriteLog("【单片扫码】右通道，" + "返回码：" + dataToMachine.code + "，" + dataToMachine.msg);
                else
                {
                    dataToMachine.code = ReturnData.code_wrongData_PLC;
                    dataToMachine.msg = "PLC发给上位机命令有误。";
                    LogUtil.WriteLog("【单片扫码】" + dataToMachine.msg);
                    return;
                }

                //更新OK NG列表
                AppendMaterialListView(deviceCode, dataToMachine);
                //更新良率统计
                UpdateMaterialStatistics(operationID, dataToMachine);
                
                return;
            }

            return;
        }
#endif

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
#if DEBUGx //厂外Debug时不进行Http通信
                
#else
                dataFromMes = HttpUtil.PostResponse(url, dataToMES);
#endif
            }

            if (dataFromMes != null)
            {
                
                //确保发回来的body有内容才赋值
                if (dataFromMes["code"] != null)
                {
                    rdata.code = dataFromMes["code"].ToString();
                    rdata.msg = dataFromMes["msg"].ToString();
                    //data默认值为code的值
                    rdata.data = rdata.code;
                    if (dataFromMes["data"] != null)
                    {
                        //化抛架扫码，返回化抛架绑定的玻璃数量
                        if(dataFromMes["data"]["bandQty"] != null)
                            rdata.data = dataFromMes["data"]["bandQty"].ToString();
                    }
                }
                else
                {
                    rdata.code = ReturnData.code_wrongData_MES;
                    rdata.msg = "MES连接异常。\r\n" + dataFromMes.ToString();
                }
            }
            else
            {
                rdata.code = ReturnData.code_wrongData_MES;
                rdata.msg = "MES返回数据为空。\r\n";
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

                glasses.Clear();//最后提交前清空list

                dataToMachine = GetReturnMES(submitJson.ToString(), URL.scanSubmit);
            }
            else
            {
                dataToMachine.code = ReturnData.code_wrongData_PLC;
                dataToMachine.msg = "提交列表中没有玻璃数据。";
            }


            //Log记录
            if (dataToMachine?.code == ReturnData.code_success)
                LogUtil.WriteLog("【清洗架提交】成功，" + dataToMachine?.msg + "共" + submitData.qty + "片：\r\n" + submitJson["supplementList"]);
            else
                LogUtil.WriteLog("【清洗架提交】失败，" + dataToMachine?.msg);

            return dataToMachine;
        }
#endif

        private static void UpdateMaterialStatistics(string operationID, ReturnData dataToMachine)
        {
            //良率统计
            if (operationID == SN_ID_1)
            {
                if (dataToMachine.code == ReturnData.code_success)
                    Statistics.OK_1++;
                else
                    Statistics.NG_1++;

                //-更新界面良率
                MainForm.thisForm.UpdateStatistics(1);
            }
            if (operationID == SN_ID_2)
            {
                if (dataToMachine.code == ReturnData.code_success)
                    Statistics.OK_2++;
                else
                    Statistics.NG_2++;

                //-更新界面良率
                MainForm.thisForm.UpdateStatistics(2);
            }
        }

        private static void AppendMaterialListView(string deviceCode, ReturnData dataToMachine)
        {
            //NG信息表
            if (dataToMachine.code != ReturnData.code_success)
                //- 若玻璃NG，信息显示到窗体表格中
                MainForm.thisForm.AddNGInfo(deviceCode, dataToMachine.msg);
        }

        private static void AppendMaterialListView(Glass glass, bool isOK)
        {
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
        /// 向WMS查询、验证
        /// </summary>
        public static ReturnData GetReturnFromWMS(string deviceCodeValue)
        {
            ReturnData rdata = new ReturnData();
            JObject dataFromWMS = new JObject();
#if !DEBUG
            //载具码
            Query_WMS.Instance.holderNo = deviceCodeValue;
            BasicInfo_WMS.Instance.upperMaterialLoadNumber = deviceCodeValue;

            string dataToWMS = JsonConvert.SerializeObject(Query_WMS.Instance);
            
            if (dataToWMS != "{}")//空 Json
            {
                UIInfoManager.AppendDebugInfo("给WMS端口发送查询请求: \n" + dataToWMS);
                //向WMS查询
                JObject jsonRetrun = HttpUtil.PostResponse_WMS(Properties.URL.Default.stockQuery_WMS, dataToWMS);
                if(jsonRetrun["code"] != null)
                {
                    UIInfoManager.AppendDebugInfo("收到WMS端口的消息: \n" + jsonRetrun.ToString());

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

            //生成json数据 发给WMS检验的字符串以[]包裹
            dataToWMS = "[" + JsonConvert.SerializeObject(BasicInfo_WMS.Instance) + "]";

            if (dataToWMS != "[{}]" && dataToWMS != "[{{}}]")
            {
                UIInfoManager.AppendDebugInfo("向WMS端口发送校验请求: \n" + dataToWMS);

                dataFromWMS = HttpUtil.PostResponse_WMS(Properties.URL.Default.validate_WMS, dataToWMS);
            }

            //确保发回来的body有内容才赋值
            if (dataFromWMS["omasgType"] != null)
            {                    
                if (dataFromWMS["omasgType"].ToString() == "1")//校验通过
                    rdata.code = ReturnData.code_success;
                else if(dataFromWMS["omasgType"].ToString() == "0")//校验失败
                    rdata.code = ReturnData.code_error;
                    
                if(dataFromWMS["omasg"] != null)
                    rdata.msg = dataFromWMS["omasg"].ToString();

                UIInfoManager.AppendDebugInfo("收到WMS端口的消息: \n" + dataFromWMS.ToString());
            }
#else
            rdata.code = deviceCodeValue;
            rdata.msg = "WMS DEBUG";
#endif
            return rdata;
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

        //粗磨项目扫码上传业务逻辑
#if KIBBLESCAN

        private static void KibbleScanHandler(int port, string[] subs, string operationID, string deviceCode, ref ReturnData dataToMachine)
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
                    //WMS 查询、校验
                    ReturnData dataFromWMS = GetReturnFromWMS(deviceCode);
                    //MES
                    ReturnData dataFromMES = GetReturnFromMES("containerCode", deviceCode, URL.scanContainerOut);
                    //WMS 和 MES 均通过才算成功
                    if (dataFromWMS.code == ReturnData.code_success && dataFromMES.code == ReturnData.code_success)
                        dataToMachine.code = ReturnData.code_success;
                    //否则校验失败 返回错误信息
                    else
                        dataToMachine.code = ReturnData.code_error;
                     
                    dataToMachine.msg = "WMS校验，" + dataFromWMS.msg + "；MES校验，" + dataFromMES.msg;

                    LogUtil.WriteLog("上料扫出载具" + deviceCode + "," + dataToMachine.msg);

                    return;
                }
            }

            //涂油扫码端口
            if (port == ConnectManager.port_main)
            {
                //上传玻璃码
                if (operationID == SN_ID_1 || operationID == SN_ID_2)
                {
                    dataToMachine = GetReturnFromMES("snNumber", deviceCode, URL.scanSn);

                    LogUtil.WriteLog("单片玻璃扫码，" + dataToMachine.msg);

                    //更新用户界面显示的数据
                    UpdateUIInfo(operationID, deviceCode, dataToMachine);
                    return;
                }
            }

            //下料端口
            if (port == ConnectManager.port_down)
            {
                //载具 扫入
                if (operationID == containerIn_OK_ID || operationID == containerIn_NG_ID)
                {
                    dataToMachine = GetReturnFromMES("containerCode", deviceCode, URL.scanContainerIn);

                    LogUtil.WriteLog("下料扫入载具，" + dataToMachine.msg);

                    return;
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
                    LogUtil.WriteLog("玻璃 " + glass.snNumber + " 放入载具 " + glass.targetVehicle + " 中。");

                    return;
                }

                //OKFINISH
                //NGFINISH
                if (operationID.ToUpper().Contains(submit_Finish_ID))
                {
                    //批量提交
                    if (operationID.ToUpper() == submit_OK_Finish)
                        dataToMachine = SubmitToMES(ref GlobalValue.GlassList_OK, LogFile.logFile_line1.logNumber);
                    
                    if (operationID.ToUpper() == submit_NG_Finish)
                        dataToMachine = SubmitToMES(ref GlobalValue.GlassList_NG, LogFile.logFile_line1.logNumber);

                    if (dataToMachine != null && dataToMachine.msg != "")
                    {
                        LogUtil.WriteLog("提交，" + dataToMachine.msg);
                        
                        //新建日志文件对象
                        LogFile.logFile_line1 = new LogFile();
                    }
                    

                    return;
                }
            }

            return;
        }
#endif
    }
}
