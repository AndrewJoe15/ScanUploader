using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemicalScan.Model
{
    /// <summary>
    /// 玻璃类
    /// </summary>
    internal class Glass
    {
        //扫出载具码
        public string sourceVehicle { get; set; }
        //扫入载具码
        public string targetVehicle { get; set; }
        //玻璃码
        public string snNumber { get; set; }
    }
}
