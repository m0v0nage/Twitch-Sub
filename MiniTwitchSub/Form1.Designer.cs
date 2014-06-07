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
            this.FileLocationLabel = new System.Windows.Forms.Label();
            this.FileLocationDialog = new System.Windows.Forms.SaveFileDialog();
            this.FileLocationField = new System.Windows.Forms.TextBox();
            this.ChannelNameField = new System.Windows.Forms.TextBox();
            this.ChannelNameLabel = new System.Windows.Forms.Label();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CaptureButton
            // 
            this.CaptureButton.Location = new System.Drawing.Point(178, 104);
            this.CaptureButton.Name = "CaptureButton";
            this.CaptureButton.Size = new System.Drawing.Size(160, 62);
            this.CaptureButton.TabIndex = 7;
            this.CaptureButton.Text = "Capture";
            this.CaptureButton.Click += new System.EventHandler(this.CaptureButton_Click);
            // 
            // TwitchBrowser
            // 
            this.TwitchBrowser.Location = new System.Drawing.Point(374, 9);
            this.TwitchBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.TwitchBrowser.Name = "TwitchBrowser";
            this.TwitchBrowser.ScriptErrorsSuppressed = true;
            this.TwitchBrowser.Size = new System.Drawing.Size(719, 611);
            this.TwitchBrowser.TabIndex = 5;
            this.TwitchBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.TwitchBrowser_DocumentCompleted);
            // 
            // AuthorizeButton
            // 
            this.AuthorizeButton.Location = new System.Drawing.Point(12, 104);
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
            this.ClientIdField.Size = new System.Drawing.Size(250, 20);
            this.ClientIdField.TabIndex = 1;
            // 
            // ClientIdLabel
            // 
            this.ClientIdLabel.AutoSize = true;
            this.ClientIdLabel.Location = new System.Drawing.Point(9, 12);
            this.ClientIdLabel.Name = "ClientIdLabel";
            this.ClientIdLabel.Size = new System.Drawing.Size(47, 13);
            this.ClientIdLabel.TabIndex = 9;
            this.ClientIdLabel.Text = "Client ID";
            // 
            // RedirectURIField
            // 
            this.RedirectURIField.Location = new System.Drawing.Point(88, 32);
            this.RedirectURIField.Name = "RedirectURIField";
            this.RedirectURIField.Size = new System.Drawing.Size(250, 20);
            this.RedirectURIField.TabIndex = 2;
            this.RedirectURIField.Text = "http://localhost";
            // 
            // RedirectURILabel
            // 
            this.RedirectURILabel.AutoSize = true;
            this.RedirectURILabel.Location = new System.Drawing.Point(9, 35);
            this.RedirectURILabel.Name = "RedirectURILabel";
            this.RedirectURILabel.Size = new System.Drawing.Size(69, 13);
            this.RedirectURILabel.TabIndex = 11;
            this.RedirectURILabel.Text = "Redirect URI";
            // 
            // FileLocationLabel
            // 
            this.FileLocationLabel.AutoSize = true;
            this.FileLocationLabel.Location = new System.Drawing.Point(9, 80);
            this.FileLocationLabel.Name = "FileLocationLabel";
            this.FileLocationLabel.Size = new System.Drawing.Size(67, 13);
            this.FileLocationLabel.TabIndex = 12;
            this.FileLocationLabel.Text = "File Location";
            // 
            // FileLocationField
            // 
            this.FileLocationField.Location = new System.Drawing.Point(88, 78);
            this.FileLocationField.Name = "FileLocationField";
            this.FileLocationField.Size = new System.Drawing.Size(177, 20);
            this.FileLocationField.TabIndex = 4;
            // 
            // ChannelNameField
            // 
            this.ChannelNameField.Location = new System.Drawing.Point(88, 55);
            this.ChannelNameField.Name = "ChannelNameField";
            this.ChannelNameField.Size = new System.Drawing.Size(250, 20);
            this.ChannelNameField.TabIndex = 3;
            // 
            // ChannelNameLabel
            // 
            this.ChannelNameLabel.AutoSize = true;
            this.ChannelNameLabel.Location = new System.Drawing.Point(9, 58);
            this.ChannelNameLabel.Name = "ChannelNameLabel";
            this.ChannelNameLabel.Size = new System.Drawing.Size(77, 13);
            this.ChannelNameLabel.TabIndex = 15;
            this.ChannelNameLabel.Text = "Channel Name";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(271, 78);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(67, 21);
            this.BrowseButton.TabIndex = 5;
            this.BrowseButton.Text = "Browse...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 635);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.ChannelNameLabel);
            this.Controls.Add(this.ChannelNameField);
            this.Controls.Add(this.FileLocationField);
            this.Controls.Add(this.FileLocationLabel);
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
        private System.Windows.Forms.Label FileLocationLabel;
        private System.Windows.Forms.SaveFileDialog FileLocationDialog;
        private System.Windows.Forms.TextBox FileLocationField;
        private System.Windows.Forms.TextBox ChannelNameField;
        private System.Windows.Forms.Label ChannelNameLabel;
        private System.Windows.Forms.Button BrowseButton;
    }
}

