using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanUploader.Model
{
    public class SubmitData
    {

        public string logNumber = "";
#if BDSSCAN
        public string order = "000600003375";
#else
        public string mo = "0010";
#endif
        public string qty = "";
        public List<Glass> supplementList = new List<Glass>();

    }
}
