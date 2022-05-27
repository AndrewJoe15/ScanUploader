using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemicalScan.Utils
{
    internal class ConnectException : Exception
    {
        public string message;
        public ConnectException(string message)
        {
            this.message = message;
        }

        public static void ExceptionHandler(string msg)
        {
            throw new ConnectException(msg);
        }

        public static void ExceptionHandler(Exception e)
        {
            //throw new Exception(e.Message);
        }
    }
}
