namespace WHSAArmyPlanner.Forms
{
    partial class DialogNewArmy
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
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPointsLimit = new System.Windows.Forms.CheckBox();
            this.cbPowerlevelLimit = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPowerlevelLimit = new System.Windows.Forms.TextBox();
            this.txtPointsLimit = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFaction = new System.Windows.Forms.ComboBox();
            this.cbStrictPlay = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(355, 8);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // cbPointsLimit
            // 
            this.cbPointsLimit.AutoSize = true;
            this.cbPointsLimit.Location = new System.Drawing.Point(12, 86);
            this.cbPointsLimit.Name = "cbPointsLimit";
            this.cbPointsLimit.Size = new System.Drawing.Size(128, 17);
            this.cbPointsLimit.TabIndex = 3;
            this.cbPointsLimit.Text = "Punktelimit (Matched)";
            this.cbPointsLimit.UseVisualStyleBackColor = true;
            this.cbPointsLimit.CheckedChanged += new System.EventHandler(this.cbPointsLimit_CheckedChanged);
            // 
            // cbPowerlevelLimit
            // 
            this.cbPowerlevelLimit.AutoSize = true;
            this.cbPowerlevelLimit.Location = new System.Drawing.Point(12, 54);
            this.cbPowerlevelLimit.Name = "cbPowerlevelLimit";
            this.cbPowerlevelLimit.Size = new System.Drawing.Size(105, 17);
            this.cbPowerlevelLimit.TabIndex = 1;
            this.cbPowerlevelLimit.Text = "Powerlevel- Limit";
            this.cbPowerlevelLimit.UseVisualStyleBackColor = true;
            this.cbPowerlevelLimit.CheckedChanged += new System.EventHandler(this.cbPowerlevelLimit_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(62, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtPowerlevelLimit
            // 
            this.txtPowerlevelLimit.Enabled = false;
            this.txtPowerlevelLimit.Location = new System.Drawing.Point(147, 51);
            this.txtPowerlevelLimit.Name = "txtPowerlevelLimit";
            this.txtPowerlevelLimit.Size = new System.Drawing.Size(58, 20);
            this.txtPowerlevelLimit.TabIndex = 2;
            this.txtPowerlevelLimit.TextChanged += new System.EventHandler(this.txtPowerlevelLimit_TextChanged);
            // 
            // txtPointsLimit
            // 
            this.txtPointsLimit.Enabled = false;
            this.txtPointsLimit.Location = new System.Drawing.Point(146, 84);
            this.txtPointsLimit.Name = "txtPointsLimit";
            this.txtPointsLimit.Size = new System.Drawing.Size(59, 20);
            this.txtPointsLimit.TabIndex = 4;
            this.txtPointsLimit.TextChanged += new System.EventHandler(this.txtPointsLimit_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Location = new System.Drawing.Point(12, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 44);
            this.panel1.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(3, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbFaction);
            this.panel2.Controls.Add(this.cbStrictPlay);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(238, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 111);
            this.panel2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fraktion:";
            // 
            // cmbFaction
            // 
            this.cmbFaction.Enabled = false;
            this.cmbFaction.FormattingEnabled = true;
            this.cmbFaction.Location = new System.Drawing.Point(57, 22);
            this.cmbFaction.Name = "cmbFaction";
            this.cmbFaction.Size = new System.Drawing.Size(142, 21);
            this.cmbFaction.TabIndex = 1;
            this.cmbFaction.SelectedIndexChanged += new System.EventHandler(this.cmbFaction_SelectedIndexChanged);
            // 
            // cbStrictPlay
            // 
            this.cbStrictPlay.AutoSize = true;
            this.cbStrictPlay.Location = new System.Drawing.Point(6, 3);
            this.cbStrictPlay.Name = "cbStrictPlay";
            this.cbStrictPlay.Size = new System.Drawing.Size(171, 17);
            this.cbStrictPlay.TabIndex = 0;
            this.cbStrictPlay.Text = "Strict Match (nur eine Fraktion)";
            this.cbStrictPlay.UseVisualStyleBackColor = true;
            this.cbStrictPlay.CheckedChanged += new System.EventHandler(this.cbStrictPlay_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipp: Wähle eine Hauptfraktion \r\n(z.B.: Imperium, Eldari...) um eine \r\ngültige \"V" +
    "erbündeten\"-Liste zu erstellen.";
            // 
            // DialogNewArmy
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(461, 199);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPointsLimit);
            this.Controls.Add(this.txtPowerlevelLimit);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cbPowerlevelLimit);
            this.Controls.Add(this.cbPointsLimit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DialogNewArmy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Neue Armeeliste";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbPointsLimit;
        private System.Windows.Forms.CheckBox cbPowerlevelLimit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPowerlevelLimit;
        private System.Windows.Forms.TextBox txtPointsLimit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbStrictPlay;
        private System.Windows.Forms.ComboBox cmbFaction;
        private System.Windows.Forms.Label label3;
    }
}