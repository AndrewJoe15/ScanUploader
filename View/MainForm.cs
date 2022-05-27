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
using ChemicalScan.Utils;

namespace ChemicalScan.View
{
    public partial class MainForm : Form
    {

        public static MainForm thisForm;

        //BasicInfo单例
        private BasicInfo basicInfo = BasicInfo.Instance;

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        //线程安全调用
        private delegate void _ShowLog();
        public void ShowLog(string text)
        {
            _ShowLog _st = new _ShowLog(delegate ()
            {
                if (textBox_log.Text.Length > LogUtil.maxLength)
                    textBox_log.Clear();

                textBox_log.AppendText(text);
                textBox_log.AppendText(Environment.NewLine);
                textBox_log.ScrollToCaret();
            });
            Invoke(_st);
        }

        /// <summary>
        /// 对控件进行初始化
        /// </summary>
        private void Init()
        {
            thisForm = this;
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
            ///显示枚举的Name
            string[] shifts = typeof(SHIFT).GetEnumNames();//获取班次类型数组
            comboBox_shift.Items.AddRange(shifts);

            textBox_mo.Text = "";
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

        private void button_start_Click(object sender, EventArgs e)
        {
            bool done = true;
            foreach(Control ctrl in panel_basicInformation.Controls)
            {
                if (!(ctrl is Label) && ctrl.Text.Trim() == "")
                {
                    done = false;
                    //反射得到文本控件对应的标签
                    //分割TextBox控件变量名
                    string ctrlNamePostfix = ctrl.Name.Remove(0, ctrl.Name.IndexOf("_"));
                    string name = "label" + ctrlNamePostfix;
                    FieldInfo fieldInfo = (new Label()).GetType().GetField(name);
                    //ShowUtil.ShowTips("请输入" + fieldInfo.GetValue("Text") + "信息。");
                    ShowUtil.ShowTips("请将信息填写完整。");
                }                    
            }
            if (done)
            {
                ShowUtil.ShowTips("信息录入成功！");
            }
        }
    }
}
