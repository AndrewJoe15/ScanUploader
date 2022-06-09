using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemicalScan.Model
{
    /// <summary>
    /// WMS查询时的数据
    /// </summary>
    public class Query_WMS : SingleTon<Query_WMS>
    {
        public string cargoNumber = "600003311";
        public string orgnizationId = "";
        public string holderNo = "ZJ000012";
        public string wareHouseCode = "";
    }
}
