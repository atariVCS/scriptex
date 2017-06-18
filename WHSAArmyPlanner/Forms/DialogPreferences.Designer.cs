namespace WHSAArmyPlanner.Forms
{
    partial class DialogPreferences
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurrentTemplatesPath = new System.Windows.Forms.TextBox();
            this.btnPickDirectory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.fbdTemplateDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.lblHintCaption = new System.Windows.Forms.Label();
            this.lblHintText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Template Verzeichnis:";
            // 
            // txtCurrentTemplatesPath
            // 
            this.txtCurrentTemplatesPath.Location = new System.Drawing.Point(152, 32);
            this.txtCurrentTemplatesPath.Name = "txtCurrentTemplatesPath";
            this.txtCurrentTemplatesPath.Size = new System.Drawing.Size(212, 20);
            this.txtCurrentTemplatesPath.TabIndex = 1;
            this.txtCurrentTemplatesPath.TextChanged += new System.EventHandler(this.txtCurrentTemplatesPath_TextChanged);
            // 
            // btnPickDirectory
            // 
            this.btnPickDirectory.Location = new System.Drawing.Point(370, 30);
            this.btnPickDirectory.Name = "btnPickDirectory";
            this.btnPickDirectory.Size = new System.Drawing.Size(32, 23);
            this.btnPickDirectory.TabIndex = 2;
            this.btnPickDirectory.Text = "...";
            this.btnPickDirectory.UseVisualStyleBackColor = true;
            this.btnPickDirectory.Click += new System.EventHandler(this.btnPickDirectory_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Location = new System.Drawing.Point(12, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 37);
            this.panel1.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(329, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(410, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // lblHintCaption
            // 
            this.lblHintCaption.AutoSize = true;
            this.lblHintCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHintCaption.Location = new System.Drawing.Point(14, 68);
            this.lblHintCaption.Name = "lblHintCaption";
            this.lblHintCaption.Size = new System.Drawing.Size(36, 13);
            this.lblHintCaption.TabIndex = 4;
            this.lblHintCaption.Text = "Tipp:";
            // 
            // lblHintText
            // 
            this.lblHintText.AutoSize = true;
            this.lblHintText.Location = new System.Drawing.Point(51, 68);
            this.lblHintText.Name = "lblHintText";
            this.lblHintText.Size = new System.Drawing.Size(340, 39);
            this.lblHintText.TabIndex = 5;
            this.lblHintText.Text = "Unter \"Extras > ShareWithFriends\" kannst Du Vorlagen von Freunden \r\nund aus dem I" +
    "nternet importieren.\r\nDort kannst Du Deine Vorlagen auch für die Weitergabe dupl" +
    "izieren.\r\n";
            // 
            // DialogPreferences
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(516, 254);
            this.Controls.Add(this.lblHintText);
            this.Controls.Add(this.lblHintCaption);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPickDirectory);
            this.Controls.Add(this.txtCurrentTemplatesPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DialogPreferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ScriptorumExercitus - Einstellungen";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCurrentTemplatesPath;
        private System.Windows.Forms.Button btnPickDirectory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.FolderBrowserDialog fbdTemplateDirectory;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblHintCaption;
        private System.Windows.Forms.Label lblHintText;
    }
}