using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace 浏览器
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.FormBorderStyle 为 None 时，若不如此处理，FormWindowState.Maximized 会遮盖任务栏
            this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            this.webBrowser1.Navigate(ConfigurationManager.AppSettings["Url_Home"].ToString());
            
        }
        //打开新的网址
        private void 新建对话ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            URLForm urlForm=new URLForm();
            urlForm.ShowDialog();
            if (urlForm.DialogResult == DialogResult.OK)
            {
                this.webBrowser1.Url=new Uri(urlForm.URL);
            }
        }

        //右上角退出按钮
        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("确定退出浏览器吗？", "温馨提示", MessageBoxButtons.OKCancel,MessageBoxIcon.Information)==DialogResult.OK)
                this.Close();
            else
            {
                return;
            }
        }
        //文件里的退出按钮
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("确定退出浏览器吗？", "温馨提示", MessageBoxButtons.OKCancel,MessageBoxIcon.Information)==DialogResult.OK)
                Application.Exit();
        }
        //刷新网页
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            QurrryUrl();
            
        }
        //获取TXT上的网址并改变TXT上的网址显示
        private void QurrryUrl()
        {
            string url = this.toolStripTextBox1.Text.ToString().Trim();
            if (url.Contains("https://"))
            {
                url = url.Replace("https://",String.Empty);
            }
            if(!url.Contains("http://"))
                url = "http://" + url;
            this.webBrowser1.Navigate(url);
            this.toolStripTextBox1.Text = url;
        }

        //加载主页
        public void GoHome()
        {
            //使用ConfigurationManager 必须先引用system.Configuration
            string urls = ConfigurationManager.AppSettings["Url_Home"].ToString();
            this.webBrowser1.Navigate(urls);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            GoHome();
        }

        //前往按钮
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            QurrryUrl();
        }
        //后退
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.webBrowser1.GoBack();
        }
        //向前
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.webBrowser1.GoForward();
        }

        private Dictionary<string, string> urlDictionary = new Dictionary<string, string>();
        private List<Class2> histories = null;
        private List<Class1> BookMarkListes = null;
 
        //查看历史记录
        
        //保存到文件
        private void WriteToTxt(string time, string title, string url)
        {
            string filePath = Application.StartupPath + "\\history.txt";

            //FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            //StreamWriter sw = new StreamWriter(fs);

            StreamWriter sw = new StreamWriter(filePath, true);
            sw.WriteLine(time + "|" + title + "|" + url);
            sw.Close();

            //fs.Close();
        }
        

        //读取历史记录文件内容
        //还不懂
        private List<Class2> hoList()
        {
            List<Class2> Result = new List<Class2>();
            try
            {
                string filePath = Application.StartupPath + "\\history.txt";
                FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string r = sr.ReadLine();
                while (!string.IsNullOrEmpty(r))
                {
                    try
                    {
                        string[] ds = r.Split('|');
                        string time = ds[0];
                        string Title = ds[1];
                        string Url = ds[2];
                        Result.Add(new Class2(Title,Url,time));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("请联系宋刚哥哥。");
                    }
                    finally
                    {
                        r = sr.ReadLine();
                    }
                }
                sr.Close();
                fs.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("请联系宋刚哥哥。");
            }
            return Result;
        }

        private List<Class1> BookMarklist()
        {
            List<Class1> result=new List<Class1>();
            try
            {
                string filepath = Application.StartupPath + "\\BookMark.txt";
                StreamReader sr = new StreamReader(filepath, true);
                string s = sr.ReadLine();
                while (!string.IsNullOrEmpty(s))
                {
                    try
                    {
                        string[] ds = s.Split('|');
                        string catalog = ds[0];
                        string title = ds[1];
                        string url = ds[2];
                        result.Add(new Class1(title, url, catalog));

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    finally
                    {
                        s = sr.ReadLine();
                    }
                }
                sr.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("请联系宋刚哥哥。");
            }
            return result;
        }

        private void toolStripButton6_MouseEnter(object sender, EventArgs e)
        {
            toolStripButton6.DropDownItems.Clear();
            histories = hoList();
            foreach (var VARIABLE in histories)
            {
                ToolStripMenuItem i = new ToolStripMenuItem(VARIABLE.title);
                toolStripButton6.DropDownItems.Add(i);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //如果一个页面中含有多个框架页，那么在每个框架页加载完成时也可能触发一次DocumentCompleted事件,采用此方法避免。
            
            if(e.Url.ToString()!=webBrowser1.Url.ToString())
                return;
            try
            {
                WriteToTxt(DateTime.Now.ToString(), this.webBrowser1.Document.Title, this.webBrowser1.Url.AbsoluteUri);
                this.toolStripTextBox1.Text = this.webBrowser1.Url.AbsoluteUri;
                this.StatusTitle.Text = this.webBrowser1.Document.Title;
                this.Text = this.webBrowser1.Document.Title;
            }
            catch (Exception)
            {
                
                MessageBox.Show("请联系你亲爱的刚哥哥！");
            }
        }

        //调整窗口大小
        private void PnlHeader_DoubleClick()
        {
            if(this.WindowState!=FormWindowState.Maximized)
                this.WindowState=FormWindowState.Maximized;
            else
            {
                this.WindowState=FormWindowState.Normal;
                this.CenterToScreen();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PnlHeader_DoubleClick();
        }

        private void toolStrip1_DoubleClick(object sender, EventArgs e)
        {
            PnlHeader_DoubleClick();
        }

        private void menuStrip1_DoubleClick(object sender, EventArgs e)
        {
            PnlHeader_DoubleClick();
        }

        private void 后退ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.webBrowser1.GoBack();
        }

        private void 前进ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.webBrowser1.GoForward();
        }

        private void 主页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoHome();
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QurrryUrl();
        }

        private void 全屏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请联系你亲爱的刚哥哥！");

        }

        private void 删除浏览器记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = Application.StartupPath + "\\history.txt";

            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Seek(0, SeekOrigin.Begin);
            fs.SetLength(0); 
        }

        private void 打开工具栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.toolStrip1.Show();
        }

        private void 关闭工具栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.toolStrip1.Hide();
        }

        private void 打开菜单栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.menuStrip1.Show();
        }

        private void 关闭菜单栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.menuStrip1.Hide();
        }

        //到时候问问老师吧 加载快捷键
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F10 )
            {
                MessageBox.Show("keyi");

            }
        }

        public void WriteToText(string title, string Url, string Catalog)
        {
            string filePath = Application.StartupPath + "\\BookMark.txt";
            StreamWriter sw=new StreamWriter(filePath,true);
            sw.WriteLine(Catalog+"|"+title+"|"+Url);
            sw.Close();
        }
        private void 添加到收藏夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookMarkForm bookMarkForm=new BookMarkForm();
            bookMarkForm.ShowDialog();
            //bookMarkForm.Url = this.webBrowser1.Url.AbsolutePath;
            //bookMarkForm.title = this.webBrowser1.Document.Title;
            if (bookMarkForm.DialogResult == DialogResult.OK)
                WriteToText(bookMarkForm.title,bookMarkForm.Url,bookMarkForm.Catagoy);
            bookMarkForm.Hide();
            
        }

        //读取历史记录
        private void toolStripButton6_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                //这句话的意思不懂
                string url = histories.Find(p => p.title == e.ClickedItem.Text).urlstring;
                if (url.Contains("https://"))
                {
                    url = url.Replace("https://", String.Empty);
                }
                if (!url.Contains("http://"))
                    url = "http://" + url;
                this.webBrowser1.Url = new Uri(url);
            }
            catch (Exception)
            { }
        }

        private void toolStripButton7_MouseEnter(object sender, EventArgs e)
        {
            this.toolStripButton7.DropDownItems.Clear();
            BookMarkListes = BookMarklist();
            foreach (var VARIABLE in BookMarkListes)
            {
                ToolStripMenuItem i = new ToolStripMenuItem(VARIABLE.catalog);
                i.DropDownItems.Add(VARIABLE.title);
                toolStripButton7.DropDownItems.Add(i);
                ;
                
            }

        }

        private void toolStripButton7_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                
                string url = BookMarkListes.Find(p => p.catalog == e.ClickedItem.Text).URLstring;
                if (url.Contains("https://"))
                    url = url.Replace("https://", String.Empty);
                if (!url.Contains("http://"))
                    url = "http://" + url;
                this.webBrowser1.Url = new Uri(url);
            }
            catch (Exception)
            {

                MessageBox.Show("请联系你亲爱的刚哥！");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Class2 user = new Class2("肖超", "2014");
            List<Class2> person = new List<Class2>();
            person.Add(user);
            person.Add(new Class2("张聪", "2014"));
            foreach (var VARIABLE in person)
            {
                if (name.Text.Trim() == VARIABLE.username && password.Text.Trim() == VARIABLE.password)
                {
                    MessageBox.Show("测试通过");

            }
        
        }
    }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.panel2.Visible = !this.panel2.Visible;
            
        }

     
        
        
        
        
    }
}
