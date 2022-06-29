using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScanUploader.Utils
{
    class FileUtil
    {
        /// <summary>
        /// 导出ListView数据生成CSV文件
        /// </summary>
        /// <param name="fileName">文件名</param>
        /// <param name="listView">ListView 数据</param>
        static public void ExportExcel(string fileName, ListView listView)
        {
            //判断ListView 是否存在数据
            if (listView.Items.Count == 0)
            {
                MessageBox.Show("没有可导出的数据");
                return;
            }
            //创建SaveFileDialog 保存文件
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "csv(*.csv)|*.csv";
            fileDialog.DefaultExt = "csv";
            fileDialog.FilterIndex = 0;
            fileDialog.Title = "导出文件";
            fileDialog.InitialDirectory = Environment.CurrentDirectory;
            //文件名
            fileDialog.FileName = fileName + DateTime.Now.ToString("yyyyMMddHHmmss");

            try
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    int itemSize = 128;//一行数据项大小
                    int bufferSize = listView.Items.Count * itemSize;
                    StreamWriter sw = new StreamWriter(fileDialog.FileName, false, Encoding.Default, bufferSize);
                    //获取listView标题行
                    for (int t = 0; t < listView.Columns.Count; t++)
                    {
                        sw.Write(listView.Columns[t].Text + ",");
                    }
                    sw.WriteLine();
                    //获取listView数据行
                    for (int lin = 0; lin < listView.Items.Count; lin++)
                    {
                        string tmp = null;
                        for (int k = 0; k < listView.Columns.Count; k++)
                        {
                            string tmpStr = listView.Items[lin].SubItems[k].Text;
                            tmp += tmpStr;
                            tmp += ",";
                        }
                        sw.WriteLine(tmp);
                    }
                    sw.Flush();
                    sw.Close();
                    MessageBox.Show("成功导出CSV文件至：" + fileDialog.FileName.ToString().Trim());
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ExceptionHandler(ex);
            }
        }

    }
}
