using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemicalScan.Utils
{
    internal class ConnectException : Exception
    {
        public int status = 500;
        public string message;
        public ConnectException(string message)
        {
            this.message = message;
        }
    }
}
