namespace WHSAArmyPlanner
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lbDetachments = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArmyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panDetachment = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControlSlots = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblDetachmentCP = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDetachmentName = new System.Windows.Forms.Label();
            this.txtDetachmentSummary = new System.Windows.Forms.TextBox();
            this.tooltipGeneral = new System.Windows.Forms.ToolTip(this.components);
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neueListeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernUnterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ladenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.vorschauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportHTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fraktionslisteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.battlerolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detachmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einheitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelleMiniaturenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waffenAusrüstungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sonderregelnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überWHSAArmyPlannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.friendShareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOverallCommandPoints = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblOveralPowerlevel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblOverallPoints = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAddDetachment = new System.Windows.Forms.Button();
            this.panWelcome = new System.Windows.Forms.Panel();
            this.btnEditSettings = new System.Windows.Forms.Button();
            this.lblSettingsWarning = new System.Windows.Forms.Label();
            this.lblSettingsMessage = new System.Windows.Forms.Label();
            this.lblImportant = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblErrorText = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.saveFocDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFocFile = new System.Windows.Forms.OpenFileDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.lblLimitPowerlevel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblLimitPoints = new System.Windows.Forms.Label();
            this.txtValidationText = new System.Windows.Forms.TextBox();
            this.lblValidateIcon = new System.Windows.Forms.Label();
            this.lblErrorIcon = new System.Windows.Forms.Label();
            this.panDetachment.SuspendLayout();
            this.tabControlSlots.SuspendLayout();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDetachments
            // 
            this.lbDetachments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDetachments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetachments.FormattingEnabled = true;
            this.lbDetachments.ItemHeight = 16;
            this.lbDetachments.Location = new System.Drawing.Point(15, 185);
            this.lbDetachments.Name = "lbDetachments";
            this.lbDetachments.Size = new System.Drawing.Size(207, 372);
            this.lbDetachments.TabIndex = 2;
            this.tooltipGeneral.SetToolTip(this.lbDetachments, "Press \'+\' \'-\' to add / remove Detachments. \r\nClick on an entry to edit the detach" +
        "tment.");
            this.lbDetachments.SelectedIndexChanged += new System.EventHandler(this.lbDetachments_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(191, 569);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(31, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Location = new System.Drawing.Point(154, 570);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(31, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // txtArmyName
            // 
            this.txtArmyName.Location = new System.Drawing.Point(183, 32);
            this.txtArmyName.Name = "txtArmyName";
            this.txtArmyName.Size = new System.Drawing.Size(179, 20);
            this.txtArmyName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Detachments";
            this.tooltipGeneral.SetToolTip(this.label2, "Press \'+\' \'-\' to add / remove Detachments. ");
            // 
            // panDetachment
            // 
            this.panDetachment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panDetachment.BackColor = System.Drawing.Color.FloralWhite;
            this.panDetachment.Controls.Add(this.label3);
            this.panDetachment.Controls.Add(this.tabControlSlots);
            this.panDetachment.Controls.Add(this.lblDetachmentCP);
            this.panDetachment.Controls.Add(this.label4);
            this.panDetachment.Controls.Add(this.lblDetachmentName);
            this.panDetachment.Controls.Add(this.txtDetachmentSummary);
            this.panDetachment.Location = new System.Drawing.Point(228, 113);
            this.panDetachment.Name = "panDetachment";
            this.panDetachment.Size = new System.Drawing.Size(1026, 480);
            this.panDetachment.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(787, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Zusammenfassung:";
            // 
            // tabControlSlots
            // 
            this.tabControlSlots.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlSlots.Controls.Add(this.tabPage1);
            this.tabControlSlots.Controls.Add(this.tabPage2);
            this.tabControlSlots.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlSlots.HotTrack = true;
            this.tabControlSlots.Location = new System.Drawing.Point(9, 45);
            this.tabControlSlots.Name = "tabControlSlots";
            this.tabControlSlots.SelectedIndex = 0;
            this.tabControlSlots.Size = new System.Drawing.Size(771, 432);
            this.tabControlSlots.TabIndex = 0;
            this.tabControlSlots.SelectedIndexChanged += new System.EventHandler(this.tabControlSlots_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(763, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HQ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(763, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Troops";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblDetachmentCP
            // 
            this.lblDetachmentCP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDetachmentCP.AutoSize = true;
            this.lblDetachmentCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetachmentCP.Location = new System.Drawing.Point(921, 11);
            this.lblDetachmentCP.Name = "lblDetachmentCP";
            this.lblDetachmentCP.Size = new System.Drawing.Size(13, 17);
            this.lblDetachmentCP.TabIndex = 11;
            this.lblDetachmentCP.Text = "-";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(787, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Command Points";
            // 
            // lblDetachmentName
            // 
            this.lblDetachmentName.AutoSize = true;
            this.lblDetachmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetachmentName.Location = new System.Drawing.Point(5, 8);
            this.lblDetachmentName.Name = "lblDetachmentName";
            this.lblDetachmentName.Size = new System.Drawing.Size(158, 20);
            this.lblDetachmentName.TabIndex = 9;
            this.lblDetachmentName.Text = "Detachment Name";
            // 
            // txtDetachmentSummary
            // 
            this.txtDetachmentSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetachmentSummary.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtDetachmentSummary.Location = new System.Drawing.Point(786, 67);
            this.txtDetachmentSummary.Multiline = true;
            this.txtDetachmentSummary.Name = "txtDetachmentSummary";
            this.txtDetachmentSummary.ReadOnly = true;
            this.txtDetachmentSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetachmentSummary.Size = new System.Drawing.Size(237, 410);
            this.txtDetachmentSummary.TabIndex = 8;
            this.txtDetachmentSummary.TabStop = false;
            // 
            // tooltipGeneral
            // 
            this.tooltipGeneral.ToolTipTitle = "Help";
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.editorToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1264, 24);
            this.mainMenu.TabIndex = 11;
            this.mainMenu.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neueListeToolStripMenuItem,
            this.toolStripSeparator2,
            this.speichernToolStripMenuItem,
            this.speichernUnterToolStripMenuItem,
            this.toolStripSeparator5,
            this.ladenToolStripMenuItem,
            this.toolStripSeparator3,
            this.vorschauToolStripMenuItem,
            this.exportHTMLToolStripMenuItem,
            this.toolStripSeparator4,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dateiToolStripMenuItem.Text = "Liste";
            // 
            // neueListeToolStripMenuItem
            // 
            this.neueListeToolStripMenuItem.Name = "neueListeToolStripMenuItem";
            this.neueListeToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.neueListeToolStripMenuItem.Text = "Neue Liste...";
            this.neueListeToolStripMenuItem.Click += new System.EventHandler(this.neueListeToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(164, 6);
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.speichernToolStripMenuItem.Text = "Speichern";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
            // 
            // speichernUnterToolStripMenuItem
            // 
            this.speichernUnterToolStripMenuItem.Name = "speichernUnterToolStripMenuItem";
            this.speichernUnterToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.speichernUnterToolStripMenuItem.Text = "Speichern Unter...";
            this.speichernUnterToolStripMenuItem.Click += new System.EventHandler(this.speichernUnterToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(164, 6);
            // 
            // ladenToolStripMenuItem
            // 
            this.ladenToolStripMenuItem.Name = "ladenToolStripMenuItem";
            this.ladenToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ladenToolStripMenuItem.Text = "Öffnen...";
            this.ladenToolStripMenuItem.Click += new System.EventHandler(this.ladenToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(164, 6);
            // 
            // vorschauToolStripMenuItem
            // 
            this.vorschauToolStripMenuItem.Name = "vorschauToolStripMenuItem";
            this.vorschauToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.vorschauToolStripMenuItem.Text = "Ansehen (Text)";
            this.vorschauToolStripMenuItem.Click += new System.EventHandler(this.vorschauToolStripMenuItem_Click);
            // 
            // exportHTMLToolStripMenuItem
            // 
            this.exportHTMLToolStripMenuItem.Name = "exportHTMLToolStripMenuItem";
            this.exportHTMLToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exportHTMLToolStripMenuItem.Text = "Ansehen (HTML)";
            this.exportHTMLToolStripMenuItem.Click += new System.EventHandler(this.exportHTMLToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(164, 6);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // editorToolStripMenuItem
            // 
            this.editorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fraktionslisteToolStripMenuItem,
            this.battlerolsToolStripMenuItem,
            this.detachmentsToolStripMenuItem,
            this.einheitenToolStripMenuItem,
            this.modelleMiniaturenToolStripMenuItem,
            this.waffenAusrüstungToolStripMenuItem,
            this.sonderregelnToolStripMenuItem,
            this.toolStripSeparator1,
            this.einstellungenToolStripMenuItem});
            this.editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            this.editorToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.editorToolStripMenuItem.Text = "Editor";
            // 
            // fraktionslisteToolStripMenuItem
            // 
            this.fraktionslisteToolStripMenuItem.Name = "fraktionslisteToolStripMenuItem";
            this.fraktionslisteToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.fraktionslisteToolStripMenuItem.Text = "Fraktionsliste";
            this.fraktionslisteToolStripMenuItem.Click += new System.EventHandler(this.fraktionslisteToolStripMenuItem_Click);
            // 
            // battlerolsToolStripMenuItem
            // 
            this.battlerolsToolStripMenuItem.Name = "battlerolsToolStripMenuItem";
            this.battlerolsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.battlerolsToolStripMenuItem.Text = "Battleroles";
            this.battlerolsToolStripMenuItem.Click += new System.EventHandler(this.battlerolsToolStripMenuItem_Click);
            // 
            // detachmentsToolStripMenuItem
            // 
            this.detachmentsToolStripMenuItem.Name = "detachmentsToolStripMenuItem";
            this.detachmentsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.detachmentsToolStripMenuItem.Text = "Detachments";
            this.detachmentsToolStripMenuItem.Click += new System.EventHandler(this.detachmentsToolStripMenuItem_Click);
            // 
            // einheitenToolStripMenuItem
            // 
            this.einheitenToolStripMenuItem.Name = "einheitenToolStripMenuItem";
            this.einheitenToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.einheitenToolStripMenuItem.Text = "Einheiten";
            this.einheitenToolStripMenuItem.Click += new System.EventHandler(this.einheitenToolStripMenuItem_Click);
            // 
            // modelleMiniaturenToolStripMenuItem
            // 
            this.modelleMiniaturenToolStripMenuItem.Name = "modelleMiniaturenToolStripMenuItem";
            this.modelleMiniaturenToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.modelleMiniaturenToolStripMenuItem.Text = "Modelle / Miniaturen";
            this.modelleMiniaturenToolStripMenuItem.Click += new System.EventHandler(this.modelleMiniaturenToolStripMenuItem_Click);
            // 
            // waffenAusrüstungToolStripMenuItem
            // 
            this.waffenAusrüstungToolStripMenuItem.Name = "waffenAusrüstungToolStripMenuItem";
            this.waffenAusrüstungToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.waffenAusrüstungToolStripMenuItem.Text = "Waffen  Ausrüstung";
            this.waffenAusrüstungToolStripMenuItem.Click += new System.EventHandler(this.waffenAusrüstungToolStripMenuItem_Click);
            // 
            // sonderregelnToolStripMenuItem
            // 
            this.sonderregelnToolStripMenuItem.Enabled = false;
            this.sonderregelnToolStripMenuItem.Name = "sonderregelnToolStripMenuItem";
            this.sonderregelnToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.sonderregelnToolStripMenuItem.Text = "Sonderregeln";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            this.einstellungenToolStripMenuItem.Click += new System.EventHandler(this.einstellungenToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.überWHSAArmyPlannerToolStripMenuItem,
            this.friendShareToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.hilfeToolStripMenuItem.Text = "Extras";
            // 
            // überWHSAArmyPlannerToolStripMenuItem
            // 
            this.überWHSAArmyPlannerToolStripMenuItem.Name = "überWHSAArmyPlannerToolStripMenuItem";
            this.überWHSAArmyPlannerToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.überWHSAArmyPlannerToolStripMenuItem.Text = "Über Scriptorum Exercitus";
            this.überWHSAArmyPlannerToolStripMenuItem.Click += new System.EventHandler(this.überWHSAArmyPlannerToolStripMenuItem_Click);
            // 
            // friendShareToolStripMenuItem
            // 
            this.friendShareToolStripMenuItem.Name = "friendShareToolStripMenuItem";
            this.friendShareToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.friendShareToolStripMenuItem.Text = "ShareWithFriends";
            this.friendShareToolStripMenuItem.Click += new System.EventHandler(this.friendShareToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Deine Armee:";
            // 
            // lblOverallCommandPoints
            // 
            this.lblOverallCommandPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverallCommandPoints.Location = new System.Drawing.Point(459, 36);
            this.lblOverallCommandPoints.Name = "lblOverallCommandPoints";
            this.lblOverallCommandPoints.Size = new System.Drawing.Size(27, 18);
            this.lblOverallCommandPoints.TabIndex = 13;
            this.lblOverallCommandPoints.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(368, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Commandpoints:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(513, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Powerlevel:";
            // 
            // lblOveralPowerlevel
            // 
            this.lblOveralPowerlevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOveralPowerlevel.Location = new System.Drawing.Point(581, 34);
            this.lblOveralPowerlevel.Name = "lblOveralPowerlevel";
            this.lblOveralPowerlevel.Size = new System.Drawing.Size(31, 20);
            this.lblOveralPowerlevel.TabIndex = 16;
            this.lblOveralPowerlevel.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(710, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Matched Punkte: ";
            // 
            // lblOverallPoints
            // 
            this.lblOverallPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverallPoints.Location = new System.Drawing.Point(808, 34);
            this.lblOverallPoints.Name = "lblOverallPoints";
            this.lblOverallPoints.Size = new System.Drawing.Size(100, 17);
            this.lblOverallPoints.TabIndex = 18;
            this.lblOverallPoints.Text = "-";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnAddDetachment
            // 
            this.btnAddDetachment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDetachment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDetachment.Location = new System.Drawing.Point(16, 140);
            this.btnAddDetachment.Name = "btnAddDetachment";
            this.btnAddDetachment.Size = new System.Drawing.Size(206, 31);
            this.btnAddDetachment.TabIndex = 1;
            this.btnAddDetachment.Text = "Detachment hinzufügen";
            this.btnAddDetachment.UseVisualStyleBackColor = true;
            this.btnAddDetachment.Click += new System.EventHandler(this.btnAddDetachment_Click);
            // 
            // panWelcome
            // 
            this.panWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panWelcome.Controls.Add(this.btnEditSettings);
            this.panWelcome.Controls.Add(this.lblSettingsWarning);
            this.panWelcome.Controls.Add(this.lblSettingsMessage);
            this.panWelcome.Controls.Add(this.lblImportant);
            this.panWelcome.Controls.Add(this.lblWelcome);
            this.panWelcome.Location = new System.Drawing.Point(145, 31);
            this.panWelcome.Name = "panWelcome";
            this.panWelcome.Size = new System.Drawing.Size(1062, 66);
            this.panWelcome.TabIndex = 24;
            this.panWelcome.Visible = false;
            // 
            // btnEditSettings
            // 
            this.btnEditSettings.Location = new System.Drawing.Point(913, 31);
            this.btnEditSettings.Name = "btnEditSettings";
            this.btnEditSettings.Size = new System.Drawing.Size(101, 23);
            this.btnEditSettings.TabIndex = 4;
            this.btnEditSettings.Text = "Einstellungen";
            this.btnEditSettings.UseVisualStyleBackColor = true;
            this.btnEditSettings.Visible = false;
            this.btnEditSettings.Click += new System.EventHandler(this.btnEditSettings_Click);
            // 
            // lblSettingsWarning
            // 
            this.lblSettingsWarning.Image = global::WHSAArmyPlanner.Properties.Resources.Attenschen;
            this.lblSettingsWarning.Location = new System.Drawing.Point(3, 31);
            this.lblSettingsWarning.Name = "lblSettingsWarning";
            this.lblSettingsWarning.Size = new System.Drawing.Size(26, 23);
            this.lblSettingsWarning.TabIndex = 3;
            this.lblSettingsWarning.Text = "   ";
            this.lblSettingsWarning.Visible = false;
            // 
            // lblSettingsMessage
            // 
            this.lblSettingsMessage.AutoSize = true;
            this.lblSettingsMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsMessage.Location = new System.Drawing.Point(108, 34);
            this.lblSettingsMessage.Name = "lblSettingsMessage";
            this.lblSettingsMessage.Size = new System.Drawing.Size(722, 16);
            this.lblSettingsMessage.TabIndex = 2;
            this.lblSettingsMessage.Text = "Es ist noch keine Grundeinstellung vorhanden. Bitte leg diese im Menü \"Editor\" un" +
    "ter \"Einstellungen\" fest. Oder gleich hier:\r\n";
            this.lblSettingsMessage.Visible = false;
            // 
            // lblImportant
            // 
            this.lblImportant.AutoSize = true;
            this.lblImportant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportant.Location = new System.Drawing.Point(35, 34);
            this.lblImportant.Name = "lblImportant";
            this.lblImportant.Size = new System.Drawing.Size(67, 16);
            this.lblImportant.TabIndex = 1;
            this.lblImportant.Text = "Wichtig: ";
            this.lblImportant.Visible = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(3, 6);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(868, 15);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Willkommen. Im Menü \"Liste\" kannst Du neue Listen erstellen, laden, speichern und" +
    " Ansehen (Drucken). Im Menü \"Editor\" kannst Du alle Vorlagen bearbeiten.";
            // 
            // lblErrorText
            // 
            this.lblErrorText.AutoSize = true;
            this.lblErrorText.Location = new System.Drawing.Point(1103, 36);
            this.lblErrorText.Name = "lblErrorText";
            this.lblErrorText.Size = new System.Drawing.Size(90, 13);
            this.lblErrorText.TabIndex = 26;
            this.lblErrorText.Text = "Nicht gespeichert";
            this.lblErrorText.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(142, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Validierung:";
            // 
            // saveFocDialog
            // 
            this.saveFocDialog.DefaultExt = "axml";
            this.saveFocDialog.Title = "Armeeliste speichern";
            // 
            // openFocFile
            // 
            this.openFocFile.DefaultExt = "axml";
            this.openFocFile.Title = "Lade ArmyList XML";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(618, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Limit:";
            // 
            // lblLimitPowerlevel
            // 
            this.lblLimitPowerlevel.AutoSize = true;
            this.lblLimitPowerlevel.Location = new System.Drawing.Point(655, 36);
            this.lblLimitPowerlevel.Name = "lblLimitPowerlevel";
            this.lblLimitPowerlevel.Size = new System.Drawing.Size(10, 13);
            this.lblLimitPowerlevel.TabIndex = 31;
            this.lblLimitPowerlevel.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(914, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Limit:";
            // 
            // lblLimitPoints
            // 
            this.lblLimitPoints.AutoSize = true;
            this.lblLimitPoints.Location = new System.Drawing.Point(951, 36);
            this.lblLimitPoints.Name = "lblLimitPoints";
            this.lblLimitPoints.Size = new System.Drawing.Size(10, 13);
            this.lblLimitPoints.TabIndex = 33;
            this.lblLimitPoints.Text = "-";
            // 
            // txtValidationText
            // 
            this.txtValidationText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValidationText.Location = new System.Drawing.Point(241, 62);
            this.txtValidationText.Multiline = true;
            this.txtValidationText.Name = "txtValidationText";
            this.txtValidationText.ReadOnly = true;
            this.txtValidationText.Size = new System.Drawing.Size(952, 35);
            this.txtValidationText.TabIndex = 34;
            // 
            // lblValidateIcon
            // 
            this.lblValidateIcon.AutoSize = true;
            this.lblValidateIcon.Image = global::WHSAArmyPlanner.Properties.Resources.Attenschen;
            this.lblValidateIcon.Location = new System.Drawing.Point(210, 65);
            this.lblValidateIcon.Name = "lblValidateIcon";
            this.lblValidateIcon.Size = new System.Drawing.Size(25, 13);
            this.lblValidateIcon.TabIndex = 28;
            this.lblValidateIcon.Text = "      ";
            this.lblValidateIcon.Visible = false;
            // 
            // lblErrorIcon
            // 
            this.lblErrorIcon.AutoSize = true;
            this.lblErrorIcon.Image = global::WHSAArmyPlanner.Properties.Resources.Attenschen;
            this.lblErrorIcon.Location = new System.Drawing.Point(1078, 36);
            this.lblErrorIcon.Name = "lblErrorIcon";
            this.lblErrorIcon.Size = new System.Drawing.Size(19, 13);
            this.lblErrorIcon.TabIndex = 25;
            this.lblErrorIcon.Text = "    ";
            this.lblErrorIcon.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1264, 595);
            this.Controls.Add(this.panWelcome);
            this.Controls.Add(this.txtValidationText);
            this.Controls.Add(this.lblLimitPoints);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblLimitPowerlevel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblValidateIcon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblErrorText);
            this.Controls.Add(this.lblErrorIcon);
            this.Controls.Add(this.btnAddDetachment);
            this.Controls.Add(this.lblOverallPoints);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblOveralPowerlevel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblOverallCommandPoints);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panDetachment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtArmyName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbDetachments);
            this.Controls.Add(this.mainMenu);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(1280, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scriptorum Exercitus - Onlinecodex & Armeelistentool für W40k 8e";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panDetachment.ResumeLayout(false);
            this.panDetachment.PerformLayout();
            this.tabControlSlots.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panWelcome.ResumeLayout(false);
            this.panWelcome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDetachments;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArmyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panDetachment;
        private System.Windows.Forms.ToolTip tooltipGeneral;
        private System.Windows.Forms.TextBox txtDetachmentSummary;
        private System.Windows.Forms.Label lblDetachmentCP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDetachmentName;
        private System.Windows.Forms.TabControl tabControlSlots;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neueListeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernUnterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detachmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waffenAusrüstungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem battlerolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einheitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sonderregelnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überWHSAArmyPlannerToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem fraktionslisteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOverallCommandPoints;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblOveralPowerlevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblOverallPoints;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem vorschauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportHTMLToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnAddDetachment;
        private System.Windows.Forms.ToolStripMenuItem modelleMiniaturenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.Panel panWelcome;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ToolStripMenuItem friendShareToolStripMenuItem;
        private System.Windows.Forms.Label lblErrorText;
        private System.Windows.Forms.Label lblErrorIcon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblValidateIcon;
        private System.Windows.Forms.SaveFileDialog saveFocDialog;
        private System.Windows.Forms.OpenFileDialog openFocFile;
        private System.Windows.Forms.Label lblLimitPowerlevel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblLimitPoints;
        private System.Windows.Forms.TextBox txtValidationText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Label lblSettingsMessage;
        private System.Windows.Forms.Label lblImportant;
        private System.Windows.Forms.Label lblSettingsWarning;
        private System.Windows.Forms.Button btnEditSettings;
    }
}

