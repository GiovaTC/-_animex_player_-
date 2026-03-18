namespace animex_player
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnNaruto;
        private System.Windows.Forms.Button btnAOT;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                webView21?.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnNaruto = new System.Windows.Forms.Button();
            this.btnAOT = new System.Windows.Forms.Button();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();

            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();

            // panelTop
            this.panelTop.Controls.Add(this.btnNaruto);
            this.panelTop.Controls.Add(this.btnAOT);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 50;
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);

            // btnNaruto
            this.btnNaruto.Text = "Naruto";
            this.btnNaruto.Width = 120;
            this.btnNaruto.Height = 30;
            this.btnNaruto.Left = 10;
            this.btnNaruto.Top = 10;
            this.btnNaruto.Click += new System.EventHandler(this.btnNaruto_Click);

            // btnAOT
            this.btnAOT.Text = "Attack on Titan";
            this.btnAOT.Width = 150;
            this.btnAOT.Height = 30;
            this.btnAOT.Left = 140;
            this.btnAOT.Top = 10;
            this.btnAOT.Click += new System.EventHandler(this.btnAOT_Click);

            // webView21
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(0, 50);
            this.webView21.Name = "webView21";

            // Form1
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.panelTop);
            this.Text = "Animex Player";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
        }
    }
}