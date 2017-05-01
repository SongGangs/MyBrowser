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
    public partial class BookMarkForm : Form
    {
       public string title { get; set; }
       public string Url { get; set; }
       public string Catagoy { get; set; }
        public BookMarkForm()
        {
            InitializeComponent();
            BOOKcomboBox.Items.Add("游戏");
            BOOKcomboBox.Items.Add("购物");
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            title = this.TitleTxt.Text.Trim();
            Url = this.URLText.Text.Trim();
            Catagoy = this.BOOKcomboBox.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ESC_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        
    }
}
