using System.Runtime.Serialization;

namespace ScanUploader.Model
{
    /// <summary>
    /// 玻璃类
    /// </summary>
    public class Glass
    {
        //扫出载具码
#if !CUMOSCAN //粗磨不需要sourceVehicle
        [DataMember]
#endif
        public string sourceVehicle { get; set; }
        //扫入载具码
        [DataMember]
        public string targetVehicle { get; set; }
        //玻璃码
        [DataMember]
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
