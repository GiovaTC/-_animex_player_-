namespace animex_player
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTop;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView1;
        private System.Windows.Forms.Button btnNaruto;
        private System.Windows.Forms.Button btnAttackOnTitan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelTop = new Panel();
            btnNaruto = new Button();
            btnAttackOnTitan = new Button();
            webView1 = new Microsoft.Web.WebView2.WinForms.WebView2();

            ((System.ComponentModel.ISupportInitialize)(webView1)).BeginInit();
            SuspendLayout();

            // 🔝 PANEL SUPERIOR
            panelTop.Dock = DockStyle.Top;
            panelTop.Height = 60;
            panelTop.BackColor = Color.FromArgb(30, 30, 30);

            // 🎌 BOTÓN NARUTO
            btnNaruto.Text = "Naruto";
            btnNaruto.Size = new Size(100, 30);
            btnNaruto.Location = new Point(10, 15);
            btnNaruto.Click += btnNaruto_Click;

            // ⚔️ BOTÓN ATTACK ON TITAN
            btnAttackOnTitan.Text = "Attack on Titan";
            btnAttackOnTitan.Size = new Size(150, 30);
            btnAttackOnTitan.Location = new Point(120, 15);
            btnAttackOnTitan.Click += btnAttackOnTitan_Click;

            // Agregar botones al panel
            panelTop.Controls.Add(btnNaruto);
            panelTop.Controls.Add(btnAttackOnTitan);

            // 🎬 WEBVIEW
            webView1.AllowExternalDrop = true;
            webView1.CreationProperties = null;
            webView1.DefaultBackgroundColor = Color.Black;
            webView1.Dock = DockStyle.Fill;
            webView1.Location = new Point(0, 60);
            webView1.Name = "webView1";
            webView1.Size = new Size(800, 390);
            webView1.ZoomFactor = 1D;

            // 🪟 FORM
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(webView1);
            Controls.Add(panelTop);
            Name = "Form1";
            Text = "Animex Player";
            WindowState = FormWindowState.Maximized;

            ((System.ComponentModel.ISupportInitialize)(webView1)).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}