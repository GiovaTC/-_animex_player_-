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
            this.Load += Form1_Load;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await webView1.EnsureCoreWebView2Async(null);

            webView1.CoreWebView2.Settings.AreDevToolsEnabled = false;
            webView1.CoreWebView2.Settings.AreDefaultScriptDialogsEnabled = false;

            // Ruta del HTML local
            htmlPath = Path.Combine(Application.StartupPath, "player.html");

            webView1.CoreWebView2.Navigate(htmlPath);
        }

        // 🔥 MÉTODO CORRECTO PARA LLAMAR JS
        private async void LoadYouTubeVideo(string videoId)
        {
            if (webView1.CoreWebView2 != null)
            {
                await webView1.CoreWebView2.ExecuteScriptAsync(
                    $"loadVideo('{videoId}')"
                );
            }
        }

        private void btnNaruto_Click(object sender, EventArgs e)
        {
            LoadYouTubeVideo("J---aiyznGQ");
        }

        private void btnAttackOnTitan_Click(object sender, EventArgs e)
        {
            LoadYouTubeVideo("MGRm4IzK1SQ");
        }
    }
}