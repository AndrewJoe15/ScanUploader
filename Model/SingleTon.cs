using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemicalScan.Model
{
    /// <summary>
    /// 单例类，用来方便地让一个类实现单例模式
    /// </summary>
    public class SingleTon<T> where T : class, new()
    {
        //私有静态实例
        private static T instance;
        //构造函数私有化，外部无法创建该类的对象
        //此处用(protected)，子类可以调用构造函数
        protected SingleTon() { }
        //对外提供一个静态方法获取该类的实例
        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new T();
                }
                return instance;
            }
        }
    }
}
