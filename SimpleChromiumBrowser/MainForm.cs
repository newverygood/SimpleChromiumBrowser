using SimpleChromiumBrowser.Com.East.ExtChromiumBrowser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleChromiumBrowser
{
    public partial class MainForm : Form
    {
        private MyChromiumBrowser myBrowser;//浏览器对象

        public MainForm()
        {
            InitializeComponent();

            this.Load += MainForm_Load;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            myBrowser = MyChromiumBrowser.Instance(this);

            myBrowser.Navigate("http://www.baidu.com");

        }
    }
}
