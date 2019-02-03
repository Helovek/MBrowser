using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBrowser
{
    public partial class MBrowser : Form
    {
        public MBrowser()
        {
            InitializeComponent();
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void textBoxUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                webBrowser.Navigate(@"http://www." + textBoxUrl.Text);
            }
        }

        private void MBrowser_Load(object sender, EventArgs e)
        {

        }
    }
}
