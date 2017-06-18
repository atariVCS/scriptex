namespace WHSAArmyPlanner.Forms
{
    partial class DialogTextPreview
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
            this.rtbArmylist = new System.Windows.Forms.RichTextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.cbIncludeProfile = new System.Windows.Forms.CheckBox();
            this.cbIncludeWargear = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rtbArmylist
            // 
            this.rtbArmylist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbArmylist.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbArmylist.Location = new System.Drawing.Point(13, 44);
            this.rtbArmylist.Name = "rtbArmylist";
            this.rtbArmylist.Size = new System.Drawing.Size(813, 510);
            this.rtbArmylist.TabIndex = 0;
            this.rtbArmylist.Text = "";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(13, 13);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Drucken";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_EndPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // cbIncludeProfile
            // 
            this.cbIncludeProfile.AutoSize = true;
            this.cbIncludeProfile.Location = new System.Drawing.Point(158, 17);
            this.cbIncludeProfile.Name = "cbIncludeProfile";
            this.cbIncludeProfile.Size = new System.Drawing.Size(98, 17);
            this.cbIncludeProfile.TabIndex = 2;
            this.cbIncludeProfile.Text = "Mit Profilwerten";
            this.cbIncludeProfile.UseVisualStyleBackColor = true;
            this.cbIncludeProfile.CheckedChanged += new System.EventHandler(this.cbIncludeProfile_CheckedChanged);
            // 
            // cbIncludeWargear
            // 
            this.cbIncludeWargear.AutoSize = true;
            this.cbIncludeWargear.Location = new System.Drawing.Point(272, 17);
            this.cbIncludeWargear.Name = "cbIncludeWargear";
            this.cbIncludeWargear.Size = new System.Drawing.Size(143, 17);
            this.cbIncludeWargear.TabIndex = 3;
            this.cbIncludeWargear.Text = "Mit Waffen und Wargear";
            this.cbIncludeWargear.UseVisualStyleBackColor = true;
            this.cbIncludeWargear.CheckedChanged += new System.EventHandler(this.cbIncludeWargear_CheckedChanged);
            // 
            // DialogTextPreview
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(836, 566);
            this.Controls.Add(this.cbIncludeWargear);
            this.Controls.Add(this.cbIncludeProfile);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.rtbArmylist);
            this.Name = "DialogTextPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liste Ansehen und Drucken (Text)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbArmylist;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.CheckBox cbIncludeProfile;
        private System.Windows.Forms.CheckBox cbIncludeWargear;
    }
}