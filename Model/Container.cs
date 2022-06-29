using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanUploader.Model
{
    /// <summary>
    /// 载具类
    /// </summary>
    class Container
    {
        //载具码
        public string containerCode { get; set; }
        //状态码
        public int statusCode { get; set; }
        //是否绑定
        public bool isBand { get; set; }
        //载具绑定单片SN数量
        public int bandQty { get; set; }
        //载具绑定单片SN最大数量
        public int maxQty { get; set; }
    }
}
