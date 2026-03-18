using System;
using System.IO;
using System.Windows.Forms;

namespace animex_player
{
    public partial class Form1 : Form
    {
        string htmlPath;
        public Form1()
        {
            InitializeComponent();
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            await webView1.EnsureCoreWebView2Async(null);

            webView1.CoreWebView2.Settings.AreDevToolsEnabled = false;
            webView1.CoreWebView2.Settings.AreDefaultScriptDialogsEnabled = false;

            webView1.Source = new Uri("https://www.youtube.com");
        }
        private void webView1_Click(object sender, EventArgs e)
        {

        }
    }
}
