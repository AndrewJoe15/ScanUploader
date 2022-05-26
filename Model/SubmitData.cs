using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemicalScan.Model
{
    internal class SubmitData
    {
        public BasicInfo basicInfo = BasicInfo.Instance;
        public string logNumber;
        public string mo;
        public string qty;
        public List<Glass> supplementList;
    }
}
