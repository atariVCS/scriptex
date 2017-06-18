namespace WHSAArmyPlanner.CustomControls
{
    partial class UcSlot
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
            this.cmbUnitTemplate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAllModels = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbActualComposition = new System.Windows.Forms.ListBox();
            this.lblIndicator = new System.Windows.Forms.Label();
            this.lblUnitNUmber = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLeadership = new System.Windows.Forms.Label();
            this.lblToughness = new System.Windows.Forms.Label();
            this.lblSave = new System.Windows.Forms.Label();
            this.lblAttacks = new System.Windows.Forms.Label();
            this.lblWounds = new System.Windows.Forms.Label();
            this.lblStrength = new System.Windows.Forms.Label();
            this.lblBS = new System.Windows.Forms.Label();
            this.lblWS = new System.Windows.Forms.Label();
            this.lblMovement = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPL = new System.Windows.Forms.Label();
            this.lblMP = new System.Windows.Forms.Label();
            this.lblPLVal = new System.Windows.Forms.Label();
            this.lblPointsVal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numExtraModels = new System.Windows.Forms.NumericUpDown();
            this.lblExtraCosts = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.lblReplacementInfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExtraModels)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUnitTemplate
            // 
            this.cmbUnitTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnitTemplate.FormattingEnabled = true;
            this.cmbUnitTemplate.Location = new System.Drawing.Point(190, 12);
            this.cmbUnitTemplate.Name = "cmbUnitTemplate";
            this.cmbUnitTemplate.Size = new System.Drawing.Size(218, 23);
            this.cmbUnitTemplate.TabIndex = 0;
            this.cmbUnitTemplate.SelectedIndexChanged += new System.EventHandler(this.cmbUnitTemplate_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Einheit auswählen:";
            // 
            // lbAllModels
            // 
            this.lbAllModels.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAllModels.FormattingEnabled = true;
            this.lbAllModels.ItemHeight = 15;
            this.lbAllModels.Location = new System.Drawing.Point(76, 63);
            this.lbAllModels.Name = "lbAllModels";
            this.lbAllModels.Size = new System.Drawing.Size(172, 139);
            this.lbAllModels.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Verfügbare Modelle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Meine Zusammenstellung:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(254, 62);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(254, 176);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(50, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "<<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbActualComposition
            // 
            this.lbActualComposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActualComposition.FormattingEnabled = true;
            this.lbActualComposition.ItemHeight = 15;
            this.lbActualComposition.Location = new System.Drawing.Point(313, 62);
            this.lbActualComposition.Name = "lbActualComposition";
            this.lbActualComposition.Size = new System.Drawing.Size(184, 139);
            this.lbActualComposition.TabIndex = 7;
            this.lbActualComposition.SelectedIndexChanged += new System.EventHandler(this.lbActualComposition_SelectedIndexChanged);
            // 
            // lblIndicator
            // 
            this.lblIndicator.BackColor = System.Drawing.Color.Firebrick;
            this.lblIndicator.Location = new System.Drawing.Point(0, 0);
            this.lblIndicator.Name = "lblIndicator";
            this.lblIndicator.Size = new System.Drawing.Size(67, 202);
            this.lblIndicator.TabIndex = 8;
            this.lblIndicator.Text = " ";
            // 
            // lblUnitNUmber
            // 
            this.lblUnitNUmber.AutoSize = true;
            this.lblUnitNUmber.BackColor = System.Drawing.Color.Black;
            this.lblUnitNUmber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitNUmber.ForeColor = System.Drawing.Color.White;
            this.lblUnitNUmber.Location = new System.Drawing.Point(14, 20);
            this.lblUnitNUmber.Name = "lblUnitNUmber";
            this.lblUnitNUmber.Size = new System.Drawing.Size(36, 26);
            this.lblUnitNUmber.TabIndex = 9;
            this.lblUnitNUmber.Text = "99";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblReplacementInfo);
            this.groupBox1.Controls.Add(this.lblLeadership);
            this.groupBox1.Controls.Add(this.lblToughness);
            this.groupBox1.Controls.Add(this.lblSave);
            this.groupBox1.Controls.Add(this.lblAttacks);
            this.groupBox1.Controls.Add(this.lblWounds);
            this.groupBox1.Controls.Add(this.lblStrength);
            this.groupBox1.Controls.Add(this.lblBS);
            this.groupBox1.Controls.Add(this.lblWS);
            this.groupBox1.Controls.Add(this.lblMovement);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(503, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 105);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gewählte Einheit";
            // 
            // lblLeadership
            // 
            this.lblLeadership.AutoSize = true;
            this.lblLeadership.Location = new System.Drawing.Point(185, 57);
            this.lblLeadership.Name = "lblLeadership";
            this.lblLeadership.Size = new System.Drawing.Size(11, 15);
            this.lblLeadership.TabIndex = 19;
            this.lblLeadership.Text = "-";
            // 
            // lblToughness
            // 
            this.lblToughness.AutoSize = true;
            this.lblToughness.Location = new System.Drawing.Point(118, 57);
            this.lblToughness.Name = "lblToughness";
            this.lblToughness.Size = new System.Drawing.Size(11, 15);
            this.lblToughness.TabIndex = 18;
            this.lblToughness.Text = "-";
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Location = new System.Drawing.Point(210, 57);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(11, 15);
            this.lblSave.TabIndex = 17;
            this.lblSave.Text = "-";
            // 
            // lblAttacks
            // 
            this.lblAttacks.AutoSize = true;
            this.lblAttacks.Location = new System.Drawing.Point(163, 57);
            this.lblAttacks.Name = "lblAttacks";
            this.lblAttacks.Size = new System.Drawing.Size(11, 15);
            this.lblAttacks.TabIndex = 16;
            this.lblAttacks.Text = "-";
            // 
            // lblWounds
            // 
            this.lblWounds.AutoSize = true;
            this.lblWounds.Location = new System.Drawing.Point(138, 57);
            this.lblWounds.Name = "lblWounds";
            this.lblWounds.Size = new System.Drawing.Size(11, 15);
            this.lblWounds.TabIndex = 15;
            this.lblWounds.Text = "-";
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.Location = new System.Drawing.Point(97, 57);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(11, 15);
            this.lblStrength.TabIndex = 14;
            this.lblStrength.Text = "-";
            // 
            // lblBS
            // 
            this.lblBS.AutoSize = true;
            this.lblBS.Location = new System.Drawing.Point(67, 57);
            this.lblBS.Name = "lblBS";
            this.lblBS.Size = new System.Drawing.Size(11, 15);
            this.lblBS.TabIndex = 13;
            this.lblBS.Text = "-";
            // 
            // lblWS
            // 
            this.lblWS.AutoSize = true;
            this.lblWS.Location = new System.Drawing.Point(40, 57);
            this.lblWS.Name = "lblWS";
            this.lblWS.Size = new System.Drawing.Size(11, 15);
            this.lblWS.TabIndex = 12;
            this.lblWS.Text = "-";
            // 
            // lblMovement
            // 
            this.lblMovement.AutoSize = true;
            this.lblMovement.Location = new System.Drawing.Point(11, 57);
            this.lblMovement.Name = "lblMovement";
            this.lblMovement.Size = new System.Drawing.Size(11, 15);
            this.lblMovement.TabIndex = 11;
            this.lblMovement.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(210, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 15);
            this.label12.TabIndex = 9;
            this.label12.Text = "Sv";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(183, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "Ld";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(163, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(138, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "W";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "T";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "S";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "BS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "WS";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(11, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(11, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "M";
            // 
            // lblPL
            // 
            this.lblPL.AutoSize = true;
            this.lblPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPL.Location = new System.Drawing.Point(511, 45);
            this.lblPL.Name = "lblPL";
            this.lblPL.Size = new System.Drawing.Size(77, 15);
            this.lblPL.TabIndex = 12;
            this.lblPL.Text = "Powerlevel";
            // 
            // lblMP
            // 
            this.lblMP.AutoSize = true;
            this.lblMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMP.Location = new System.Drawing.Point(631, 45);
            this.lblMP.Name = "lblMP";
            this.lblMP.Size = new System.Drawing.Size(51, 15);
            this.lblMP.TabIndex = 13;
            this.lblMP.Text = "Punkte";
            // 
            // lblPLVal
            // 
            this.lblPLVal.AutoSize = true;
            this.lblPLVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPLVal.Location = new System.Drawing.Point(594, 45);
            this.lblPLVal.Name = "lblPLVal";
            this.lblPLVal.Size = new System.Drawing.Size(11, 15);
            this.lblPLVal.TabIndex = 14;
            this.lblPLVal.Text = "-";
            // 
            // lblPointsVal
            // 
            this.lblPointsVal.AutoSize = true;
            this.lblPointsVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointsVal.Location = new System.Drawing.Point(688, 45);
            this.lblPointsVal.Name = "lblPointsVal";
            this.lblPointsVal.Size = new System.Drawing.Size(11, 15);
            this.lblPointsVal.TabIndex = 15;
            this.lblPointsVal.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(503, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Extra Modelle:";
            // 
            // numExtraModels
            // 
            this.numExtraModels.Location = new System.Drawing.Point(583, 174);
            this.numExtraModels.Name = "numExtraModels";
            this.numExtraModels.Size = new System.Drawing.Size(49, 20);
            this.numExtraModels.TabIndex = 17;
            this.numExtraModels.ValueChanged += new System.EventHandler(this.numExtraModels_ValueChanged);
            // 
            // lblExtraCosts
            // 
            this.lblExtraCosts.AutoSize = true;
            this.lblExtraCosts.Location = new System.Drawing.Point(641, 176);
            this.lblExtraCosts.Name = "lblExtraCosts";
            this.lblExtraCosts.Size = new System.Drawing.Size(74, 13);
            this.lblExtraCosts.TabIndex = 18;
            this.lblExtraCosts.Text = "( + PL / + Pkt)";
            // 
            // btnClear
            // 
            this.btnClear.Image = global::WHSAArmyPlanner.Properties.Resources.tonne;
            this.btnClear.Location = new System.Drawing.Point(473, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(24, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLock
            // 
            this.btnLock.Enabled = false;
            this.btnLock.Image = global::WHSAArmyPlanner.Properties.Resources._lock;
            this.btnLock.Location = new System.Drawing.Point(414, 12);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(27, 23);
            this.btnLock.TabIndex = 10;
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // lblReplacementInfo
            // 
            this.lblReplacementInfo.AutoSize = true;
            this.lblReplacementInfo.Location = new System.Drawing.Point(11, 87);
            this.lblReplacementInfo.Name = "lblReplacementInfo";
            this.lblReplacementInfo.Size = new System.Drawing.Size(11, 15);
            this.lblReplacementInfo.TabIndex = 20;
            this.lblReplacementInfo.Text = "-";
            // 
            // UcSlot
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblExtraCosts);
            this.Controls.Add(this.numExtraModels);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblPointsVal);
            this.Controls.Add(this.lblPLVal);
            this.Controls.Add(this.lblMP);
            this.Controls.Add(this.lblPL);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.lblUnitNUmber);
            this.Controls.Add(this.lblIndicator);
            this.Controls.Add(this.lbActualComposition);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAllModels);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUnitTemplate);
            this.Name = "UcSlot";
            this.Size = new System.Drawing.Size(764, 202);
            this.Load += new System.EventHandler(this.UcSlot_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExtraModels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUnitTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbAllModels;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lbActualComposition;
        private System.Windows.Forms.Label lblIndicator;
        private System.Windows.Forms.Label lblUnitNUmber;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPL;
        private System.Windows.Forms.Label lblMP;
        private System.Windows.Forms.Label lblPLVal;
        private System.Windows.Forms.Label lblPointsVal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblLeadership;
        private System.Windows.Forms.Label lblToughness;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Label lblAttacks;
        private System.Windows.Forms.Label lblWounds;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.Label lblBS;
        private System.Windows.Forms.Label lblWS;
        private System.Windows.Forms.Label lblMovement;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numExtraModels;
        private System.Windows.Forms.Label lblExtraCosts;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblReplacementInfo;
    }
}
