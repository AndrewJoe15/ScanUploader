using System;
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
        private const string containerIn_ID_0   = "L1";
        private const string containerIn_ID_1   = "L2";
        private const string SN_ID_0            = "L3";
        private const string SN_ID_1            = "L4";
        private const string containerOut_ID_0  = "L5";
        private const string containerOut_ID_1  = "L6";

        /// <summary>
        /// Communicator <-> MES 
        /// 解析Machine发来的数据，发送给MES，并整理MES传回的数据
        /// </summary>
        /// <param name="str">Machine 发来的字符串</param>
        public static string GetDataFromMES(string str)
        {
            //设备编号,设备码  L1,220421XSH01 
            string[] data = str.Split(splitChar);
            string deviceID = data[0];
            string deviceCode = data[1];
            string dataToMachine = deviceID;//字符串最开始为 "L1..." "L2..."
            //化抛架
            if (deviceID == containerOut_ID_0 || deviceID == containerOut_ID_1)
            {
                GetData(ref dataToMachine, "containerCode", deviceCode, URL.scanContainerOut);
            }
            //玻璃
            if (deviceID == SN_ID_0 || deviceID == SN_ID_1)
            {
                GetData(ref dataToMachine, "snNumber", deviceCode, URL.scanSn);
            }
            //载具
            if (deviceID == containerIn_ID_0 || deviceID == containerIn_ID_1)
            {
                GetData(ref dataToMachine, "containerCode", deviceCode, URL.scanContainerIn);
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

            concatData(ref dataToMachine, deviceCodeKey, deviceCodeValue);
            concatData(ref dataToMachine, "code", dataFromMes["code"].ToString());
        }

        /// <summary>
        /// 在字符串后添加数据 L1,键:值,键:值
        /// </summary>
        private static void concatData(ref string str, string key, string value)
        {
            str += ("," + key + ":" + value);
        }
    }
}
