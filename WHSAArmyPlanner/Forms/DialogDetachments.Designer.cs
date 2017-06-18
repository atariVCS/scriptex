namespace WHSAArmyPlanner.Forms
{
    partial class DialogDetachments
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
            this.lbDetachment = new System.Windows.Forms.ListBox();
            this.cmbBattleRoles = new System.Windows.Forms.ComboBox();
            this.boxSlot = new System.Windows.Forms.GroupBox();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSlotname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSlots = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddSlot = new System.Windows.Forms.Button();
            this.btnRemoveSlot = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.cbFaction = new System.Windows.Forms.CheckBox();
            this.cbIncludeTransports = new System.Windows.Forms.CheckBox();
            this.txtDetachmentName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEditName = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numCP = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.boxSlot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCP)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDetachment
            // 
            this.lbDetachment.FormattingEnabled = true;
            this.lbDetachment.Location = new System.Drawing.Point(12, 38);
            this.lbDetachment.Name = "lbDetachment";
            this.lbDetachment.Size = new System.Drawing.Size(155, 212);
            this.lbDetachment.TabIndex = 0;
            this.lbDetachment.SelectedIndexChanged += new System.EventHandler(this.lbDetachment_SelectedIndexChanged);
            // 
            // cmbBattleRoles
            // 
            this.cmbBattleRoles.FormattingEnabled = true;
            this.cmbBattleRoles.Location = new System.Drawing.Point(15, 94);
            this.cmbBattleRoles.Name = "cmbBattleRoles";
            this.cmbBattleRoles.Size = new System.Drawing.Size(135, 21);
            this.cmbBattleRoles.TabIndex = 6;
            // 
            // boxSlot
            // 
            this.boxSlot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxSlot.Controls.Add(this.numMax);
            this.boxSlot.Controls.Add(this.numMin);
            this.boxSlot.Controls.Add(this.label8);
            this.boxSlot.Controls.Add(this.label7);
            this.boxSlot.Controls.Add(this.lblSlotname);
            this.boxSlot.Controls.Add(this.label5);
            this.boxSlot.Location = new System.Drawing.Point(207, 94);
            this.boxSlot.Name = "boxSlot";
            this.boxSlot.Size = new System.Drawing.Size(163, 147);
            this.boxSlot.TabIndex = 2;
            this.boxSlot.TabStop = false;
            this.boxSlot.Text = "Slot- Einstellungen";
            // 
            // numMax
            // 
            this.numMax.Location = new System.Drawing.Point(74, 81);
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(55, 20);
            this.numMax.TabIndex = 1;
            this.numMax.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numMax.ValueChanged += new System.EventHandler(this.numMax_ValueChanged);
            // 
            // numMin
            // 
            this.numMin.Location = new System.Drawing.Point(74, 54);
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(55, 20);
            this.numMin.TabIndex = 0;
            this.numMin.ValueChanged += new System.EventHandler(this.numMin_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Maximal:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Minimum:";
            // 
            // lblSlotname
            // 
            this.lblSlotname.AutoSize = true;
            this.lblSlotname.Location = new System.Drawing.Point(71, 25);
            this.lblSlotname.Name = "lblSlotname";
            this.lblSlotname.Size = new System.Drawing.Size(10, 13);
            this.lblSlotname.TabIndex = 1;
            this.lblSlotname.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name:";
            // 
            // lbSlots
            // 
            this.lbSlots.FormattingEnabled = true;
            this.lbSlots.Location = new System.Drawing.Point(15, 121);
            this.lbSlots.Name = "lbSlots";
            this.lbSlots.Size = new System.Drawing.Size(165, 121);
            this.lbSlots.TabIndex = 8;
            this.lbSlots.SelectedIndexChanged += new System.EventHandler(this.lbSlots_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Detachments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Slot nach Battlerole hinzufügen";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(145, 256);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(22, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(117, 256);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(22, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddSlot
            // 
            this.btnAddSlot.Location = new System.Drawing.Point(156, 94);
            this.btnAddSlot.Name = "btnAddSlot";
            this.btnAddSlot.Size = new System.Drawing.Size(24, 21);
            this.btnAddSlot.TabIndex = 7;
            this.btnAddSlot.Text = "+";
            this.btnAddSlot.UseVisualStyleBackColor = true;
            this.btnAddSlot.Click += new System.EventHandler(this.btnAddSlot_Click);
            // 
            // btnRemoveSlot
            // 
            this.btnRemoveSlot.Location = new System.Drawing.Point(332, 257);
            this.btnRemoveSlot.Name = "btnRemoveSlot";
            this.btnRemoveSlot.Size = new System.Drawing.Size(24, 23);
            this.btnRemoveSlot.TabIndex = 5;
            this.btnRemoveSlot.Text = "-";
            this.btnRemoveSlot.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Gewählten Slot entfernen:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Location = new System.Drawing.Point(12, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 44);
            this.panel1.TabIndex = 0;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(364, 14);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(91, 23);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Übernehmen";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(267, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(461, 14);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 257);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(99, 20);
            this.txtInput.TabIndex = 1;
            // 
            // cbFaction
            // 
            this.cbFaction.AutoSize = true;
            this.cbFaction.Location = new System.Drawing.Point(15, 31);
            this.cbFaction.Name = "cbFaction";
            this.cbFaction.Size = new System.Drawing.Size(171, 17);
            this.cbFaction.TabIndex = 2;
            this.cbFaction.Text = "Auf eine Fraktion beschränken";
            this.cbFaction.UseVisualStyleBackColor = true;
            this.cbFaction.CheckedChanged += new System.EventHandler(this.cbFaction_CheckedChanged);
            // 
            // cbIncludeTransports
            // 
            this.cbIncludeTransports.AutoSize = true;
            this.cbIncludeTransports.Location = new System.Drawing.Point(15, 54);
            this.cbIncludeTransports.Name = "cbIncludeTransports";
            this.cbIncludeTransports.Size = new System.Drawing.Size(116, 17);
            this.cbIncludeTransports.TabIndex = 3;
            this.cbIncludeTransports.Text = "Enthält Transporter";
            this.cbIncludeTransports.UseVisualStyleBackColor = true;
            this.cbIncludeTransports.CheckedChanged += new System.EventHandler(this.cbIncludeTransports_CheckedChanged);
            // 
            // txtDetachmentName
            // 
            this.txtDetachmentName.Enabled = false;
            this.txtDetachmentName.Location = new System.Drawing.Point(120, 5);
            this.txtDetachmentName.Name = "txtDetachmentName";
            this.txtDetachmentName.Size = new System.Drawing.Size(188, 20);
            this.txtDetachmentName.TabIndex = 0;
            this.txtDetachmentName.TextChanged += new System.EventHandler(this.txtDetachmentName_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnEditName);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.numCP);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtDetachmentName);
            this.panel2.Controls.Add(this.cbIncludeTransports);
            this.panel2.Controls.Add(this.cbFaction);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnAddSlot);
            this.panel2.Controls.Add(this.boxSlot);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbSlots);
            this.panel2.Controls.Add(this.cmbBattleRoles);
            this.panel2.Location = new System.Drawing.Point(176, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 281);
            this.panel2.TabIndex = 4;
            // 
            // btnEditName
            // 
            this.btnEditName.Location = new System.Drawing.Point(314, 5);
            this.btnEditName.Name = "btnEditName";
            this.btnEditName.Size = new System.Drawing.Size(51, 20);
            this.btnEditName.TabIndex = 1;
            this.btnEditName.Text = "Edit";
            this.btnEditName.UseVisualStyleBackColor = true;
            this.btnEditName.Click += new System.EventHandler(this.btnEditName_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Detachment Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "(Boni des Detachments)";
            // 
            // numCP
            // 
            this.numCP.Location = new System.Drawing.Point(318, 41);
            this.numCP.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numCP.Name = "numCP";
            this.numCP.Size = new System.Drawing.Size(47, 20);
            this.numCP.TabIndex = 5;
            this.numCP.ValueChanged += new System.EventHandler(this.numCP_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Commandpoints";
            // 
            // DialogDetachments
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(559, 351);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRemoveSlot);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDetachment);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DialogDetachments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detachments Vorlagen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DialogDetachments_FormClosing);
            this.Load += new System.EventHandler(this.Detachments_Load);
            this.boxSlot.ResumeLayout(false);
            this.boxSlot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDetachment;
        private System.Windows.Forms.ComboBox cmbBattleRoles;
        private System.Windows.Forms.GroupBox boxSlot;
        private System.Windows.Forms.ListBox lbSlots;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddSlot;
        private System.Windows.Forms.Button btnRemoveSlot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSlotname;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.CheckBox cbFaction;
        private System.Windows.Forms.CheckBox cbIncludeTransports;
        private System.Windows.Forms.TextBox txtDetachmentName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numCP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEditName;
        private System.Windows.Forms.Button btnApply;
    }
}