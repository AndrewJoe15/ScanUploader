using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScanUploader.Model;
using ScanUploader.Utils;

namespace ScanUploader.Controller
{
    /// <summary>
    /// 物料表管理类
    /// </summary>
    internal class MaterialListManager : SingleTon<MaterialListManager>
    {
        public void AppendItemToFile(ListView listView, String filePath, string fileName)
        {
            FileUtil.AppendLastItemToExcel(listView, filePath, fileName);
        }
    }
}
