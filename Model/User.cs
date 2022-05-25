using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemicalScan.Model
{
    internal class User
    {
        public static string httpUserName = "sbjk";
        public static string httpUserPassword = "sbjk2018";
        public static string httpUserSite = "2018";

        public string username { get; set; }
        public string password { get; set; }

        public string site { get; set; }

        public User(string name, string password, string site)
        {
            this.username = name;
            this.password = password;
            this.site = site;
        }
    }
}
