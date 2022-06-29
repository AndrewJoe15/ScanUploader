﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanUploader.Model
{
    internal class User
    {
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
