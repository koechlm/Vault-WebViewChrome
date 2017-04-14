﻿namespace VaultWebView
{
    partial class WebViewControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_webBrowser = new EO.WebBrowser.WinForm.WebControl();
            this.webView1 = new EO.WebBrowser.WebView();
            this.SuspendLayout();
            // 
            // m_webBrowser
            // 
            this.m_webBrowser.BackColor = System.Drawing.Color.White;
            this.m_webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_webBrowser.Location = new System.Drawing.Point(0, 0);
            this.m_webBrowser.Name = "m_webBrowser";
            this.m_webBrowser.Size = new System.Drawing.Size(577, 341);
            this.m_webBrowser.TabIndex = 0;
            this.m_webBrowser.Text = "webControl1";
            this.m_webBrowser.WebView = this.webView1;
            // 
            // WebViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_webBrowser);
            this.Name = "WebViewControl";
            this.Size = new System.Drawing.Size(577, 341);
            this.ResumeLayout(false);

        }

        #endregion

        private EO.WebBrowser.WinForm.WebControl m_webBrowser;
        private EO.WebBrowser.WebView webView1;
    }
}
