namespace WHSAArmyPlanner.Forms
{
    partial class DialogItems
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
            this.clbSelection = new System.Windows.Forms.CheckedListBox();
            this.txtSearchtext = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpEditItem = new System.Windows.Forms.GroupBox();
            this.txtExtraText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numMatchPoints = new System.Windows.Forms.NumericUpDown();
            this.grpbxMelee = new System.Windows.Forms.GroupBox();
            this.txtMeleeAbility = new System.Windows.Forms.TextBox();
            this.txtMeleeDamage = new System.Windows.Forms.TextBox();
            this.txtMeleeAp = new System.Windows.Forms.TextBox();
            this.txtMeleeStrength = new System.Windows.Forms.TextBox();
            this.txtMeleeType = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.grpRangedCombat = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRangedAbility = new System.Windows.Forms.TextBox();
            this.txtRangedDamage = new System.Windows.Forms.TextBox();
            this.txtRangedAp = new System.Windows.Forms.TextBox();
            this.txtRangedStrength = new System.Windows.Forms.TextBox();
            this.txtRangedType = new System.Windows.Forms.TextBox();
            this.txtRange = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtSelectedName = new System.Windows.Forms.TextBox();
            this.cmbSeletedFaction = new System.Windows.Forms.ComboBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.cbSelectAll = new System.Windows.Forms.CheckBox();
            this.btnResetSelection = new System.Windows.Forms.Button();
            this.cmbFaction = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpEditItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMatchPoints)).BeginInit();
            this.grpbxMelee.SuspendLayout();
            this.grpRangedCombat.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbSelection
            // 
            this.clbSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbSelection.FormattingEnabled = true;
            this.clbSelection.Location = new System.Drawing.Point(12, 75);
            this.clbSelection.Name = "clbSelection";
            this.clbSelection.Size = new System.Drawing.Size(262, 289);
            this.clbSelection.TabIndex = 2;
            this.clbSelection.SelectedIndexChanged += new System.EventHandler(this.clbSelection_SelectedIndexChanged);
            // 
            // txtSearchtext
            // 
            this.txtSearchtext.Location = new System.Drawing.Point(50, 16);
            this.txtSearchtext.Name = "txtSearchtext";
            this.txtSearchtext.Size = new System.Drawing.Size(143, 20);
            this.txtSearchtext.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WHSAArmyPlanner.Properties.Resources.Lupe;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 34);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(199, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpEditItem
            // 
            this.grpEditItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEditItem.Controls.Add(this.txtExtraText);
            this.grpEditItem.Controls.Add(this.label4);
            this.grpEditItem.Controls.Add(this.label3);
            this.grpEditItem.Controls.Add(this.numMatchPoints);
            this.grpEditItem.Controls.Add(this.grpbxMelee);
            this.grpEditItem.Controls.Add(this.grpRangedCombat);
            this.grpEditItem.Controls.Add(this.btnEdit);
            this.grpEditItem.Controls.Add(this.txtSelectedName);
            this.grpEditItem.Controls.Add(this.cmbSeletedFaction);
            this.grpEditItem.Location = new System.Drawing.Point(305, 16);
            this.grpEditItem.Name = "grpEditItem";
            this.grpEditItem.Size = new System.Drawing.Size(348, 402);
            this.grpEditItem.TabIndex = 7;
            this.grpEditItem.TabStop = false;
            this.grpEditItem.Text = "Auswahl bearbeiten";
            // 
            // txtExtraText
            // 
            this.txtExtraText.Location = new System.Drawing.Point(74, 94);
            this.txtExtraText.Multiline = true;
            this.txtExtraText.Name = "txtExtraText";
            this.txtExtraText.Size = new System.Drawing.Size(268, 38);
            this.txtExtraText.TabIndex = 4;
            this.txtExtraText.TextChanged += new System.EventHandler(this.txtExtraText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sondertext";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Punktkosten (Matched Game)";
            // 
            // numMatchPoints
            // 
            this.numMatchPoints.Location = new System.Drawing.Point(161, 64);
            this.numMatchPoints.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMatchPoints.Name = "numMatchPoints";
            this.numMatchPoints.Size = new System.Drawing.Size(57, 20);
            this.numMatchPoints.TabIndex = 3;
            this.numMatchPoints.ValueChanged += new System.EventHandler(this.numMatchPoints_ValueChanged);
            // 
            // grpbxMelee
            // 
            this.grpbxMelee.Controls.Add(this.txtMeleeAbility);
            this.grpbxMelee.Controls.Add(this.txtMeleeDamage);
            this.grpbxMelee.Controls.Add(this.txtMeleeAp);
            this.grpbxMelee.Controls.Add(this.txtMeleeStrength);
            this.grpbxMelee.Controls.Add(this.txtMeleeType);
            this.grpbxMelee.Controls.Add(this.label11);
            this.grpbxMelee.Controls.Add(this.label14);
            this.grpbxMelee.Controls.Add(this.label12);
            this.grpbxMelee.Controls.Add(this.label15);
            this.grpbxMelee.Controls.Add(this.label13);
            this.grpbxMelee.Location = new System.Drawing.Point(13, 278);
            this.grpbxMelee.Name = "grpbxMelee";
            this.grpbxMelee.Size = new System.Drawing.Size(335, 97);
            this.grpbxMelee.TabIndex = 4;
            this.grpbxMelee.TabStop = false;
            this.grpbxMelee.Text = "Nahmkampf-Profil";
            // 
            // txtMeleeAbility
            // 
            this.txtMeleeAbility.Location = new System.Drawing.Point(83, 67);
            this.txtMeleeAbility.Name = "txtMeleeAbility";
            this.txtMeleeAbility.Size = new System.Drawing.Size(231, 20);
            this.txtMeleeAbility.TabIndex = 23;
            this.txtMeleeAbility.TextChanged += new System.EventHandler(this.txtMeleeAbility_TextChanged);
            // 
            // txtMeleeDamage
            // 
            this.txtMeleeDamage.Location = new System.Drawing.Point(190, 40);
            this.txtMeleeDamage.Name = "txtMeleeDamage";
            this.txtMeleeDamage.Size = new System.Drawing.Size(124, 20);
            this.txtMeleeDamage.TabIndex = 22;
            this.txtMeleeDamage.TextChanged += new System.EventHandler(this.txtMeleeDamage_TextChanged);
            // 
            // txtMeleeAp
            // 
            this.txtMeleeAp.Location = new System.Drawing.Point(148, 41);
            this.txtMeleeAp.Name = "txtMeleeAp";
            this.txtMeleeAp.Size = new System.Drawing.Size(28, 20);
            this.txtMeleeAp.TabIndex = 21;
            this.txtMeleeAp.TextChanged += new System.EventHandler(this.txtMeleeAp_TextChanged);
            // 
            // txtMeleeStrength
            // 
            this.txtMeleeStrength.Location = new System.Drawing.Point(83, 41);
            this.txtMeleeStrength.Name = "txtMeleeStrength";
            this.txtMeleeStrength.Size = new System.Drawing.Size(49, 20);
            this.txtMeleeStrength.TabIndex = 20;
            this.txtMeleeStrength.TextChanged += new System.EventHandler(this.txtMeleeStrength_TextChanged);
            // 
            // txtMeleeType
            // 
            this.txtMeleeType.Location = new System.Drawing.Point(7, 41);
            this.txtMeleeType.Name = "txtMeleeType";
            this.txtMeleeType.Size = new System.Drawing.Size(62, 20);
            this.txtMeleeType.TabIndex = 19;
            this.txtMeleeType.TextChanged += new System.EventHandler(this.txtMeleeType_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Ability";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(187, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "D";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(80, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "S";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(146, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "AP";
            // 
            // grpRangedCombat
            // 
            this.grpRangedCombat.Controls.Add(this.label10);
            this.grpRangedCombat.Controls.Add(this.txtRangedAbility);
            this.grpRangedCombat.Controls.Add(this.txtRangedDamage);
            this.grpRangedCombat.Controls.Add(this.txtRangedAp);
            this.grpRangedCombat.Controls.Add(this.txtRangedStrength);
            this.grpRangedCombat.Controls.Add(this.txtRangedType);
            this.grpRangedCombat.Controls.Add(this.txtRange);
            this.grpRangedCombat.Controls.Add(this.label9);
            this.grpRangedCombat.Controls.Add(this.label8);
            this.grpRangedCombat.Controls.Add(this.label6);
            this.grpRangedCombat.Controls.Add(this.label7);
            this.grpRangedCombat.Controls.Add(this.label5);
            this.grpRangedCombat.Location = new System.Drawing.Point(9, 166);
            this.grpRangedCombat.Name = "grpRangedCombat";
            this.grpRangedCombat.Size = new System.Drawing.Size(335, 106);
            this.grpRangedCombat.TabIndex = 3;
            this.grpRangedCombat.TabStop = false;
            this.grpRangedCombat.Text = "Fernkampf- Profil";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Ability";
            // 
            // txtRangedAbility
            // 
            this.txtRangedAbility.Location = new System.Drawing.Point(65, 70);
            this.txtRangedAbility.Name = "txtRangedAbility";
            this.txtRangedAbility.Size = new System.Drawing.Size(253, 20);
            this.txtRangedAbility.TabIndex = 12;
            this.txtRangedAbility.TextChanged += new System.EventHandler(this.txtRangedAbility_TextChanged);
            // 
            // txtRangedDamage
            // 
            this.txtRangedDamage.Location = new System.Drawing.Point(246, 44);
            this.txtRangedDamage.Name = "txtRangedDamage";
            this.txtRangedDamage.Size = new System.Drawing.Size(72, 20);
            this.txtRangedDamage.TabIndex = 11;
            this.txtRangedDamage.TextChanged += new System.EventHandler(this.txtRangedDamage_TextChanged);
            // 
            // txtRangedAp
            // 
            this.txtRangedAp.Location = new System.Drawing.Point(205, 44);
            this.txtRangedAp.Name = "txtRangedAp";
            this.txtRangedAp.Size = new System.Drawing.Size(28, 20);
            this.txtRangedAp.TabIndex = 10;
            this.txtRangedAp.TextChanged += new System.EventHandler(this.txtRangedAp_TextChanged);
            // 
            // txtRangedStrength
            // 
            this.txtRangedStrength.Location = new System.Drawing.Point(139, 44);
            this.txtRangedStrength.Name = "txtRangedStrength";
            this.txtRangedStrength.Size = new System.Drawing.Size(49, 20);
            this.txtRangedStrength.TabIndex = 9;
            this.txtRangedStrength.TextChanged += new System.EventHandler(this.txtRangedStrength_TextChanged);
            // 
            // txtRangedType
            // 
            this.txtRangedType.Location = new System.Drawing.Point(65, 44);
            this.txtRangedType.Name = "txtRangedType";
            this.txtRangedType.Size = new System.Drawing.Size(62, 20);
            this.txtRangedType.TabIndex = 8;
            this.txtRangedType.TextChanged += new System.EventHandler(this.txtRangedType_TextChanged);
            // 
            // txtRange
            // 
            this.txtRange.Location = new System.Drawing.Point(11, 44);
            this.txtRange.Name = "txtRange";
            this.txtRange.Size = new System.Drawing.Size(44, 20);
            this.txtRange.TabIndex = 7;
            this.txtRange.TextChanged += new System.EventHandler(this.txtRange_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(243, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "D";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(202, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "AP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(136, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "S";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Range";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(294, 30);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(48, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtSelectedName
            // 
            this.txtSelectedName.Enabled = false;
            this.txtSelectedName.Location = new System.Drawing.Point(142, 32);
            this.txtSelectedName.Name = "txtSelectedName";
            this.txtSelectedName.Size = new System.Drawing.Size(146, 20);
            this.txtSelectedName.TabIndex = 1;
            this.txtSelectedName.TextChanged += new System.EventHandler(this.txtSelectedName_TextChanged);
            // 
            // cmbSeletedFaction
            // 
            this.cmbSeletedFaction.Enabled = false;
            this.cmbSeletedFaction.FormattingEnabled = true;
            this.cmbSeletedFaction.Location = new System.Drawing.Point(6, 32);
            this.cmbSeletedFaction.Name = "cmbSeletedFaction";
            this.cmbSeletedFaction.Size = new System.Drawing.Size(130, 21);
            this.cmbSeletedFaction.TabIndex = 0;
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtInput.Location = new System.Drawing.Point(71, 397);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(122, 20);
            this.txtInput.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(247, 395);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(27, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Location = new System.Drawing.Point(214, 395);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(27, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Location = new System.Drawing.Point(12, 443);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 41);
            this.panel1.TabIndex = 8;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(472, 11);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(86, 23);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Übernehmen";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(371, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(564, 11);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cbSelectAll
            // 
            this.cbSelectAll.AutoSize = true;
            this.cbSelectAll.Location = new System.Drawing.Point(13, 52);
            this.cbSelectAll.Name = "cbSelectAll";
            this.cbSelectAll.Size = new System.Drawing.Size(97, 17);
            this.cbSelectAll.TabIndex = 9;
            this.cbSelectAll.Text = "Alle auswählen";
            this.cbSelectAll.UseVisualStyleBackColor = true;
            this.cbSelectAll.Visible = false;
            // 
            // btnResetSelection
            // 
            this.btnResetSelection.Location = new System.Drawing.Point(154, 46);
            this.btnResetSelection.Name = "btnResetSelection";
            this.btnResetSelection.Size = new System.Drawing.Size(120, 23);
            this.btnResetSelection.TabIndex = 10;
            this.btnResetSelection.Text = "Auswahl rücksetzen";
            this.btnResetSelection.UseVisualStyleBackColor = true;
            this.btnResetSelection.Visible = false;
            // 
            // cmbFaction
            // 
            this.cmbFaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbFaction.FormattingEnabled = true;
            this.cmbFaction.Location = new System.Drawing.Point(71, 370);
            this.cmbFaction.Name = "cmbFaction";
            this.cmbFaction.Size = new System.Drawing.Size(122, 21);
            this.cmbFaction.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fraktion";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name";
            // 
            // DialogItems
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(665, 494);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResetSelection);
            this.Controls.Add(this.cmbFaction);
            this.Controls.Add(this.cbSelectAll);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.grpEditItem);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearchtext);
            this.Controls.Add(this.clbSelection);
            this.MinimumSize = new System.Drawing.Size(681, 533);
            this.Name = "DialogItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vorlagen für Waffen. Ausrüstung, Wargear...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DialogItems_FormClosing);
            this.Load += new System.EventHandler(this.DialogItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpEditItem.ResumeLayout(false);
            this.grpEditItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMatchPoints)).EndInit();
            this.grpbxMelee.ResumeLayout(false);
            this.grpbxMelee.PerformLayout();
            this.grpRangedCombat.ResumeLayout(false);
            this.grpRangedCombat.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbSelection;
        private System.Windows.Forms.TextBox txtSearchtext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpEditItem;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbSelectAll;
        private System.Windows.Forms.Button btnResetSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFaction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtSelectedName;
        private System.Windows.Forms.ComboBox cmbSeletedFaction;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox grpbxMelee;
        private System.Windows.Forms.GroupBox grpRangedCombat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numMatchPoints;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExtraText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRangedType;
        private System.Windows.Forms.TextBox txtRange;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRangedDamage;
        private System.Windows.Forms.TextBox txtRangedAp;
        private System.Windows.Forms.TextBox txtRangedStrength;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRangedAbility;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtMeleeDamage;
        private System.Windows.Forms.TextBox txtMeleeAp;
        private System.Windows.Forms.TextBox txtMeleeStrength;
        private System.Windows.Forms.TextBox txtMeleeType;
        private System.Windows.Forms.TextBox txtMeleeAbility;
    }
}