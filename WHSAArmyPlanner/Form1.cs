/*"scriptex" Scriptorum Exercitus - Armylist planning tool for tabletop games
* (c) 2017 by Matthias Breiter. Licensed under the Terms of the Apache 2.0 License
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WHSAArmyPlanner
{
    public partial class Form1 : Form
    {
        bool edited = false;
        bool saved = false;

        enum RunMode { empty, opened };

        String armylistFilename = "";
        String miniaturesFile = Settings.Instance.MiniatureFile;
        String factionsFile = Settings.Instance.FactionsFile;
        String itemsFile = Settings.Instance.ItemsFile;
        String unitsFile = Settings.Instance.UnitsFile;
        String battleRolesFile = Settings.Instance.BattlerolesFile;
        String detachmentsFile = Settings.Instance.DetachmentsFile;
        RunMode ProgramRunningMode = RunMode.empty;

        ModelClasses.ForceOrgChart foc = null;

        ModelClasses.Units definedUnits = new ModelClasses.Units();
        ModelClasses.Units foundUnits = new ModelClasses.Units();
        ModelClasses.Miniatures allMiniatures = new ModelClasses.Miniatures();
        ModelClasses.Miniatures factionMiniatures = new ModelClasses.Miniatures();
        ModelClasses.Items allWargear = new ModelClasses.Items();
        ModelClasses.Items wargearForFaction = new ModelClasses.Items();
        ModelClasses.Factions allFactions = new ModelClasses.Factions();
        ModelClasses.BattleRoles allBattleRoles = new ModelClasses.BattleRoles();
        ModelClasses.Detachments allDetachments = new ModelClasses.Detachments();

        ModelClasses.Detachment selectedDetachment = null;

        public Form1()
        {
            InitializeComponent();
            Cursor.Current = Cursors.WaitCursor;
            LoadProcedure();
            Cursor.Current = Cursors.Default;
            RefreshView();
        }

        #region Refresh, Redraw
        public void ClearView()
        {
            lblOverallCommandPoints.Text = "";
            lblOverallPoints.Text = "";
            lblOveralPowerlevel.Text = "";
            txtArmyName.Text = "";
            lbDetachments.Items.Clear();
            lblDetachmentName.Text = "";
            lblDetachmentCP.Text = "";
            tabControlSlots.TabPages.Clear();
        }

        public void RefreshView()
        {
            switch (ProgramRunningMode)
            {
                case RunMode.empty:
                    ClearView();
                    txtArmyName.Enabled = false;
                    lblOverallCommandPoints.Enabled = false;
                    lblOverallPoints.Enabled = false;
                    lblOveralPowerlevel.Enabled = false;
                    btnAdd.Enabled = false;
                    btnRemove.Enabled = false;
                    btnAddDetachment.Enabled = false;
                    panDetachment.Enabled = false;
                    lbDetachments.Enabled = false;
                    lbDetachments.Items.Clear();
                    panWelcome.Enabled = true;
                    panWelcome.Visible = true;
                    tabControlSlots.Enabled = false;
                    vorschauToolStripMenuItem.Enabled = false;
                    exportHTMLToolStripMenuItem.Enabled = false;
                    if (!Settings.Instance.DoSettingsExist)
                    {
                        lblSettingsWarning.Visible = true;
                        lblImportant.Visible = true;
                        lblSettingsMessage.Visible = true;
                        btnEditSettings.Visible = true;
                        btnEditSettings.Enabled = true;
                        LockGuiBecuaseMissingSettings();
                    }
                    else
                    {
                        lblSettingsWarning.Visible = false;
                        lblImportant.Visible = false;
                        lblSettingsMessage.Visible = false;
                        btnEditSettings.Visible = false;
                        btnEditSettings.Enabled = false;
                        UnlockGuiSettingsDefined();
                    }
                    break;
                case RunMode.opened:
                    txtArmyName.Enabled = true;
                    lblOverallCommandPoints.Enabled = true;
                    lblOverallPoints.Enabled = true;
                    lblOveralPowerlevel.Enabled = true;
                    btnAdd.Enabled = true;
                    btnRemove.Enabled = true;
                    btnAddDetachment.Enabled = true;
                    panDetachment.Enabled = true;
                    lbDetachments.Enabled = true;
                    lbDetachments.Items.Clear();
                    panWelcome.Enabled = false;
                    panWelcome.Visible = false;
                    tabControlSlots.Enabled = true;
                    vorschauToolStripMenuItem.Enabled = true;
                    exportHTMLToolStripMenuItem.Enabled = true;

                    if (!saved)
                    {
                        lblErrorIcon.Visible = true;
                        lblErrorText.Text = "Nicht gespeichert";
                        lblErrorText.Visible = true;
                    }
                    else
                    {
                        lblErrorIcon.Visible = false;
                        lblErrorText.Visible = false;
                    }

                    RefreshFocInformation();

                    RefreshDetachmentList();

                    break;
            }
        }
        
        public void LockGuiBecuaseMissingSettings()
        {
            dateiToolStripMenuItem.Enabled = false;
            fraktionslisteToolStripMenuItem.Enabled = false;
            battlerolsToolStripMenuItem.Enabled = false;
            detachmentsToolStripMenuItem.Enabled = false;
            einheitenToolStripMenuItem.Enabled = false;
            modelleMiniaturenToolStripMenuItem.Enabled = false;
            waffenAusrüstungToolStripMenuItem.Enabled = false;
            hilfeToolStripMenuItem.Enabled = false;
        }

        public void UnlockGuiSettingsDefined()
        {
            dateiToolStripMenuItem.Enabled = true ;
            fraktionslisteToolStripMenuItem.Enabled = true;
            battlerolsToolStripMenuItem.Enabled = true;
            detachmentsToolStripMenuItem.Enabled = true;
            einheitenToolStripMenuItem.Enabled = true;
            modelleMiniaturenToolStripMenuItem.Enabled = true;
            waffenAusrüstungToolStripMenuItem.Enabled = true;
            hilfeToolStripMenuItem.Enabled = true;
        }

        public void RefreshFocInformation()
        {
            if (foc != null)
            {
                lblOverallCommandPoints.Text = foc.CurrentCommandPoints.ToString();
                lblOverallPoints.Text = foc.CurrentPoints.ToString();
                lblOveralPowerlevel.Text = foc.CurrentPowerLevel.ToString();
                txtArmyName.Text = foc.Name;

                if (foc.DoCheckPointLimt)
                {
                    lblLimitPoints.Text = foc.PointLimit.ToString();
                }
                else
                {
                    lblLimitPoints.Text = "-";
                }

                if (foc.DoCheckPowerlevel)
                {
                    lblLimitPowerlevel.Text = foc.Powerlevel.ToString();
                }
                else
                {
                    lblLimitPowerlevel.Text = "-";
                }

                ValidateFoc();

                if (selectedDetachment != null)
                {
                    txtDetachmentSummary.Text = selectedDetachment.GetSummary(false,false);
                }
            }
        }

        public void ValidateFoc()
        {
            StringBuilder validationText = new StringBuilder();
            Boolean hasValidationErrors = false;

            if (foc.DoCheckPowerlevel)
            {
                lblLimitPowerlevel.Text = foc.Powerlevel.ToString();
                if (foc.CurrentPowerLevel > foc.Powerlevel)
                {
                    hasValidationErrors = true;
                    validationText.Append(" Powerlevel zu hoch.");
                }
            }

            if (foc.DoCheckPointLimt)
            {
                if (foc.CurrentPoints > foc.PointLimit)
                {
                    hasValidationErrors = true;
                    validationText.Append(" Zuviele Punkte (Matched Points).");
                }
            }

            foreach (ModelClasses.Detachment det in foc.Detachments)
            {
                ActionResult testResult = det.ValidateSlotsNumberOfUnits();
                if (testResult.Success == false)
                {
                    hasValidationErrors = true;
                    validationText.AppendLine("Detachment \'" + det.Name + "\' fehlende Einheiten: " + testResult.Message);
                }
            }

            if (hasValidationErrors)
            {
                lblValidateIcon.Visible = true;
                txtValidationText.Visible = true;
                txtValidationText.Text = validationText.ToString();
            }
            else
            {
                txtValidationText.Visible = false;
                lblValidateIcon.Visible = false;
            }
        }

        public void RefreshDetachmentList()
        {
            if (foc != null)
            {
                if (foc.Detachments != null)
                {
                    lbDetachments.Items.Clear();

                    foreach (ModelClasses.Detachment det in foc.Detachments)
                    {
                        lbDetachments.Items.Add(det);
                    }

                    lbDetachments.SelectedItem = null;
                }
            }
        }

        public void RefreshDetachment()
        {
            if (foc != null && selectedDetachment != null)
            {
                txtDetachmentSummary.Text = selectedDetachment.GetSummary(false,false);
                
                lblDetachmentName.Text = selectedDetachment.Name;
                lblDetachmentCP.Text = selectedDetachment.CommandPoints.ToString();
                tabControlSlots.TabPages.Clear();
                foreach (ModelClasses.Slot slot in selectedDetachment.Slots)
                {
                    tabControlSlots.TabPages.Add(slot.BattleRole.Name);
                }

                try
                {
                    tabControlSlots.SelectTab(0);
                    DrawTab(tabControlSlots.SelectedTab);
                }
                catch
                {
                    // For the unlikely event that no tabs were added (which should not ever occur)
                }
            }
            else if (selectedDetachment == null)
            {
                lblDetachmentName.Text = "";
                lblDetachmentCP.Text = "";
                tabControlSlots.TabPages.Clear();
            }
        }
        
        public void DrawTab(TabPage selectedPage)
        {
            if (selectedPage != null)
            {
                selectedPage.AutoScroll = true;
                selectedPage.Controls.Clear();

                int startX = 5;
                int startY = 5;
                String battleRole = selectedPage.Text;
                ModelClasses.Units filteredUnits = new ModelClasses.Units();

                foreach (ModelClasses.Unit unit in definedUnits)
                {
                    if (unit.Faction.Name == selectedDetachment.Faction && unit.BattleRole.Name == battleRole)
                    {
                        filteredUnits.Add(unit);
                    }
                }

                ModelClasses.Slot selectedSlot = selectedDetachment.Slots.Where(x => x.BattleRole.Name == battleRole).Distinct().First();
                if (selectedSlot != null)
                {
                    if (selectedSlot.BattleRole.Name == "Transport")
                    {
                        selectedSlot.MinimumUnits = 0;
                        selectedSlot.MaximumUnits = selectedDetachment.GetNumberOfTransportSlots(); 
                    }

                    int existingEntries = 0;
                    
                    if (selectedSlot.CreatedUnits == null || !selectedSlot.CreatedUnits.Any())
                    {
                        existingEntries = 0;
                    }
                    else
                    {
                        int num = 0;

                        foreach (ModelClasses.Unit existingUnit in selectedSlot.CreatedUnits)
                        {
                           CustomControls.UcSlot ucSlot = new CustomControls.UcSlot(filteredUnits, num +1 ,existingUnit);
                            if (num < selectedSlot.MinimumUnits)
                            {
                                ucSlot.IsRequired = true;
                            }
                            else
                            {
                                ucSlot.IsRequired = false;
                            }

                            ucSlot.SetPos(new Point(startX, startY));
                            ucSlot.OnUnitChanged += UcSlot_OnUnitChanged;

                            selectedPage.Controls.Add(ucSlot);
                            startY += ucSlot.Height + 5;

                            num += 1;
                        }

                        existingEntries = selectedSlot.CreatedUnits.Count();
                    }

                    for (int i = existingEntries; i < selectedSlot.MaximumUnits; i++)
                    {
                        CustomControls.UcSlot ucSlot = new CustomControls.UcSlot(filteredUnits, i + 1);
                        if (i < selectedSlot.MinimumUnits)
                        {
                            ucSlot.IsRequired = true;
                        }
                        else
                        {
                            ucSlot.IsRequired = false;
                        }

                        ucSlot.SetPos(new Point(startX, startY));
                        ucSlot.OnUnitChanged += UcSlot_OnUnitChanged;

                        selectedPage.Controls.Add(ucSlot);
                        startY += ucSlot.Height + 5;
                    }
                }
            }
        }
        #endregion Refresh, Redraw

        #region Custom Event Handling

        private void UcSlot_OnUnitChanged(object sender, EventArgs e)
        {
            var ctrl = (CustomControls.UcSlot)sender;
            ModelClasses.Unit newUnit = ctrl.CreatedUnit;

            if (!ctrl.IsFilled)
            {
                selectedDetachment.RemoveUnit(newUnit);
                RefreshDetachment();
            }
            else
            {
                selectedDetachment.InsertUpdateUnit(newUnit);
            }

            edited = true;
            RefreshFocInformation();
        }

        #endregion

        private void InitSettings()
        {
            if(!Settings.Instance.DoSettingsExist)
            {
                ProgramRunningMode = RunMode.empty;
            }
        }

        public void OpenFocFromDisk()
        {
            if (ProgramRunningMode != RunMode.empty && ( edited || !saved))
            {
                DialogResult usersChoice = MessageBox.Show(this, "Es liegen ungesicherte Änderungen an der aktuellen Armee-Liste vor. Sollen die vor dem öffnen gespeichert werden?", "Vorsicht - ungesicherte Änderungen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (usersChoice == DialogResult.Yes)
                {
                    Save();
                }
            }

            openFocFile.DefaultExt = "xml";
            openFocFile.FileName = "";
            openFocFile.Filter = "ArmyList XML (*.axml)|*.axml";

            DialogResult res = openFocFile.ShowDialog();
            if (res == DialogResult.OK)
            {
                if (openFocFile.FileName != null)
                {
                    foc = new ModelClasses.ForceOrgChart();
                    selectedDetachment = null;
                    ClearView();

                    armylistFilename = openFocFile.FileName;
                    try
                    {
                        ReadFoc(armylistFilename);
                        saved = true;
                        edited = false;
                        ProgramRunningMode = RunMode.opened;
                        RefreshView();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(this, "Kann die Datei nicht einlesen: " + e.Message, "Auweia", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        saved = false;
                        edited = true;
                        ProgramRunningMode = RunMode.empty;
                    }
                }
            }

            RefreshView();
        }

        public void ReadFoc(string path)
        {
            FileStream fs = null;
            foc = new ModelClasses.ForceOrgChart();

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModelClasses.ForceOrgChart));
                fs = new FileStream(path, FileMode.Open);
                foc = (ModelClasses.ForceOrgChart)serializer.Deserialize(fs);
                fs.Close();
            }
            catch (Exception excp)
            {
                if (fs != null)
                {
                    fs.Dispose();
                }
                throw excp;
            }
        }

        public void Save()
        {
            if (saved)
            {
                try
                {
                    WriteFocToDisc(armylistFilename);
                    saved = true;
                    edited = false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(this, "Speichern unmöglich: " + e.Message, "Auweia", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    saved = false;
                    edited = true;
                }
            }
            else
            {
                SaveAs();
            }
            
            RefreshView();
        }

        public void SaveAs()
        {
            saveFocDialog.Filter = "Armylist XML (*.axml) |*.axml";
            saveFocDialog.FileName = foc.Name;
            DialogResult res = saveFocDialog.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                if (saveFocDialog.FileName != "")
                {
                    try
                    {
                        armylistFilename = saveFocDialog.FileName;
                        WriteFocToDisc(armylistFilename);
                        saved = true;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(this, "Speichern unmöglich: " + e.Message, "Auweia", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        saved = false;
                    }
                }
            }
        }

        public void WriteFocToDisc(string path)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModelClasses.ForceOrgChart));
                TextWriter writer = new StreamWriter(path);

                if (foc != null)
                {
                    serializer.Serialize(writer, foc);
                }

                writer.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void LoadProcedure()
        {
            LoadDetachmentTemplates();
            LoadFactions();
            LoadUnitTemplates();
        }

        #region Load Procedure Steps

        public void LoadDetachmentTemplates()
        {
            FileStream fsDetachment = null;
            allDetachments = new ModelClasses.Detachments();
            allDetachments.Clear();

            try
            {
                XmlSerializer detachmentSerializer = new XmlSerializer(typeof(ModelClasses.Detachments));
                fsDetachment = new FileStream(detachmentsFile, FileMode.Open);
                allDetachments = (ModelClasses.Detachments)detachmentSerializer.Deserialize(fsDetachment);
                fsDetachment.Close();
            }
            catch (Exception excp)
            {
                if (fsDetachment != null)
                {
                    fsDetachment.Dispose();
                }
            }
        }

        public void LoadFactions()
        {
            FileStream fs = null;

            allFactions = new ModelClasses.Factions();
            allFactions.Clear();

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModelClasses.Factions));
                fs = new FileStream(factionsFile, FileMode.Open);
                allFactions = (ModelClasses.Factions)serializer.Deserialize(fs);
                fs.Close();
            }
            catch (Exception excp)
            {
                if (fs != null)
                {
                    fs.Dispose();
                }
            }
        }

        public void LoadUnitTemplates()
        {
            FileStream fs = null;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModelClasses.Units));
                fs = new FileStream(unitsFile, FileMode.Open);
                definedUnits = (ModelClasses.Units)serializer.Deserialize(fs);
                fs.Close();
            }
            catch (Exception excp)
            {
                if (fs != null)
                {
                    fs.Dispose();
                }
            }
        }
        #endregion

        #region Window/Controls Events 

        private void btnEditSettings_Click(object sender, EventArgs e)
        {
            OpenSettingsDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (edited)
            {
                DialogResult userChoice = MessageBox.Show(this, "Es gibt ungespeicherte Änderungen. Sollen diese vor dem schließen gespeichert werden?", "Achtung - ungesicherte Änderungen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (userChoice == DialogResult.Yes)
                {
                   Save();
                }
            }
        }

        private void btnAddDetachment_Click(object sender, EventArgs e)
        {
            if (foc != null)
            {
                Forms.DialogAddDetachment dlgAddDetach = new Forms.DialogAddDetachment(foc.IsStrictMatchPlay, foc.ArmyFactionForMatchedPlay, allFactions, allDetachments, foc.Detachments.Count);

                using (dlgAddDetach)
                {
                    DialogResult res = dlgAddDetach.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        if (dlgAddDetach.Detachment != null)
                        {
                            edited = true;
                            foc.Detachments.Add(dlgAddDetach.Detachment);
                            RefreshFocInformation();
                            RefreshDetachmentList();
                        }
                    }
                }
            }
        }

        private void lbDetachments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (foc != null)
            {
                if (lbDetachments.SelectedItem != null)
                {
                    selectedDetachment = (ModelClasses.Detachment)lbDetachments.SelectedItem;
                    RefreshDetachment();
                }
            }
        }

        private void tabControlSlots_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (foc != null && selectedDetachment != null)
            {
                if (tabControlSlots.SelectedTab != null)
                {
                    DrawTab(tabControlSlots.SelectedTab);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (foc != null && selectedDetachment != null)
            {
                DialogResult userChoice = MessageBox.Show(this, "Willst Du das gewählte Detachment \'" + selectedDetachment.Name + "\' wirklich löschen?", "Achtung - Wirklich löschen?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (userChoice == DialogResult.Yes)
                {
                    foc.Detachments.Remove(selectedDetachment);
                    selectedDetachment = null;
                    RefreshView();
                    RefreshFocInformation();
                    RefreshDetachment();
                }
            }
        }
        #endregion

        #region Menu Bar
        private void waffenAusrüstungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.DialogItems frmItems = new Forms.DialogItems();
            using (frmItems)
            {
                DialogResult res = frmItems.ShowDialog(this);
            }
        }

        private void battlerolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.DialogBattleroles frmBattleRoles = new Forms.DialogBattleroles();
            using (frmBattleRoles)
            {
                DialogResult res = frmBattleRoles.ShowDialog(this);
            }
        }

        private void detachmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.DialogDetachments frmDetachments = new Forms.DialogDetachments();
            using (frmDetachments)
            {
                DialogResult res = frmDetachments.ShowDialog(this);
                LoadDetachmentTemplates();
            }
        }

        private void überWHSAArmyPlannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Scriptorum Exercitus - Ein Armeelistentool für 40k 8. Edition \r\n Version 0.90 \r\n(c) 2017 by Matthias Breiter. http://www.ibbreiter.de \r\n This Software is Freeware and comes with absolutely no warranty. Modifications to this software of any kind require the author's written permission./ Dieses Programm ist Freeware, wir übernehmen keinerlei Garantie. Veränderungen am Programm sind ohne schriftliche Zustimmung des Authors nicht erlaubt. ");
        }

        private void fraktionslisteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.DialogFactions frmFactions = new Forms.DialogFactions();
            using (frmFactions)
            {
                DialogResult res = frmFactions.ShowDialog(this);
                LoadFactions();
            }
        }

        private void modelleMiniaturenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.DialogMinis frmMinis = new Forms.DialogMinis();
            using (frmMinis)
            {
                DialogResult res = frmMinis.ShowDialog(this);
            }
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void einheitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.DialogUnits dlgUnits = new Forms.DialogUnits();
            using (dlgUnits)
            {
                DialogResult res = dlgUnits.ShowDialog(this);
                LoadUnitTemplates();
            }
        }

        private void exportHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void neueListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.DialogNewArmy dlgNewArmy = new Forms.DialogNewArmy();
            using (dlgNewArmy)
            {
                ClearView();
                DialogResult res = dlgNewArmy.ShowDialog(this);
                if (res == DialogResult.OK)
                {
                    foc = new ModelClasses.ForceOrgChart();

                    foc.Name = dlgNewArmy.ArmyName;
                    foc.IsStrictMatchPlay = dlgNewArmy.IsStrictMatchedList;
                    foc.ArmyFactionForMatchedPlay = dlgNewArmy.SelectedFaction;

                    foc.DoCheckPointLimt = dlgNewArmy.IsPointsLimited;
                    foc.DoCheckPowerlevel = dlgNewArmy.IsPowerlevelLimited;

                    foc.Powerlevel = dlgNewArmy.PowerleveLimit;
                    foc.PointLimit = dlgNewArmy.PointsLimit;

                    foc.Detachments = new ModelClasses.Detachments();
                    foc.ExistingFile = false;

                    edited = true;
                    saved = false;
                    
                    ProgramRunningMode = RunMode.opened;
                    RefreshView();
                }
            }
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void speichernUnterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void ladenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFocFromDisk();
        }

        private void vorschauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ProgramRunningMode == RunMode.opened && foc != null)
            {
                Forms.DialogTextPreview dlgTextView = new Forms.DialogTextPreview(foc);
                using (dlgTextView)
                {
                    dlgTextView.ShowDialog(this);
                }
            }
        }

        private void einstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSettingsDialog(); 
        }

        private void OpenSettingsDialog()
        {
            Forms.DialogPreferences dlgPrefs = new Forms.DialogPreferences();
            using (dlgPrefs)
            {
                DialogResult res = dlgPrefs.ShowDialog(this);
                if (res == DialogResult.OK)
                {
                    Settings.Instance.TemplateBasePath = dlgPrefs.TemplatePath;
                    Settings.Instance.Save();
                    this.RefreshView();
                }
            }
        }

        #endregion

        private void friendShareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.DialogShareWithFriends dlgShare = new Forms.DialogShareWithFriends();
            using (dlgShare)
            {
                dlgShare.ShowDialog();
            }
        }
    }
}
