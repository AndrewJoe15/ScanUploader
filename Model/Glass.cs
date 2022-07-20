using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanUploader.Model
{
    /// <summary>
    /// 玻璃类
    /// </summary>
    public class Glass
    {
        //扫出载具码
        public string sourceVehicle { get; set; }
        //扫入载具码
        public string targetVehicle { get; set; }
        //玻璃码
        public string snNumber { get; set; }

        //重写Equals方法
        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            else
                return Equals(obj as Glass);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            //避免snNumber为null的情况
            return snNumber == null ? 0: snNumber.GetHashCode();
        }

        public bool Equals(Glass anotherGlass)
        {
            if (anotherGlass == null || anotherGlass.snNumber == null)//避免snNumber为null的情况
                return false;

            return snNumber.Equals(anotherGlass.snNumber);
        }
    }
}
