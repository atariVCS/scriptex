namespace WHSAArmyPlanner.Forms
{
    partial class DialogHtmlPreview
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
            this.panWebView = new System.Windows.Forms.Panel();
            this.webHtmlPreview = new System.Windows.Forms.WebBrowser();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cbIncludeProfile = new System.Windows.Forms.CheckBox();
            this.cbIncludeWargear = new System.Windows.Forms.CheckBox();
            this.panWebView.SuspendLayout();
            this.SuspendLayout();
            // 
            // panWebView
            // 
            this.panWebView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panWebView.Controls.Add(this.webHtmlPreview);
            this.panWebView.Location = new System.Drawing.Point(12, 48);
            this.panWebView.Name = "panWebView";
            this.panWebView.Size = new System.Drawing.Size(755, 486);
            this.panWebView.TabIndex = 0;
            // 
            // webHtmlPreview
            // 
            this.webHtmlPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webHtmlPreview.Location = new System.Drawing.Point(3, 3);
            this.webHtmlPreview.MinimumSize = new System.Drawing.Size(20, 20);
            this.webHtmlPreview.Name = "webHtmlPreview";
            this.webHtmlPreview.Size = new System.Drawing.Size(749, 483);
            this.webHtmlPreview.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(13, 13);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Drucken";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // cbIncludeProfile
            // 
            this.cbIncludeProfile.AutoSize = true;
            this.cbIncludeProfile.Location = new System.Drawing.Point(131, 17);
            this.cbIncludeProfile.Name = "cbIncludeProfile";
            this.cbIncludeProfile.Size = new System.Drawing.Size(98, 17);
            this.cbIncludeProfile.TabIndex = 2;
            this.cbIncludeProfile.Text = "Mit Profilwerten";
            this.cbIncludeProfile.UseVisualStyleBackColor = true;
            // 
            // cbIncludeWargear
            // 
            this.cbIncludeWargear.AutoSize = true;
            this.cbIncludeWargear.Location = new System.Drawing.Point(260, 17);
            this.cbIncludeWargear.Name = "cbIncludeWargear";
            this.cbIncludeWargear.Size = new System.Drawing.Size(143, 17);
            this.cbIncludeWargear.TabIndex = 3;
            this.cbIncludeWargear.Text = "Mit Waffen und Wargear";
            this.cbIncludeWargear.UseVisualStyleBackColor = true;
            // 
            // DialogHtmlPreview
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(779, 546);
            this.Controls.Add(this.cbIncludeWargear);
            this.Controls.Add(this.cbIncludeProfile);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panWebView);
            this.Name = "DialogHtmlPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liste Ansehen und Drucken (HTML)";
            this.panWebView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panWebView;
        private System.Windows.Forms.WebBrowser webHtmlPreview;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.CheckBox cbIncludeProfile;
        private System.Windows.Forms.CheckBox cbIncludeWargear;
    }
}