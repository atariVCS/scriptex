namespace WHSAArmyPlanner.Forms
{
    partial class DialogShareWithFriends
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
            this.txtImportedTemplates = new System.Windows.Forms.TextBox();
            this.btnSelectDirectory = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.lbImportedEntries = new System.Windows.Forms.ListBox();
            this.lbExistingTemplates = new System.Windows.Forms.ListBox();
            this.cmbTemplate = new System.Windows.Forms.ComboBox();
            this.cbDisplayNewOnly = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.grpUseTemplates = new System.Windows.Forms.GroupBox();
            this.lblSelectedTopic = new System.Windows.Forms.Label();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.grpDuplicateTemplates = new System.Windows.Forms.GroupBox();
            this.lblCurrentTemplatePath = new System.Windows.Forms.Label();
            this.lblCurrentTemplateCaption = new System.Windows.Forms.Label();
            this.btnExportTemplates = new System.Windows.Forms.Button();
            this.fbSearchTemplates = new System.Windows.Forms.FolderBrowserDialog();
            this.fbExportTemplates = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.grpUseTemplates.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.grpDuplicateTemplates.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kopierter Template Ordner (nicht deine Eigenen Templates):";
            // 
            // txtImportedTemplates
            // 
            this.txtImportedTemplates.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtImportedTemplates.Location = new System.Drawing.Point(300, 26);
            this.txtImportedTemplates.Name = "txtImportedTemplates";
            this.txtImportedTemplates.ReadOnly = true;
            this.txtImportedTemplates.Size = new System.Drawing.Size(232, 20);
            this.txtImportedTemplates.TabIndex = 0;
            // 
            // btnSelectDirectory
            // 
            this.btnSelectDirectory.Location = new System.Drawing.Point(538, 24);
            this.btnSelectDirectory.Name = "btnSelectDirectory";
            this.btnSelectDirectory.Size = new System.Drawing.Size(44, 23);
            this.btnSelectDirectory.TabIndex = 1;
            this.btnSelectDirectory.Text = "...";
            this.btnSelectDirectory.UseVisualStyleBackColor = true;
            this.btnSelectDirectory.Click += new System.EventHandler(this.btnSelectDirectory_Click);
            // 
            // btnGo
            // 
            this.btnGo.Enabled = false;
            this.btnGo.Location = new System.Drawing.Point(588, 24);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(44, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lbImportedEntries
            // 
            this.lbImportedEntries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbImportedEntries.Enabled = false;
            this.lbImportedEntries.FormattingEnabled = true;
            this.lbImportedEntries.Location = new System.Drawing.Point(6, 170);
            this.lbImportedEntries.Name = "lbImportedEntries";
            this.lbImportedEntries.Size = new System.Drawing.Size(247, 251);
            this.lbImportedEntries.TabIndex = 6;
            this.lbImportedEntries.SelectedIndexChanged += new System.EventHandler(this.lbImportedEntries_SelectedIndexChanged);
            // 
            // lbExistingTemplates
            // 
            this.lbExistingTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbExistingTemplates.Enabled = false;
            this.lbExistingTemplates.FormattingEnabled = true;
            this.lbExistingTemplates.Location = new System.Drawing.Point(403, 144);
            this.lbExistingTemplates.Name = "lbExistingTemplates";
            this.lbExistingTemplates.Size = new System.Drawing.Size(247, 277);
            this.lbExistingTemplates.TabIndex = 5;
            // 
            // cmbTemplate
            // 
            this.cmbTemplate.Enabled = false;
            this.cmbTemplate.FormattingEnabled = true;
            this.cmbTemplate.Location = new System.Drawing.Point(9, 77);
            this.cmbTemplate.Name = "cmbTemplate";
            this.cmbTemplate.Size = new System.Drawing.Size(213, 21);
            this.cmbTemplate.TabIndex = 3;
            this.cmbTemplate.SelectedIndexChanged += new System.EventHandler(this.cmbTemplate_SelectedIndexChanged);
            // 
            // cbDisplayNewOnly
            // 
            this.cbDisplayNewOnly.AutoSize = true;
            this.cbDisplayNewOnly.Enabled = false;
            this.cbDisplayNewOnly.Location = new System.Drawing.Point(100, 117);
            this.cbDisplayNewOnly.Name = "cbDisplayNewOnly";
            this.cbDisplayNewOnly.Size = new System.Drawing.Size(100, 17);
            this.cbDisplayNewOnly.TabIndex = 7;
            this.cbDisplayNewOnly.Text = "Zeige nur Neue";
            this.cbDisplayNewOnly.UseVisualStyleBackColor = true;
            this.cbDisplayNewOnly.CheckedChanged += new System.EventHandler(this.cmbDisplayNewOnly_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Template- Art auswählen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Importierte Daten";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vorhandene Daten";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(286, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Enabled = false;
            this.btnAddAll.Location = new System.Drawing.Point(286, 199);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(75, 23);
            this.btnAddAll.TabIndex = 8;
            this.btnAddAll.Text = "Alle >>";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Location = new System.Drawing.Point(12, 526);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 53);
            this.panel1.TabIndex = 13;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(678, 20);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(91, 23);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Übernehmen";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnCancel.Location = new System.Drawing.Point(575, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(775, 20);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // grpUseTemplates
            // 
            this.grpUseTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpUseTemplates.Controls.Add(this.lblSelectedTopic);
            this.grpUseTemplates.Controls.Add(this.grpDetails);
            this.grpUseTemplates.Controls.Add(this.btnFilter);
            this.grpUseTemplates.Controls.Add(this.txtFilter);
            this.grpUseTemplates.Controls.Add(this.label1);
            this.grpUseTemplates.Controls.Add(this.txtImportedTemplates);
            this.grpUseTemplates.Controls.Add(this.btnAddAll);
            this.grpUseTemplates.Controls.Add(this.btnSelectDirectory);
            this.grpUseTemplates.Controls.Add(this.btnAdd);
            this.grpUseTemplates.Controls.Add(this.btnGo);
            this.grpUseTemplates.Controls.Add(this.label4);
            this.grpUseTemplates.Controls.Add(this.label2);
            this.grpUseTemplates.Controls.Add(this.label3);
            this.grpUseTemplates.Controls.Add(this.lbImportedEntries);
            this.grpUseTemplates.Controls.Add(this.lbExistingTemplates);
            this.grpUseTemplates.Controls.Add(this.cbDisplayNewOnly);
            this.grpUseTemplates.Controls.Add(this.cmbTemplate);
            this.grpUseTemplates.Location = new System.Drawing.Point(12, 79);
            this.grpUseTemplates.Name = "grpUseTemplates";
            this.grpUseTemplates.Size = new System.Drawing.Size(865, 441);
            this.grpUseTemplates.TabIndex = 14;
            this.grpUseTemplates.TabStop = false;
            this.grpUseTemplates.Text = "Vorlagen aus anderem \"Template\" Ordner  lesen";
            // 
            // lblSelectedTopic
            // 
            this.lblSelectedTopic.AutoSize = true;
            this.lblSelectedTopic.Location = new System.Drawing.Point(504, 117);
            this.lblSelectedTopic.Name = "lblSelectedTopic";
            this.lblSelectedTopic.Size = new System.Drawing.Size(10, 13);
            this.lblSelectedTopic.TabIndex = 16;
            this.lblSelectedTopic.Text = "-";
            // 
            // grpDetails
            // 
            this.grpDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDetails.Controls.Add(this.txtDetails);
            this.grpDetails.Location = new System.Drawing.Point(671, 144);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(180, 277);
            this.grpDetails.TabIndex = 15;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Details / Vergleich";
            // 
            // txtDetails
            // 
            this.txtDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetails.BackColor = System.Drawing.Color.Cornsilk;
            this.txtDetails.Location = new System.Drawing.Point(7, 26);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ReadOnly = true;
            this.txtDetails.Size = new System.Drawing.Size(167, 245);
            this.txtDetails.TabIndex = 0;
            // 
            // btnFilter
            // 
            this.btnFilter.Enabled = false;
            this.btnFilter.Location = new System.Drawing.Point(178, 142);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // txtFilter
            // 
            this.txtFilter.Enabled = false;
            this.txtFilter.Location = new System.Drawing.Point(9, 144);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(140, 20);
            this.txtFilter.TabIndex = 4;
            // 
            // grpDuplicateTemplates
            // 
            this.grpDuplicateTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDuplicateTemplates.Controls.Add(this.lblCurrentTemplatePath);
            this.grpDuplicateTemplates.Controls.Add(this.lblCurrentTemplateCaption);
            this.grpDuplicateTemplates.Controls.Add(this.btnExportTemplates);
            this.grpDuplicateTemplates.Location = new System.Drawing.Point(12, 12);
            this.grpDuplicateTemplates.Name = "grpDuplicateTemplates";
            this.grpDuplicateTemplates.Size = new System.Drawing.Size(865, 50);
            this.grpDuplicateTemplates.TabIndex = 15;
            this.grpDuplicateTemplates.TabStop = false;
            this.grpDuplicateTemplates.Text = "Eigene Vorlagen weitergeben";
            // 
            // lblCurrentTemplatePath
            // 
            this.lblCurrentTemplatePath.AutoSize = true;
            this.lblCurrentTemplatePath.Location = new System.Drawing.Point(175, 24);
            this.lblCurrentTemplatePath.Name = "lblCurrentTemplatePath";
            this.lblCurrentTemplatePath.Size = new System.Drawing.Size(10, 13);
            this.lblCurrentTemplatePath.TabIndex = 2;
            this.lblCurrentTemplatePath.Text = "-";
            // 
            // lblCurrentTemplateCaption
            // 
            this.lblCurrentTemplateCaption.AutoSize = true;
            this.lblCurrentTemplateCaption.Location = new System.Drawing.Point(6, 24);
            this.lblCurrentTemplateCaption.Name = "lblCurrentTemplateCaption";
            this.lblCurrentTemplateCaption.Size = new System.Drawing.Size(157, 13);
            this.lblCurrentTemplateCaption.TabIndex = 1;
            this.lblCurrentTemplateCaption.Text = "Aktuelles Template-Verzeichnis:";
            // 
            // btnExportTemplates
            // 
            this.btnExportTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportTemplates.Location = new System.Drawing.Point(735, 19);
            this.btnExportTemplates.Name = "btnExportTemplates";
            this.btnExportTemplates.Size = new System.Drawing.Size(94, 23);
            this.btnExportTemplates.TabIndex = 0;
            this.btnExportTemplates.Text = "Exportieren...";
            this.btnExportTemplates.UseVisualStyleBackColor = true;
            this.btnExportTemplates.Click += new System.EventHandler(this.btnExportTemplates_Click);
            // 
            // DialogShareWithFriends
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(889, 591);
            this.Controls.Add(this.grpDuplicateTemplates);
            this.Controls.Add(this.grpUseTemplates);
            this.Controls.Add(this.panel1);
            this.Name = "DialogShareWithFriends";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ShareWithFriends";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DialogShareWithFriends_FormClosing);
            this.Load += new System.EventHandler(this.DialogShareWithFriends_Load);
            this.panel1.ResumeLayout(false);
            this.grpUseTemplates.ResumeLayout(false);
            this.grpUseTemplates.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.grpDuplicateTemplates.ResumeLayout(false);
            this.grpDuplicateTemplates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImportedTemplates;
        private System.Windows.Forms.Button btnSelectDirectory;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ListBox lbImportedEntries;
        private System.Windows.Forms.ListBox lbExistingTemplates;
        private System.Windows.Forms.ComboBox cmbTemplate;
        private System.Windows.Forms.CheckBox cbDisplayNewOnly;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox grpUseTemplates;
        private System.Windows.Forms.GroupBox grpDuplicateTemplates;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label lblCurrentTemplateCaption;
        private System.Windows.Forms.Button btnExportTemplates;
        private System.Windows.Forms.Label lblCurrentTemplatePath;
        private System.Windows.Forms.FolderBrowserDialog fbSearchTemplates;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblSelectedTopic;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.FolderBrowserDialog fbExportTemplates;
    }
}