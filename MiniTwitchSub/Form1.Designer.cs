namespace MiniTwitchSub
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CaptureButton = new System.Windows.Forms.Button();
            this.TwitchBrowser = new System.Windows.Forms.WebBrowser();
            this.AuthorizeButton = new System.Windows.Forms.Button();
            this.ClientIdField = new System.Windows.Forms.TextBox();
            this.ClientIdLabel = new System.Windows.Forms.Label();
            this.RedirectURIField = new System.Windows.Forms.TextBox();
            this.RedirectURILabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CaptureButton
            // 
            this.CaptureButton.Location = new System.Drawing.Point(178, 58);
            this.CaptureButton.Name = "CaptureButton";
            this.CaptureButton.Size = new System.Drawing.Size(160, 62);
            this.CaptureButton.TabIndex = 7;
            this.CaptureButton.Text = "Capture";
            // 
            // TwitchBrowser
            // 
            this.TwitchBrowser.Location = new System.Drawing.Point(374, 9);
            this.TwitchBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.TwitchBrowser.Name = "TwitchBrowser";
            this.TwitchBrowser.Size = new System.Drawing.Size(719, 611);
            this.TwitchBrowser.TabIndex = 5;
            this.TwitchBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.TwitchBrowser_DocumentCompleted);
            // 
            // AuthorizeButton
            // 
            this.AuthorizeButton.Location = new System.Drawing.Point(12, 58);
            this.AuthorizeButton.Name = "AuthorizeButton";
            this.AuthorizeButton.Size = new System.Drawing.Size(160, 62);
            this.AuthorizeButton.TabIndex = 6;
            this.AuthorizeButton.Text = "Authorize";
            this.AuthorizeButton.UseVisualStyleBackColor = true;
            this.AuthorizeButton.Click += new System.EventHandler(this.AuthorizeButton_Click);
            // 
            // ClientIdField
            // 
            this.ClientIdField.Location = new System.Drawing.Point(88, 9);
            this.ClientIdField.Name = "ClientIdField";
            this.ClientIdField.Size = new System.Drawing.Size(214, 20);
            this.ClientIdField.TabIndex = 8;
            // 
            // ClientIdLabel
            // 
            this.ClientIdLabel.AutoSize = true;
            this.ClientIdLabel.Location = new System.Drawing.Point(12, 12);
            this.ClientIdLabel.Name = "ClientIdLabel";
            this.ClientIdLabel.Size = new System.Drawing.Size(47, 13);
            this.ClientIdLabel.TabIndex = 9;
            this.ClientIdLabel.Text = "Client ID";
            // 
            // RedirectURIField
            // 
            this.RedirectURIField.Location = new System.Drawing.Point(88, 32);
            this.RedirectURIField.Name = "RedirectURIField";
            this.RedirectURIField.Size = new System.Drawing.Size(214, 20);
            this.RedirectURIField.TabIndex = 10;
            // 
            // RedirectURILabel
            // 
            this.RedirectURILabel.AutoSize = true;
            this.RedirectURILabel.Location = new System.Drawing.Point(12, 35);
            this.RedirectURILabel.Name = "RedirectURILabel";
            this.RedirectURILabel.Size = new System.Drawing.Size(69, 13);
            this.RedirectURILabel.TabIndex = 11;
            this.RedirectURILabel.Text = "Redirect URI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 635);
            this.Controls.Add(this.RedirectURILabel);
            this.Controls.Add(this.RedirectURIField);
            this.Controls.Add(this.ClientIdLabel);
            this.Controls.Add(this.ClientIdField);
            this.Controls.Add(this.AuthorizeButton);
            this.Controls.Add(this.TwitchBrowser);
            this.Controls.Add(this.CaptureButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CaptureButton;
        private System.Windows.Forms.WebBrowser TwitchBrowser;
        private System.Windows.Forms.Button AuthorizeButton;
        private System.Windows.Forms.TextBox ClientIdField;
        private System.Windows.Forms.Label ClientIdLabel;
        private System.Windows.Forms.TextBox RedirectURIField;
        private System.Windows.Forms.Label RedirectURILabel;
    }
}

