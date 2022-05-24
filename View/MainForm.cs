using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using ChemicalScan.Model;

namespace ChemicalScan.View
{
    public partial class MainForm : Form
    {
        //BasicInfo单例
        private BasicInfo basicInfo = BasicInfo.Instance;
        //班次下拉列表项
        List<string> comboBox_shift_items = new List<string>();

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// 对控件进行初始化
        /// </summary>
        private void Init()
        {
            //遍历基本信息面板的子控件
            foreach (Control ctrl in panel_basicInformation.Controls)
            {
                //TextBox初始化
                if (ctrl is TextBox)
                {
                    foreach (System.Reflection.PropertyInfo p in basicInfo.GetType().GetProperties())
                    {
                        if (ctrl.Name.EndsWith(p.Name))
                        {
                            ctrl.Text = p.GetValue(basicInfo).ToString();
                        }
                    }
                }
            }

            //初始化班次下拉列表
            ///方式一，显示枚举的Name
            /*string[] shifts = typeof(SHIFT).GetEnumNames();//获取班次类型数组
            comboBox_shift.Items.AddRange(shifts);*/
            //方式二，显示枚举的Description
            GetComboBoxItems(typeof(SHIFT), comboBox_shift_items);
            comboBox_shift.Items.AddRange(comboBox_shift_items.ToArray());
            if (comboBox_shift.Items.Count > 0)
                comboBox_shift.SelectedIndex = (int)SHIFT.Day;
        }

        private void GetComboBoxItems(Type type, List<string> comboBox_shift_items)
        {
            FieldInfo[] fieldInfos = type.GetFields();//获取班次类型数组

            foreach (FieldInfo fieldInfo in fieldInfos)
            {
                if (fieldInfo.FieldType.IsEnum)
                {
                    //获得枚举的Description
                    DescriptionAttribute attribute = (DescriptionAttribute)fieldInfo.GetCustomAttribute(typeof(DescriptionAttribute), false);//获取班次类型数组
                    //每个枚举变量的Description都存入数组
                    comboBox_shift_items.Add(attribute.Description);
                }
            }
        }

        private void textBox_site_TextChanged(object sender, EventArgs e)
        {
            basicInfo.site = textBox_site.Text;
        }

        private void textBox_operation_TextChanged(object sender, EventArgs e)
        {
            basicInfo.operation = textBox_operation.Text;
        }

        private void textBox_resource_TextChanged(object sender, EventArgs e)
        {
            basicInfo.resource = textBox_resource.Text;
        }

        private void textBox_productModel_TextChanged(object sender, EventArgs e)
        {
            basicInfo.productModel = textBox_productModel.Text;
        }

        private void textBox_productModelVersion_TextChanged(object sender, EventArgs e)
        {
            basicInfo.productModelVersion = textBox_productModelVersion.Text;
        }

        private void comboBox_shift_SelectedIndexChanged(object sender, EventArgs e)
        {
            basicInfo.shift = ((SHIFT)comboBox_shift.SelectedIndex).ToString();
        }

        private void textBox_createBy_TextChanged(object sender, EventArgs e)
        {
            basicInfo.createBy = textBox_createBy.Text;
        }
    }
}
