using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemicalScan.Model
{
    public class BasicInfo_WMS : SingleTon<BasicInfo_WMS>
    {
        public string cargoNumber = "600003311";
        //标准文本码 配置
        public string standardTextCode = "A0026";
        //工单号 界面人工配置
        public string workOrder = "0010";
        //上料数量 查询返回
        public string upperMaterialQty = "20";
        //上料仓码 界面人工配置
        public string upperMaterialCode = "A66W";
        public string upperMaterialData { get => DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); }
        //载具号 扫出
        public string upperMaterialLoadNumber = "ZJ000012";
        public string batchNumber = "";
        public string handleType = "1";
    }
}
