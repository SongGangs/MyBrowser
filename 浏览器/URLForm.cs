using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 浏览器
{
    public partial class URLForm : Form
    {
        public string URL { get; set; }
        public URLForm()
        {
            InitializeComponent();
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            URL = this.textBox1.Text.Trim();
            if(string.IsNullOrEmpty(URL))
                return;
            if (!URL.Contains("http://"))
                URL = "http://" + URL;
            this.DialogResult=DialogResult.OK;
            this.Close();
        }

        private void ESC_button_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Abort;
            this.Close();
        }
    }
}
