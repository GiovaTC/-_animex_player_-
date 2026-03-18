namespace animex_player
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            webView1 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webView1).BeginInit();
            SuspendLayout();

            // webView1
            webView1.AllowExternalDrop = true;
            webView1.CreationProperties = null;
            webView1.DefaultBackgroundColor = Color.White;
            webView1.Dock = DockStyle.Fill;
            webView1.Location = new Point(0, 0);
            webView1.Name = "webView1";
            webView1.Size = new Size(800, 450);
            webView1.TabIndex = 0;
            webView1.ZoomFactor = 1D;

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(webView1);
            Name = "Form1";
            Text = "Animex Player";

            ((System.ComponentModel.ISupportInitialize)webView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView1;
    }
}
