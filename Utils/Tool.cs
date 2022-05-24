using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemicalScan.Utils
{
    /// <summary>
    /// 使用工具类
    /// 一些方便编程的函数工具
    /// </summary>
    internal static class Tool
    {
        /// <summary>
        /// 批量给一个类某一类型的成员变量赋值
        /// </summary>
        /// <param name="obj">类对象</param>
        /// <param name="type">变量类型</param>
        /// <param name="val">值</param>
        public static void AssignMemberProperties(Object obj, Type type, Object val)
        {

            foreach (var property in obj.GetType().GetProperties())
            {
                if (property.PropertyType == type)
                {
                    property.SetValue(obj, val, null);
                }
            }
        }
    }
}
