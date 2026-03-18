using System;
using System.IO;
using System.Windows.Forms;

namespace animex_player
{
    public partial class Form1 : Form
    {
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

            // 🔥 Crear dominio local válido
            webView1.CoreWebView2.SetVirtualHostNameToFolderMapping(
                "app.local",
                Application.StartupPath,
                Microsoft.Web.WebView2.Core.CoreWebView2HostResourceAccessKind.Allow
            );

            // 🔥 Navegar como si fuera web real
            webView1.CoreWebView2.Navigate("https://app.local/player.html");
        }

        // 🔥 LLAMADA CORRECTA A JAVASCRIPT
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
            LoadYouTubeVideo("J---aiyznGQ"); // Naruto clásico
        }

        private void btnAttackOnTitan_Click(object sender, EventArgs e)
        {
            LoadYouTubeVideo("MGRm4IzK1SQ"); // AOT trailer
        }

        // 🔥 HTML INTEGRADO (CLAVE)
        private string GetPlayerHtml()
        {
            return @"
<!DOCTYPE html>
<html>
<head>
<meta charset='utf-8'>
<style>
    body { margin:0; background:black; }
    #player { width:100vw; height:100vh; }
</style>
</head>
<body>

<div id='player'></div>

<script src='https://www.youtube.com/iframe_api'></script>

<script>
    let player;

    function onYouTubeIframeAPIReady() {
        player = new YT.Player('player', {
            width: '100%',
            height: '100%',
            videoId: 'dQw4w9WgXcQ',
            playerVars: {
                origin: 'https://www.youtube.com'
            }
        });
    }

    function loadVideo(videoId) {
        if (player) {
            player.loadVideoById(videoId);
        }
    }
</script>

</body>
</html>";
        }
    }
}