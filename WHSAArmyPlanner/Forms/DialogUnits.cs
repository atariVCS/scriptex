/*"scriptex" Scriptorum Exercitus - Armylist planning tool for tabletop games
* (c) 2017 by Matthias Breiter. Licensed under the Terms of the Apache 2.0 License
*/
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WHSAArmyPlanner.Forms
{
    public partial class DialogUnits : Form
    {
        Boolean edited = false;
        Boolean selected = false;
        String miniaturesFile = Settings.Instance.MiniatureFile;
        String factionsFile = Settings.Instance.FactionsFile;
        String itemsFile = Settings.Instance.ItemsFile;
        String unitsFile = Settings.Instance.UnitsFile;
        String battleRolesFile = Settings.Instance.BattlerolesFile;

        ModelClasses.Units definedUnits = new ModelClasses.Units();
        ModelClasses.Units foundUnits = new ModelClasses.Units();
        ModelClasses.Unit selectedUnit = null;
        ModelClasses.UnitModel selectedUnitModel = null;
        ModelClasses.Miniatures allMiniatures = new ModelClasses.Miniatures();
        ModelClasses.Miniatures factionMiniatures = new ModelClasses.Miniatures();
        ModelClasses.Items allWargear = new ModelClasses.Items();
        ModelClasses.Items factionsWargear = new ModelClasses.Items();
        ModelClasses.Factions allFactions = new ModelClasses.Factions();
        ModelClasses.BattleRoles allBattleRoles = new ModelClasses.BattleRoles();
        ModelClasses.Items replaceableWargear = new ModelClasses.Items();
        ModelClasses.UnitModels replaceableModels = new ModelClasses.UnitModels();

        public DialogUnits()
        {
            InitializeComponent();
        }
        
        private void DialogUnits_Load(object sender, EventArgs e)
        {
            LoadProcedure();
        }

        private void Save()
        {
            edited = false;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModelClasses.Units));
                TextWriter writer = new StreamWriter(unitsFile);

                if (definedUnits != null && definedUnits.Any())
                {
                    serializer.Serialize(writer, definedUnits);
                }

                writer.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Oh Oh, ich kann nicht speichern: " + e.Message);
            }
        }
        
        private void PerformSearch()
        {
            foundUnits.Clear();

            if (String.IsNullOrWhiteSpace(txtSearch.Text))
            {
                foreach (ModelClasses.Unit unit in definedUnits)
                {
                    foundUnits.Add(unit);
                }
            }
            else
            {
                foreach (ModelClasses.Unit possibleMatch in definedUnits)
                {
                    if (possibleMatch.ToString().StartsWith(txtSearch.Text,StringComparison.InvariantCultureIgnoreCase))
                    {
                        foundUnits.Add(possibleMatch);
                    }
                }
            }
        }

        private void DialogUnits_FormClosing(object sender, FormClosingEventArgs e)
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
        
        private void LoadProcedure()
        {
            LoadUnits();
            LoadAllWargear();
            LoadAlllMiniatures();
            LoadAllFactions();
            LoadAllBattleRoles();

            PerformSearch();
            RefreshView();
        }

        #region Loading
        private void LoadAlllMiniatures()
        {
            FileStream fs = null;
            factionMiniatures.Clear();

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModelClasses.Miniatures));
                fs = new FileStream(miniaturesFile, FileMode.Open);
                allMiniatures = (ModelClasses.Miniatures)serializer.Deserialize(fs);
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

        private void LoadAllFactions()
        {
            FileStream fs = null;

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

        private void LoadAllWargear()
        {
            FileStream fs = null;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModelClasses.Items));
                fs = new FileStream(itemsFile, FileMode.Open);
                allWargear = (ModelClasses.Items)serializer.Deserialize(fs);
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

        private void LoadUnits()
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
        
        private void LoadAllBattleRoles()
        {
            FileStream fs = null;

            try
            {
                XmlSerializer battleRoleSerializer = new XmlSerializer(typeof(ModelClasses.BattleRoles));
                fs = new FileStream(battleRolesFile, FileMode.Open);
                allBattleRoles = (ModelClasses.BattleRoles)battleRoleSerializer.Deserialize(fs);
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

        private void GetFactionMiniatures()
        {
            if (selectedUnit != null)
            {
                factionMiniatures.Clear();

                foreach (ModelClasses.Miniature mini in allMiniatures)
                {
                    if (mini.Faction.Name == selectedUnit.Faction.Name)
                    {
                        factionMiniatures.Add(mini);
                    }
                }

            }
        }

        private void GetFactionWargear()
        {
            if (selectedUnit != null)
            {
                factionsWargear.Clear();

                foreach (ModelClasses.Item gear in allWargear)
                {
                    if (selectedUnit.Faction.Name == gear.AllowedFaction.Name)
                    {
                        factionsWargear.Add(gear);
                    }
                }
            }
        }

        #endregion

        #region Refrehs & Redraws
        private void RefreshView()
        {
            cmbFaction.Items.Clear();
            cmbUnitFaction.Items.Clear();
            cmbUnitBattlerole.Items.Clear();

            foreach (ModelClasses.Faction faction in allFactions)
            {
                cmbFaction.Items.Add(faction);
                cmbUnitFaction.Items.Add(faction);
            }

            lbUnits.Items.Clear();
            foreach (ModelClasses.Unit unit in foundUnits)
            {
                lbUnits.Items.Add(unit);
            }

            foreach (ModelClasses.BattleRole slot in allBattleRoles)
            {
                cmbUnitBattlerole.Items.Add(slot);
            }

            cmbFaction.Text = "";
            cmbFaction.SelectedItem = null;

            txtInput.Text = "";
        }

        private void RefreshDetails()
        {
            if (selectedUnit != null)
            {
                grpboxUnitDetails.Enabled = true;

                cmbUnitFaction.Text = selectedUnit.Faction.Name;
                cmbUnitFaction.SelectedItem = selectedUnit.Faction;
                txtUnitName.Text = selectedUnit.Name;
                txtMatchpoints.Text = selectedUnit.MatchedPoints.ToString();
                txtPowerlevel.Text = selectedUnit.Powerlevel.ToString();
                numBonusCp.Value = selectedUnit.BonusCp;

                numMinModels.Value = selectedUnit.MinimumUnitCount;
                numMaxModels.Value = selectedUnit.MaximumUnitCount;

                cbIsUnique.Checked = selectedUnit.IsUnique;

                lbModels.Items.Clear();
                foreach (ModelClasses.UnitModel entry in selectedUnit.ListEntries)
                {
                    lbModels.Items.Add(entry);
                }

                if (selectedUnit.BattleRole != null)
                {
                    cmbUnitBattlerole.SelectedItem = selectedUnit.BattleRole;
                    cmbUnitBattlerole.Text = selectedUnit.BattleRole.Name;
                }
                else
                {
                    cmbUnitBattlerole.SelectedItem = null;
                    cmbUnitBattlerole.Text = "";
                }

                GetFactionMiniatures();
                GetFactionWargear();
                RefreshMiniatures();
                RefreshWargear();
                DisableListEntryPanel();
            }
        }

        public void RefreshMiniatures()
        {
            cmbUnitMiniature.Items.Clear();
            foreach (ModelClasses.Miniature mini in factionMiniatures)
            {
                cmbUnitMiniature.Items.Add(mini);
            }
        }

        public void RefreshWargear()
        {
            cmbUnitItem.Items.Clear();
            foreach (ModelClasses.Item gear in factionsWargear)
            {
                cmbUnitItem.Items.Add(gear);
            }
        }

        public void RefreshStandardWeapons()
        {
            if (selectedUnit != null && selectedUnitModel != null)
            {
                cmbReplaceableWargear.Items.Clear();
                replaceableWargear.Clear();
                foreach (ModelClasses.UnitModel entry in selectedUnit.ListEntries)
                {
                    if (!entry.IsReplacement && !entry.IsUpgradeOnly && !entry.IsWargear && entry.Miniature != null)
                    {
                        replaceableWargear.AddRange(entry.Miniature.StandardEquip);
                    }
                }

                foreach (ModelClasses.Item item in replaceableWargear)
                {
                    cmbReplaceableWargear.Items.Add(item);
                }
            }
        }

        public void RefreshModelList()
        {
            if (selectedUnit != null && selectedUnitModel != null)
            {
                cmbReplaceableModel.Items.Clear();
                replaceableModels.Clear();

                foreach (ModelClasses.UnitModel entry in selectedUnit.ListEntries)
                {
                    if (!entry.IsReplacement && !entry.IsUpgradeOnly && !entry.IsWargear && entry.Miniature != null)
                    {
                        replaceableModels.Add(entry);
                    }
                }

                foreach (ModelClasses.UnitModel entry in replaceableModels)
                {
                    cmbReplaceableModel.Items.Add(entry);
                }
            }
        }

        public void ClearEntry()
        {
            cmbUnitMiniature.SelectedItem = null;
            cmbUnitMiniature.Text = "";
            
            numModelCountLimit.Value = 0;
            numModelCount.Value = 0;
            numModelPoints.Value = 0;
            numModelPowerLevel.Value = 0;
            cbDoesNotCount.Checked = false;
            cbReplaceModel.Checked = false;
            cbReplacesMForN.Checked = false;
            cbRequiresMinimum.Checked = false;
            cbUpgradeOnly.Checked = false;
            cbReplaceWargear.Checked = false;

            cmbReplaceableWargear.Items.Clear();
            cmbReplaceableWargear.Text = "";

            numMinimumRequired.Enabled = false;
            numMinimumRequired.Value = 0;

            numReplacesEveryNModels.Enabled = false;
            numReplacesEveryNModels.Value = 0;

            txtEntryExtraMpModels.Text = "";
            txtEntryExtraPlModels.Text = "";
            txtEntryExtraPoints.Text = "";
            txtEntryExtraPowerlevel.Text = "";

            cmbReplaceableModel.Text = "";
            cmbReplaceableModel.Enabled = false;
        }

        public void ClearDetails()
        {
            cmbUnitBattlerole.Text = "";
            cmbUnitFaction.Text = "";
            cbIsUnique.Checked = false;
            txtUnitName.Text = "";
            txtPowerlevel.Text = "";
            txtMatchpoints.Text = "";
            numMinModels.Value = 0;
            numMaxModels.Value = 0;
            lbModels.Items.Clear();
            grpboxUnitDetails.Enabled = false;
        }

        public void RefreshListEntry()
        {
            if (selectedUnit != null && selectedUnitModel != null)
            {
                ActivateListEntryPanel();
                
                if (!selectedUnitModel.IsWargear && selectedUnitModel.Wargear == null && selectedUnitModel.Miniature == null)
                {
                    #region Empty Entry
                    cmbUnitItem.Enabled = true;
                    cmbUnitItem.Text = "";
                    btnRemoveItem.Enabled = true;
                    cmbUnitMiniature.Enabled = true;
                    cmbUnitMiniature.Text = "";
                    btnRemoveMiniature.Enabled = true;
                    #endregion
                }
                else
                {
                    if (selectedUnitModel.IsWargear)
                    {
                        #region Wargear
                        RefreshStandardWeapons();
                        cmbUnitMiniature.Enabled = false;
                        cmbUnitMiniature.Text = "";
                        btnRemoveMiniature.Enabled = false;
                        cmbUnitItem.SelectedItem = selectedUnitModel.Wargear;
                        if (selectedUnitModel.Wargear != null)
                        {
                            cmbUnitItem.Text = selectedUnitModel.Wargear.Name;
                        }

                        cbReplaceWargear.Checked = selectedUnitModel.IsWargearReplacment;
                        if (selectedUnitModel.IsWargearReplacment)
                        {
                            if (selectedUnitModel.WargearToReplace != null)
                            {
                                cmbReplaceableWargear.Text = selectedUnitModel.WargearToReplace.Name;
                            }

                            cmbReplaceableWargear.Enabled = true;
                        }
                        else
                        {
                            cmbReplaceableWargear.Enabled = false;
                        }
                        #endregion Wargear
                    }
                    else
                    {
                        #region Model (Miniature)
                        RefreshModelList();
                        cbReplaceWargear.Enabled = false;
                        cmbReplaceableWargear.Enabled = false;
                        cmbReplaceableWargear.Text = "";

                        cbReplaceModel.Enabled = true;

                        cmbUnitItem.Enabled = false;
                        btnRemoveItem.Enabled = false;
                        cmbUnitItem.Text = "";
                        
                        cmbUnitMiniature.SelectedItem = selectedUnitModel.Miniature;
                        if (selectedUnitModel.Miniature != null)
                        {
                            cmbUnitMiniature.Text = selectedUnitModel.Miniature.Name;
                        }
                        #endregion
                    }
                }

                #region Common Data
                numModelCount.Value = selectedUnitModel.Count;
                numModelCountLimit.Value = selectedUnitModel.CountLimit;
                numModelPoints.Value = selectedUnitModel.Points;
                numModelPowerLevel.Value = selectedUnitModel.PowerLevel;

                txtEntryExtraMpModels.Text = selectedUnitModel.ExtraPointsForHowManyModels.ToString();
                txtEntryExtraPlModels.Text = selectedUnitModel.ExtraPLForHowManyModels.ToString();
                txtEntryExtraPoints.Text = selectedUnitModel.ExtraPoints.ToString();
                txtEntryExtraPowerlevel.Text = selectedUnitModel.ExtraPowerLevel.ToString();

                cbDoesNotCount.Checked = selectedUnitModel.DoesNotCount;
                cbReplaceModel.Checked = selectedUnitModel.IsReplacement;
                if (selectedUnitModel.IsReplacement)
                {
                    cmbReplaceableModel.Enabled = true;
                    if (selectedUnitModel.ModelToReplace != null)
                    {
                        cmbReplaceableModel.Text = selectedUnitModel.ModelToReplace.Name;
                    }
                }
                else
                {
                    cmbReplaceableModel.Enabled = false;
                    cmbReplaceableModel.Text = "";
                }

                cbReplacesMForN.Checked = selectedUnitModel.IsAllowedForEachNumberUnits;
                cbRequiresMinimum.Checked = selectedUnitModel.DoesRequireMinimumCount;
                cbUpgradeOnly.Checked = selectedUnitModel.IsUpgradeOnly;

                if (selectedUnitModel.DoesRequireMinimumCount)
                {
                    numMinimumRequired.Enabled = true;
                    numMinimumRequired.Value = selectedUnitModel.RequiredMinimumCount;
                }
                else
                {
                    numMinimumRequired.Value = 0;
                    numMinimumRequired.Enabled = false;
                }

                if (selectedUnitModel.IsAllowedForEachNumberUnits)
                {
                    numReplacesEveryNModels.Enabled = true;
                    numReplacesEveryNModels.Value = selectedUnitModel.ReplacesEveryNcount;
                }
                else
                {
                    numReplacesEveryNModels.Value = 0;
                    numReplacesEveryNModels.Enabled = false;
                }
                #endregion Common Data
            }
        }

        private void ActivateListEntryPanel()
        {
            cmbUnitItem.Enabled = true;
            btnRemoveItem.Enabled = true;

            cmbUnitMiniature.Enabled = true;
            btnRemoveMiniature.Enabled = true;

            cbReplaceModel.Enabled = true;
            cmbReplaceableModel.Enabled = true;

            cbReplacesMForN.Enabled = true;
            cbRequiresMinimum.Enabled = true;
            cbUpgradeOnly.Enabled = true;
            cbDoesNotCount.Enabled = true;

            numModelCountLimit.Enabled = true;
            numModelCount.Enabled = true;

            numModelPowerLevel.Enabled = true;
            numModelPoints.Enabled = true;

            txtEntryExtraPowerlevel.Enabled = true;
            txtEntryExtraPlModels.Enabled = true;
            txtEntryExtraPoints.Enabled = true;
            txtEntryExtraMpModels.Enabled = true;
                        
            cbReplaceWargear.Enabled = true;
            cmbReplaceableWargear.Enabled = true;
        }

        private void DisableListEntryPanel()
        {
            cmbUnitItem.Enabled = false;
            btnRemoveItem.Enabled = false;

            cmbUnitMiniature.Enabled = false;
            btnRemoveMiniature.Enabled = false;

            cbReplaceModel.Enabled = false;
            cmbReplaceableModel.Enabled = false;

            cbReplacesMForN.Enabled = false;
            cbRequiresMinimum.Enabled = false;
            cbUpgradeOnly.Enabled = false;
            cbDoesNotCount.Enabled = false;

            numModelCountLimit.Enabled = false;
            numModelCount.Enabled = false;

            numModelPowerLevel.Enabled = false;
            numModelPoints.Enabled = false;

            txtEntryExtraPowerlevel.Enabled = false;
            txtEntryExtraPlModels.Enabled = false;
            txtEntryExtraPoints.Enabled = false;
            txtEntryExtraMpModels.Enabled = false;

            numMinimumRequired.Enabled = false;
            numReplacesEveryNModels.Enabled = false;

            cbReplaceWargear.Enabled = false;
            cmbReplaceableWargear.Enabled = false;
        }
        #endregion Refrehs & Redraws

        #region Profile Values
        private void cmbUnitFaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedUnit != null)
            {
                if (cmbUnitFaction.SelectedItem != null)
                {
                    selectedUnit.Faction = (ModelClasses.Faction)cmbUnitFaction.SelectedItem;
                    edited = true;
                }
            }
        }

        private void txtUnitName_TextChanged(object sender, EventArgs e)
        {
            if (selectedUnit != null)
            {
                if (!String.IsNullOrWhiteSpace(txtUnitName.Text))
                {
                    selectedUnit.Name = txtUnitName.Text;
                    edited = true;
                }
            }
        }

        private void cmbUnitBattlerole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedUnit != null)
            {
                if (cmbUnitBattlerole.SelectedItem != null)
                {
                    selectedUnit.BattleRole = (ModelClasses.BattleRole)cmbUnitBattlerole.SelectedItem;
                    edited = true;
                }
            }
        }

        private void txtPowerlevel_TextChanged(object sender, EventArgs e)
        {
            if (selectedUnit != null)
            {
                edited = true;

                try
                {
                    selectedUnit.Powerlevel = Convert.ToInt32(txtPowerlevel.Text);
                }
                catch
                {
                    selectedUnit.Powerlevel = 0;
                }
            }
        }

        private void txtMatchpoints_TextChanged(object sender, EventArgs e)
        {
            if (selectedUnit != null)
            {
                edited = true;

                try
                {
                    selectedUnit.MatchedPoints = Convert.ToInt32(txtMatchpoints.Text);
                }
                catch
                {
                    selectedUnit.MatchedPoints = 0;
                }
            }
        }

        private void numBonusCp_ValueChanged(object sender, EventArgs e)
        {
            if (selectedUnit != null)
            {
                selectedUnit.BonusCp = Convert.ToInt32(numBonusCp.Value);
                edited = true;
            }
        }

        private void numMinModels_ValueChanged(object sender, EventArgs e)
        {
            if (selectedUnit != null)
            {
                selectedUnit.MinimumUnitCount = Convert.ToInt32(numMinModels.Value);
            }
        }

        private void numMaxModels_ValueChanged(object sender, EventArgs e)
        {
            if (selectedUnit != null)
            {
                selectedUnit.MaximumUnitCount = Convert.ToInt32(numMaxModels.Value);
            }
        }

        private void cmbUnitMiniature_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedUnit != null && selectedUnitModel != null)
            {
                if (cmbUnitMiniature.SelectedItem != null)
                {
                    cbReplaceWargear.Enabled = false;
                    cmbReplaceableWargear.Enabled = false;
                    selectedUnitModel.Miniature = (ModelClasses.Miniature)cmbUnitMiniature.SelectedItem;
                    selectedUnitModel.IsWargear = false;
                    selectedUnitModel.Wargear = null;
                    RefreshListEntry();
                }
            }
        }

        private void numModelCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numModelCountLimit_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numModelPowerLevel_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numModelPoints_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbReplaceModel_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedUnit != null && selectedUnitModel != null)
            {
                selectedUnitModel.IsReplacement = cbReplaceModel.Checked;
                if (selectedUnitModel.IsReplacement)
                {
                    cmbReplaceableModel.Enabled = true;
                }
                else
                {
                    cmbReplaceableModel.Enabled = false;
                }
            }
        }

        private void cbDoesNotCount_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedUnit != null && selectedUnitModel != null)
            {
                edited = true;
                selectedUnitModel.DoesNotCount = cbDoesNotCount.Checked;
            }
        }

        private void cbUpgradeOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedUnit != null && selectedUnitModel != null)
            {
                edited = true;
                selectedUnitModel.IsUpgradeOnly = cbUpgradeOnly.Checked;
            }
        }

        private void cbRequiresMinimum_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedUnit != null && selectedUnitModel != null)
            {
                edited = true;
                selectedUnitModel.DoesRequireMinimumCount = cbRequiresMinimum.Checked;

                if (selectedUnitModel.DoesRequireMinimumCount)
                {
                    numMinimumRequired.Enabled = true;
                }
                else
                {
                    numMinimumRequired.Enabled = false;
                }
            }
        }

        private void cbReplacesMForN_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedUnit != null && selectedUnitModel != null)
            {
                edited = true;
                selectedUnitModel.IsAllowedForEachNumberUnits = cbReplacesMForN.Checked;

                if (selectedUnitModel.IsAllowedForEachNumberUnits)
                {
                    numReplacesEveryNModels.Enabled = true;
                }
                else
                {
                    numReplacesEveryNModels.Enabled = false;
                }
            }
        }

        private void numMinimumRequired_ValueChanged(object sender, EventArgs e)
        {
            if (selectedUnit != null && selectedUnitModel != null)
            {
                edited = true;
                try
                {
                    selectedUnitModel.RequiredMinimumCount = Convert.ToInt32(numMinimumRequired.Value);
                }
                catch
                {
                    selectedUnitModel.RequiredMinimumCount = 0;
                }
            }
        }

        private void numReplacesEveryNModels_ValueChanged(object sender, EventArgs e)
        {
            if (selectedUnit != null && selectedUnitModel != null)
            {
                edited = true;
                try
                {
                    selectedUnitModel.ReplacesEveryNcount = Convert.ToInt32(numReplacesEveryNModels.Value);
                }
                catch
                {
                    selectedUnitModel.ReplacesEveryNcount = 0;
                }
            }
        }

        private void txtEntryExtraPowerlevel_TextChanged(object sender, EventArgs e)
        {
            if (selectedUnit != null && selectedUnitModel != null)
            {
                edited = true;

                try
                {
                    selectedUnitModel.ExtraPowerLevel = Convert.ToInt32(txtEntryExtraPowerlevel.Text);
                }
                catch
                {
                    selectedUnitModel.ExtraPowerLevel = 0;
                }
            }
        }

        private void txtEntryExtraPlModels_TextChanged(object sender, EventArgs e)
        {
            if (selectedUnit != null && selectedUnitModel != null)
            {
                edited = true;

                try
                {
                    selectedUnitModel.ExtraPLForHowManyModels = Convert.ToInt32(txtEntryExtraPlModels.Text);
                }
                catch
                {
                    selectedUnitModel.ExtraPLForHowManyModels = 0;
                }
            }
        }

        private void txtEntryExtraPoints_TextChanged(object sender, EventArgs e)
        {
            if (selectedUnit != null && selectedUnitModel != null)
            {
                edited = true;

                try
                {
                    selectedUnitModel.ExtraPoints = Convert.ToInt32(txtEntryExtraPoints.Text);
                }
                catch
                {
                    selectedUnitModel.ExtraPoints = 0;
                }
            }
        }

        private void txtEntryExtraMpModels_TextChanged(object sender, EventArgs e)
        {
            if (selectedUnit != null && selectedUnitModel != null)
            {
                edited = true;

                try
                {
                    selectedUnitModel.ExtraPointsForHowManyModels = Convert.ToInt32(txtEntryExtraMpModels.Text);
                }
                catch
                {
                    selectedUnitModel.ExtraPointsForHowManyModels = 0;
                }
            }
        }

        private void cbIsUnique_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedUnit != null)
            {
                edited = true;
                selectedUnit.IsUnique = cbIsUnique.Checked;
            }
        }

        #endregion

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
           Save();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbFaction.SelectedItem != null  && !String.IsNullOrWhiteSpace(txtInput.Text))
            {
                ModelClasses.Unit newUnit = new ModelClasses.Unit();
                newUnit.Faction = (ModelClasses.Faction)cmbFaction.SelectedItem;
                newUnit.Name = txtInput.Text;
                definedUnits.AddUnit(newUnit);
                edited = true;
                PerformSearch();
                RefreshView();
            }
        }

        private void lbUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbUnits.SelectedItem != null)
            { 
                selectedUnit = (ModelClasses.Unit)lbUnits.SelectedItem;
                selected = true;
                RefreshDetails();
                ClearEntry();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedUnit != null)
            {
                txtUnitModelName.Enabled = true;
                cmbUnitFaction.Enabled = true;
            }
        }
        
        private void btnAddUnitModel_Click(object sender, EventArgs e)
        {
            if (selectedUnit != null)
            {
                if (!String.IsNullOrWhiteSpace(txtUnitModelName.Text))
                {
                    ModelClasses.UnitModel newModel = new ModelClasses.UnitModel();
                    newModel.Name = txtUnitModelName.Text;
                    newModel.Faction = selectedUnit.Faction;

                    selectedUnit.ListEntries.Add(newModel);

                    RefreshDetails();
                }
            }
        }

        private void lbModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedUnit != null)
            {
                if (lbModels.SelectedItem != null)
                {
                    selectedUnitModel = (ModelClasses.UnitModel)lbModels.SelectedItem;
                    RefreshListEntry();
                }
            }
        }
        
        private void btnRemoveUnitModel_Click(object sender, EventArgs e)
        {
            if (selectedUnit != null && selectedUnitModel != null)
            {
                DialogResult usersChoice = MessageBox.Show(this, "Achtung: Eintrag \'" + selectedUnitModel.Name + "\' wirklich löschen?", "Warnung - Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (usersChoice == DialogResult.Yes)
                {
                    selectedUnit.ListEntries.Remove(selectedUnitModel);
                    selectedUnitModel = null;
                    RefreshDetails();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PerformSearch();
            RefreshView();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            cmbUnitMiniature.Enabled = true;
            cmbUnitItem.Enabled = true;
            cmbUnitItem.Text = "";
            cmbUnitItem.SelectedItem = null;
            if (selectedUnitModel != null )
            {
                selectedUnitModel.Wargear = null;
                selectedUnitModel.IsWargear = false;
            }
        }

        private void btnRemoveMiniature_Click(object sender, EventArgs e)
        {
            cmbUnitMiniature.Enabled = true;
            cmbUnitItem.Enabled = true;
            cmbUnitMiniature.Text = "";
            cmbUnitMiniature.SelectedItem = null;
            if (selectedUnitModel != null)
            {
                selectedUnitModel.Miniature = null;
                selectedUnitModel.IsWargear = false;
            }
        }

        private void cmbUnitItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedUnit != null && selectedUnitModel != null && cmbUnitItem.SelectedItem != null)
            {
                cbReplaceWargear.Enabled = true;
                cmbReplaceableWargear.Enabled = true;
                selectedUnitModel.IsWargear = true;
                selectedUnitModel.Wargear = (ModelClasses.Item)cmbUnitItem.SelectedItem;
                selectedUnitModel.Miniature = null;

                cmbReplaceableModel.Enabled = false;
                cbReplaceModel.Enabled = false;

                selectedUnitModel.ModelToReplace = null;

                RefreshListEntry();
            }
        }

        private void cbReplaceWargear_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedUnit != null && selectedUnitModel != null)
            {
                selectedUnitModel.IsWargearReplacment = cbReplaceWargear.Checked;

                if (selectedUnitModel.IsWargearReplacment)
                {
                    cmbReplaceableWargear.Enabled = true;
                }
                else
                {
                    cmbReplaceableWargear.Enabled = false;
                }
            }
        }

        private void cmbReplaceableWargear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedUnit != null && selectedUnitModel != null && cmbReplaceableWargear.SelectedItem != null)
            {
                selectedUnitModel.WargearToReplace = new ModelClasses.Item();
                selectedUnitModel.WargearToReplace = (ModelClasses.Item)cmbReplaceableWargear.SelectedItem;
            }
        }

        private void cmbReplaceableModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedUnit != null && selectedUnitModel != null && cmbReplaceableModel.SelectedItem != null)
            {
                selectedUnitModel.ModelToReplace = null;
                ModelClasses.UnitModel tmpModel = new ModelClasses.UnitModel((ModelClasses.UnitModel)cmbReplaceableModel.SelectedItem);
                if (tmpModel != null)
                {
                    if (tmpModel.Points == 0)
                    {
                        int basecost = 0;
                        // This model is included in the unit basepoints - for replacement 
                        if (selectedUnit.MatchedPoints != 0 && tmpModel.Count != 0)
                        {
                            basecost = selectedUnit.MatchedPoints / tmpModel.Count;
                        }

                        tmpModel.Points = basecost;
                    }

                    edited = true;
                    selectedUnitModel.ModelToReplace = new ModelClasses.UnitModel(tmpModel);
                    tmpModel = null;
                }
            }
        }

        private void btnSetPoints_Click(object sender, EventArgs e)
        {
            if (selectedUnit != null && selectedUnitModel != null)
            {
                selectedUnitModel.Count = GetIntVal(numModelCount.Value);
                selectedUnitModel.CountLimit = GetIntVal(numModelCountLimit.Value);
                selectedUnitModel.Points = GetIntVal(numModelPoints.Value);
                selectedUnitModel.PowerLevel = GetIntVal(numModelPowerLevel.Value);
            }
        }

        private Int32 GetIntVal(Decimal decVal)
        {
            Int32 tmp = 0;
            try
            {
                tmp = Convert.ToInt32(decVal);
            }
            catch
            {
                tmp = 0;
            }

            return tmp;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (selectedUnit != null)
            {
                DialogResult usersChoice = MessageBox.Show(this, "Willst Du die Einheit \'" + selectedUnit.Name + "\' wirklich löschen?", "Achtung!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (usersChoice == DialogResult.Yes)
                {
                    definedUnits.Remove(selectedUnit);
                    if (foundUnits != null && foundUnits.Any())
                    {
                        try
                        {
                            foundUnits.Remove(selectedUnit);
                        }
                        catch
                        {

                        }
                    }

                    selectedUnit = null;

                    PerformSearch();
                    RefreshView();
                    RefreshDetails();
                    ClearDetails();
                    ClearEntry();
                    DisableListEntryPanel();
                }
            }
        }
    }
}
