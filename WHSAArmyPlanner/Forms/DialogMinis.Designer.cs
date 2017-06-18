namespace WHSAArmyPlanner.Forms
{
    partial class DialogMinis
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
            this.lbMinis = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.cmbFaction = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblFaction = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKeywords = new System.Windows.Forms.TextBox();
            this.lblKeywords = new System.Windows.Forms.Label();
            this.btnRemoveGear = new System.Windows.Forms.Button();
            this.btnAddGear = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lbStandardGear = new System.Windows.Forms.ListBox();
            this.cmbStandardGear = new System.Windows.Forms.ComboBox();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.txtLeadership = new System.Windows.Forms.TextBox();
            this.txtAttacks = new System.Windows.Forms.TextBox();
            this.txtWounds = new System.Windows.Forms.TextBox();
            this.txtToughness = new System.Windows.Forms.TextBox();
            this.txtStrength = new System.Windows.Forms.TextBox();
            this.txtBs = new System.Windows.Forms.TextBox();
            this.txtWs = new System.Windows.Forms.TextBox();
            this.txtMovement = new System.Windows.Forms.TextBox();
            this.txtAbilities = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblModelName = new System.Windows.Forms.Label();
            this.lblModelFaction = new System.Windows.Forms.Label();
            this.cmbModelFaction = new System.Windows.Forms.ComboBox();
            this.txtModelName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMinis
            // 
            this.lbMinis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMinis.FormattingEnabled = true;
            this.lbMinis.Location = new System.Drawing.Point(12, 49);
            this.lbMinis.Name = "lbMinis";
            this.lbMinis.Size = new System.Drawing.Size(235, 381);
            this.lbMinis.TabIndex = 2;
            this.lbMinis.SelectedIndexChanged += new System.EventHandler(this.lbMinis_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WHSAArmyPlanner.Properties.Resources.Lupe;
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 33);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(55, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(127, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtInput.Location = new System.Drawing.Point(63, 468);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(130, 20);
            this.txtInput.TabIndex = 4;
            // 
            // cmbFaction
            // 
            this.cmbFaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbFaction.FormattingEnabled = true;
            this.cmbFaction.Location = new System.Drawing.Point(63, 441);
            this.cmbFaction.Name = "cmbFaction";
            this.cmbFaction.Size = new System.Drawing.Size(130, 21);
            this.cmbFaction.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Location = new System.Drawing.Point(12, 504);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 41);
            this.panel1.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(245, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(343, 10);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(93, 23);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Übernehmen";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(442, 10);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(225, 465);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(21, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Location = new System.Drawing.Point(199, 465);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(21, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblFaction
            // 
            this.lblFaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFaction.AutoSize = true;
            this.lblFaction.Location = new System.Drawing.Point(9, 444);
            this.lblFaction.Name = "lblFaction";
            this.lblFaction.Size = new System.Drawing.Size(45, 13);
            this.lblFaction.TabIndex = 8;
            this.lblFaction.Text = "Fraktion";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 470);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(189, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(57, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtKeywords);
            this.groupBox1.Controls.Add(this.lblKeywords);
            this.groupBox1.Controls.Add(this.btnRemoveGear);
            this.groupBox1.Controls.Add(this.btnAddGear);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lbStandardGear);
            this.groupBox1.Controls.Add(this.cmbStandardGear);
            this.groupBox1.Controls.Add(this.txtSave);
            this.groupBox1.Controls.Add(this.txtLeadership);
            this.groupBox1.Controls.Add(this.txtAttacks);
            this.groupBox1.Controls.Add(this.txtWounds);
            this.groupBox1.Controls.Add(this.txtToughness);
            this.groupBox1.Controls.Add(this.txtStrength);
            this.groupBox1.Controls.Add(this.txtBs);
            this.groupBox1.Controls.Add(this.txtWs);
            this.groupBox1.Controls.Add(this.txtMovement);
            this.groupBox1.Controls.Add(this.txtAbilities);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.lblModelName);
            this.groupBox1.Controls.Add(this.lblModelFaction);
            this.groupBox1.Controls.Add(this.cmbModelFaction);
            this.groupBox1.Controls.Add(this.txtModelName);
            this.groupBox1.Location = new System.Drawing.Point(273, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 439);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modell Bearbeiten";
            // 
            // txtKeywords
            // 
            this.txtKeywords.Location = new System.Drawing.Point(71, 267);
            this.txtKeywords.Name = "txtKeywords";
            this.txtKeywords.Size = new System.Drawing.Size(186, 20);
            this.txtKeywords.TabIndex = 13;
            this.txtKeywords.TextChanged += new System.EventHandler(this.txtKeywords_TextChanged);
            // 
            // lblKeywords
            // 
            this.lblKeywords.AutoSize = true;
            this.lblKeywords.Location = new System.Drawing.Point(12, 270);
            this.lblKeywords.Name = "lblKeywords";
            this.lblKeywords.Size = new System.Drawing.Size(53, 13);
            this.lblKeywords.TabIndex = 20;
            this.lblKeywords.Text = "Keywords";
            // 
            // btnRemoveGear
            // 
            this.btnRemoveGear.Location = new System.Drawing.Point(205, 323);
            this.btnRemoveGear.Name = "btnRemoveGear";
            this.btnRemoveGear.Size = new System.Drawing.Size(23, 23);
            this.btnRemoveGear.TabIndex = 17;
            this.btnRemoveGear.Text = "-";
            this.btnRemoveGear.UseVisualStyleBackColor = true;
            this.btnRemoveGear.Click += new System.EventHandler(this.btnRemoveGear_Click);
            // 
            // btnAddGear
            // 
            this.btnAddGear.Location = new System.Drawing.Point(234, 323);
            this.btnAddGear.Name = "btnAddGear";
            this.btnAddGear.Size = new System.Drawing.Size(23, 23);
            this.btnAddGear.TabIndex = 15;
            this.btnAddGear.Text = "+";
            this.btnAddGear.UseVisualStyleBackColor = true;
            this.btnAddGear.Click += new System.EventHandler(this.btnAddGear_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Standard Waffen, Wargear...";
            // 
            // lbStandardGear
            // 
            this.lbStandardGear.FormattingEnabled = true;
            this.lbStandardGear.Location = new System.Drawing.Point(12, 352);
            this.lbStandardGear.Name = "lbStandardGear";
            this.lbStandardGear.Size = new System.Drawing.Size(245, 82);
            this.lbStandardGear.TabIndex = 16;
            this.lbStandardGear.SelectedIndexChanged += new System.EventHandler(this.lbStandardGear_SelectedIndexChanged);
            // 
            // cmbStandardGear
            // 
            this.cmbStandardGear.FormattingEnabled = true;
            this.cmbStandardGear.Location = new System.Drawing.Point(12, 325);
            this.cmbStandardGear.Name = "cmbStandardGear";
            this.cmbStandardGear.Size = new System.Drawing.Size(179, 21);
            this.cmbStandardGear.TabIndex = 14;
            this.cmbStandardGear.SelectedIndexChanged += new System.EventHandler(this.cmbStandardGear_SelectedIndexChanged);
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(221, 138);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(36, 20);
            this.txtSave.TabIndex = 11;
            this.txtSave.TextChanged += new System.EventHandler(this.txtSave_TextChanged);
            // 
            // txtLeadership
            // 
            this.txtLeadership.Location = new System.Drawing.Point(161, 138);
            this.txtLeadership.Name = "txtLeadership";
            this.txtLeadership.Size = new System.Drawing.Size(41, 20);
            this.txtLeadership.TabIndex = 10;
            this.txtLeadership.TextChanged += new System.EventHandler(this.txtLeadership_TextChanged);
            // 
            // txtAttacks
            // 
            this.txtAttacks.Location = new System.Drawing.Point(94, 138);
            this.txtAttacks.Name = "txtAttacks";
            this.txtAttacks.Size = new System.Drawing.Size(50, 20);
            this.txtAttacks.TabIndex = 9;
            this.txtAttacks.TextChanged += new System.EventHandler(this.txtAttacks_TextChanged);
            // 
            // txtWounds
            // 
            this.txtWounds.Location = new System.Drawing.Point(54, 138);
            this.txtWounds.Name = "txtWounds";
            this.txtWounds.Size = new System.Drawing.Size(34, 20);
            this.txtWounds.TabIndex = 8;
            this.txtWounds.TextChanged += new System.EventHandler(this.txtWounds_TextChanged);
            // 
            // txtToughness
            // 
            this.txtToughness.Location = new System.Drawing.Point(12, 138);
            this.txtToughness.Name = "txtToughness";
            this.txtToughness.Size = new System.Drawing.Size(36, 20);
            this.txtToughness.TabIndex = 7;
            this.txtToughness.TextChanged += new System.EventHandler(this.txtToughness_TextChanged);
            // 
            // txtStrength
            // 
            this.txtStrength.Location = new System.Drawing.Point(190, 98);
            this.txtStrength.Name = "txtStrength";
            this.txtStrength.Size = new System.Drawing.Size(38, 20);
            this.txtStrength.TabIndex = 6;
            this.txtStrength.TextChanged += new System.EventHandler(this.txtStrength_TextChanged);
            // 
            // txtBs
            // 
            this.txtBs.Location = new System.Drawing.Point(133, 98);
            this.txtBs.Name = "txtBs";
            this.txtBs.Size = new System.Drawing.Size(44, 20);
            this.txtBs.TabIndex = 5;
            this.txtBs.TextChanged += new System.EventHandler(this.txtBs_TextChanged);
            // 
            // txtWs
            // 
            this.txtWs.Location = new System.Drawing.Point(84, 98);
            this.txtWs.Name = "txtWs";
            this.txtWs.Size = new System.Drawing.Size(43, 20);
            this.txtWs.TabIndex = 4;
            this.txtWs.TextChanged += new System.EventHandler(this.txtWs_TextChanged);
            // 
            // txtMovement
            // 
            this.txtMovement.Location = new System.Drawing.Point(12, 98);
            this.txtMovement.Name = "txtMovement";
            this.txtMovement.Size = new System.Drawing.Size(62, 20);
            this.txtMovement.TabIndex = 3;
            this.txtMovement.TextChanged += new System.EventHandler(this.txtMovement_TextChanged);
            // 
            // txtAbilities
            // 
            this.txtAbilities.Location = new System.Drawing.Point(12, 195);
            this.txtAbilities.Multiline = true;
            this.txtAbilities.Name = "txtAbilities";
            this.txtAbilities.Size = new System.Drawing.Size(245, 58);
            this.txtAbilities.TabIndex = 12;
            this.txtAbilities.TextChanged += new System.EventHandler(this.txtAbilities_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Custom Rules";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(218, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Sv";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ld";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "W";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "T";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "S";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "BS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "WS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "M";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(208, 19);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(49, 47);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblModelName
            // 
            this.lblModelName.AutoSize = true;
            this.lblModelName.Location = new System.Drawing.Point(6, 49);
            this.lblModelName.Name = "lblModelName";
            this.lblModelName.Size = new System.Drawing.Size(35, 13);
            this.lblModelName.TabIndex = 3;
            this.lblModelName.Text = "Name";
            // 
            // lblModelFaction
            // 
            this.lblModelFaction.AutoSize = true;
            this.lblModelFaction.Location = new System.Drawing.Point(6, 22);
            this.lblModelFaction.Name = "lblModelFaction";
            this.lblModelFaction.Size = new System.Drawing.Size(45, 13);
            this.lblModelFaction.TabIndex = 2;
            this.lblModelFaction.Text = "Fraktion";
            // 
            // cmbModelFaction
            // 
            this.cmbModelFaction.Enabled = false;
            this.cmbModelFaction.FormattingEnabled = true;
            this.cmbModelFaction.Location = new System.Drawing.Point(56, 19);
            this.cmbModelFaction.Name = "cmbModelFaction";
            this.cmbModelFaction.Size = new System.Drawing.Size(146, 21);
            this.cmbModelFaction.TabIndex = 0;
            this.cmbModelFaction.SelectedIndexChanged += new System.EventHandler(this.cmbModelFaction_SelectedIndexChanged);
            // 
            // txtModelName
            // 
            this.txtModelName.Enabled = false;
            this.txtModelName.Location = new System.Drawing.Point(56, 46);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(146, 20);
            this.txtModelName.TabIndex = 1;
            this.txtModelName.TextChanged += new System.EventHandler(this.txtModelName_TextChanged);
            // 
            // DialogMinis
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(548, 551);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblFaction);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbFaction);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbMinis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "DialogMinis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vorlagen für Modelle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DialogMinis_FormClosing);
            this.Load += new System.EventHandler(this.DialogMinis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMinis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ComboBox cmbFaction;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblFaction;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.Label lblModelFaction;
        private System.Windows.Forms.ComboBox cmbModelFaction;
        private System.Windows.Forms.Label lblModelName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAbilities;
        private System.Windows.Forms.TextBox txtToughness;
        private System.Windows.Forms.TextBox txtStrength;
        private System.Windows.Forms.TextBox txtBs;
        private System.Windows.Forms.TextBox txtWs;
        private System.Windows.Forms.TextBox txtMovement;
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.TextBox txtLeadership;
        private System.Windows.Forms.TextBox txtAttacks;
        private System.Windows.Forms.TextBox txtWounds;
        private System.Windows.Forms.ComboBox cmbStandardGear;
        private System.Windows.Forms.ListBox lbStandardGear;
        private System.Windows.Forms.Button btnAddGear;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRemoveGear;
        private System.Windows.Forms.Label lblKeywords;
        private System.Windows.Forms.TextBox txtKeywords;
    }
}