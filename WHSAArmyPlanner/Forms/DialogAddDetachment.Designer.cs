namespace WHSAArmyPlanner.Forms
{
    partial class DialogAddDetachment
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
            this.cmbFaction = new System.Windows.Forms.ComboBox();
            this.cmbDetachments = new System.Windows.Forms.ComboBox();
            this.lblDetachment = new System.Windows.Forms.Label();
            this.lblFaction = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbFaction
            // 
            this.cmbFaction.FormattingEnabled = true;
            this.cmbFaction.Location = new System.Drawing.Point(60, 12);
            this.cmbFaction.Name = "cmbFaction";
            this.cmbFaction.Size = new System.Drawing.Size(155, 21);
            this.cmbFaction.TabIndex = 0;
            this.cmbFaction.SelectedIndexChanged += new System.EventHandler(this.cmbFaction_SelectedIndexChanged);
            // 
            // cmbDetachments
            // 
            this.cmbDetachments.FormattingEnabled = true;
            this.cmbDetachments.Location = new System.Drawing.Point(325, 12);
            this.cmbDetachments.Name = "cmbDetachments";
            this.cmbDetachments.Size = new System.Drawing.Size(145, 21);
            this.cmbDetachments.TabIndex = 1;
            this.cmbDetachments.SelectedIndexChanged += new System.EventHandler(this.cmbDetachments_SelectedIndexChanged);
            // 
            // lblDetachment
            // 
            this.lblDetachment.AutoSize = true;
            this.lblDetachment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetachment.Location = new System.Drawing.Point(83, 68);
            this.lblDetachment.Name = "lblDetachment";
            this.lblDetachment.Size = new System.Drawing.Size(10, 13);
            this.lblDetachment.TabIndex = 2;
            this.lblDetachment.Text = "-";
            // 
            // lblFaction
            // 
            this.lblFaction.AutoSize = true;
            this.lblFaction.Location = new System.Drawing.Point(83, 46);
            this.lblFaction.Name = "lblFaction";
            this.lblFaction.Size = new System.Drawing.Size(10, 13);
            this.lblFaction.TabIndex = 3;
            this.lblFaction.Text = "-";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Location = new System.Drawing.Point(13, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 39);
            this.panel1.TabIndex = 4;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(388, 9);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(3, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fraktion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Detachment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Deine Wahl:";
            // 
            // DialogAddDetachment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(495, 145);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFaction);
            this.Controls.Add(this.lblDetachment);
            this.Controls.Add(this.cmbDetachments);
            this.Controls.Add(this.cmbFaction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DialogAddDetachment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detachment einfügen";
            this.Load += new System.EventHandler(this.DialogAddDetachment_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFaction;
        private System.Windows.Forms.ComboBox cmbDetachments;
        private System.Windows.Forms.Label lblDetachment;
        private System.Windows.Forms.Label lblFaction;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}