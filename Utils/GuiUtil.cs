using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace ScanUploader.Utils
{
    public class GuiUtil
    {
        /// <summary>
        /// 加载多个文本框分别对应的对象obj的属性值
        /// </summary>
        /// <param name="controls"></param>
        public static void loadTextBoxValue(ControlCollection controls, object obj)
        {
            //遍历子控件
            foreach (Control ctrl in controls)
            {
                //如果控件是TextBox
                if (ctrl is TextBox)
                {
                    //遍历对象对应类型的所有属性
                    foreach (PropertyInfo p in obj.GetType().GetProperties())
                    {
                        //根据变量名赋值
                        if (ctrl.Name.EndsWith(p.Name))
                        {
                            ctrl.Text = p.GetValue(obj).ToString();
                        }
                    }
                }
            }
        }
    }
}
