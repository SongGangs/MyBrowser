using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 浏览器
{
    class Class1
    {
        public string title { set; get; }
        public string URLstring { get; set; }
        public string catalog { get; set; }
        public Class1(string title, string urlstring, string catalog)
        {
            this.title = title;
            this.catalog = catalog;
            this.URLstring = urlstring;
        }
    }
}
