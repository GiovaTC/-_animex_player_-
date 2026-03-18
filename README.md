# -_animex_player_- :.
🎬 AnimeX Player:

<img width="1024" height="1024" alt="image" src="https://github.com/user-attachments/assets/117fa713-f65c-49f6-be69-2733f2975b80" />  

```

C# (WinForms) + JavaScript (YouTube IFrame API)

Solución clara y funcional usando C# (Windows Forms en Visual Studio 2022) + JavaScript (YouTube IFrame API) para reproducir videos tipo “animex” (anime japonés) dentro de tu aplicación.

🧩 Arquitectura

La arquitectura es simple y robusta:

C# → UI (WinForms) + control WebBrowser
HTML + JavaScript → incrusta y controla YouTube

🧩 1. Crear el proyecto en Visual Studio 2022
Crear proyecto:

Tipo: Aplicación de Windows Forms (.NET Framework)

Nombre: AnimeXPlayer

En el formulario (Form1):

Agregar un control:

WebBrowser

Nombre: webBrowser1

Propiedad:

Dock = Fill

🌐 2. Crear archivo HTML (YouTube Player)

Crear archivo en el proyecto:

📄 player.html

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <title>AnimeX Player</title>
</head>
<body style="margin:0; background:black;">

    <div id="player"></div>

    <script>
        var tag = document.createElement('script');
        tag.src = "https://www.youtube.com/iframe_api";
        document.body.appendChild(tag);

        var player;

        function onYouTubeIframeAPIReady() {
            player = new YT.Player('player', {
                height: '100%',
                width: '100%',
                videoId: 'J---aiyznGQ', // ejemplo anime
                playerVars: {
                    autoplay: 1,
                    controls: 1
                }
            });
        }

        // función para cambiar video desde C#
        function loadVideo(videoId) {
            if (player) {
                player.loadVideoById(videoId);
            }
        }
    </script>

</body>
</html>

🧠 3. Código C# (Form1.cs)

Este código carga el HTML y permite enviar IDs de YouTube:

using System;
using System.IO;
using System.Windows.Forms;

namespace AnimeXPlayer
{
    public partial class Form1 : Form
    {
        string htmlPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            htmlPath = Path.Combine(Application.StartupPath, "player.html");

            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate(htmlPath);
        }

        // Método para cambiar video
        private void LoadYouTubeVideo(string videoId)
        {
            if (webBrowser1.Document != null)
            {
                webBrowser1.Document.InvokeScript("loadVideo", new object[] { videoId });
            }
        }

        // Ejemplo botón
        private void btnNaruto_Click(object sender, EventArgs e)
        {
            LoadYouTubeVideo("J---aiyznGQ"); // Naruto ejemplo
        }

        private void btnAttackOnTitan_Click(object sender, EventArgs e)
        {
            LoadYouTubeVideo("MGRm4IzK1SQ"); // AOT ejemplo
        }
    }
}

🎮 4. Agregar controles (UI)

En el formulario agregar:

Botones:

btnNaruto → "Naruto"

btnAttackOnTitan → "Attack on Titan"

Opcional:

TextBox para ingresar ID manual

🎯 5. Cómo obtener el ID del video

Ejemplo URL:

https://www.youtube.com/watch?v=MGRm4IzK1SQ

👉 ID del video:

MGRm4IzK1SQ
⚠️ Consideraciones técnicas

El control WebBrowser utiliza Internet Explorer, lo cual puede generar limitaciones.

✅ Alternativa recomendada:

👉 Usar WebView2 (Edge Chromium)
Más moderno, seguro y compatible con estándares actuales.

🚀 Mejora opcional (nivel profesional)

Puedes escalar la aplicación a:

🔎 Buscador de anime (API)

📺 Lista de reproducción

💾 Favoritos (Oracle o SQLite)

🎨 Interfaz tipo Netflix (UI moderna)

🎌 Ejemplo de contenido “animex”

Puedes usar openings populares de:

Naruto

Attack on Titan

One Piece

Demon Slayer

✅ Resultado

Tendrás una aplicación en C# que:

✔ Reproduce videos de YouTube

✔ Controla el video con JavaScript

✔ Permite cambiar anime dinámicamente / .
