using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanUploader.Model
{
    internal class HttpUser : DataBase
    {
        public string username
        {
            get { return _username; }
            set { _username = value; SendChangedInfo(nameof(username)); }
        }
        public string password
        {
            get { return _password; }
            set { _password = value; SendChangedInfo(nameof(password)); }
        }

        public string site
        {
            get { return _site; }
            set { _site = value; SendChangedInfo(nameof(site)); }
        }

        public HttpUser(string name, string password, string site)
        {
            this.username = name;
            this.password = password;
            this.site = site;
        }

        private string _username;
        private string _password;
        private string _site;
    }
}
