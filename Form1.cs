using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace AnimexPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await webView1.EnsureCoreWebView2Async();

            webView1.NavigateToString(GetHtmlPlayer());
        }

        private string GetHtmlPlayer()
        {
            return @"
<!DOCTYPE html>
<html>
<head>
<meta charset='utf-8'>
<style>
    html, body {
        margin: 0;
        padding: 0;
        background: black;
        height: 100%;
        overflow: hidden;
    }

    #player {
        position: absolute;
        top: 0;
        left: 0;
        width: 100%;
        height: 100%;
    }
</style>
</head>
<body>

<div id='player'></div>

<script src='https://www.youtube.com/iframe_api'></script>

<script>
    var player;

    function onYouTubeIframeAPIReady() {
        player = new YT.Player('player', {
            width: '100%',
            height: '100%',
            videoId: 'J---aiyznGQ',
            playerVars: {
                autoplay: 1,
                controls: 1,
                modestbranding: 1,
                rel: 0
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

        private void btnNaruto_Click(object sender, EventArgs e)
        {
            webView1.ExecuteScriptAsync("loadVideo('dQw4w9WgXcQ')");
        }

        private void btnAOT_Click(object sender, EventArgs e)
        {
            webView1.ExecuteScriptAsync("loadVideo('MGRm4IzK1SQ')");
        }
    }
}