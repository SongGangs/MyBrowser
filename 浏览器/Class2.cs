using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace 浏览器
{
    class Class2
    {
        public string title;
        public string urlstring;
        public DateTime time;

        public string username;
        public string password;

        public Class2(string title, string urlstring, string time1)
        {
            this.title = title;
            this.time = DateTime.Parse(time1);
            this.urlstring = urlstring;
        }

        public Class2(string name, string pword)
        {
            this.username = name;
            this.password = pword;
        }
    }
}
