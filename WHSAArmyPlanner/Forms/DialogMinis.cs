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
    public partial class DialogMinis : Form
    {
        String miniaturesFile = Settings.Instance.MiniatureFile;
        String factionsFile = Settings.Instance.FactionsFile;
        String itemsFile = Settings.Instance.ItemsFile;

        Boolean edited = false;

        ModelClasses.Miniatures allMiniatures = new ModelClasses.Miniatures();
        ModelClasses.Miniature selectedMini = null;
        ModelClasses.Miniatures foundMiniatures = new ModelClasses.Miniatures();
        ModelClasses.Item selectedGear = null;
        ModelClasses.Factions allFactions = new ModelClasses.Factions();
        ModelClasses.Items allWargear = new ModelClasses.Items(); 
        ModelClasses.Items wargearForFaction = new ModelClasses.Items();
        
        public DialogMinis()
        {
            InitializeComponent();
        }

        private void Save()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModelClasses.Miniatures));
                TextWriter writer = new StreamWriter(miniaturesFile);

                if (allMiniatures != null && allMiniatures.Any())
                {
                    serializer.Serialize(writer, allMiniatures);
                }

                writer.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Oh Oh, ich kann nicht speichern: " + e.Message);
            }
        }

        private void LoadProcedure()
        {
            LoadMiniatures();
            LoadFactions();
            LoadWargear();

            RefreshView();
        }

        private void LoadMiniatures()
        {
            FileStream fs = null;
            foundMiniatures.Clear();

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModelClasses.Miniatures));
                fs = new FileStream(miniaturesFile, FileMode.Open);
                allMiniatures = (ModelClasses.Miniatures)serializer.Deserialize(fs);

                foreach(ModelClasses.Miniature mini in allMiniatures)
                {
                    foundMiniatures.Add(mini);
                }

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

        private void LoadFactions()
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

        private void LoadWargear()
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

        private void RefreshView()
        {
            lbMinis.Items.Clear();

            cmbModelFaction.Items.Clear();
            cmbFaction.Items.Clear();

            txtModelName.Enabled = false;
            cmbModelFaction.Enabled = false;

            foreach (ModelClasses.Miniature model in foundMiniatures)
            {
                lbMinis.Items.Add(model);
            }

            foreach (ModelClasses.Faction faction in allFactions)
            {
                cmbFaction.Items.Add(faction);
                cmbModelFaction.Items.Add(faction);
            }
        }

        public void RefreshDetails()
        {
            txtModelName.Enabled = false;
            cmbModelFaction.Enabled = false;
            cmbStandardGear.Items.Clear();
            lbStandardGear.Items.Clear();

            if (selectedMini != null)
            {
                txtModelName.Text = selectedMini.Name;
                cmbModelFaction.Text = selectedMini.Faction.Name;
                cmbModelFaction.SelectedItem = selectedMini.Faction;
                txtMovement.Text = selectedMini.Movement;
                txtAbilities.Text = selectedMini.Abilities;
                txtAttacks.Text = selectedMini.Attacks;
                txtKeywords.Text = selectedMini.Keywords;
                txtLeadership.Text = selectedMini.LeaderShip;
                txtSave.Text = selectedMini.Save;
                txtStrength.Text = selectedMini.Strength;
                txtWounds.Text = selectedMini.Wounds;
                txtWs.Text = selectedMini.Weaponskill;
                txtBs.Text = selectedMini.BallisticSkill;
                txtToughness.Text = selectedMini.Toughness;

                cmbStandardGear.Items.Clear();

                GetFactionsWargear();
                
                foreach(ModelClasses.Item possibleItem in wargearForFaction)
                {
                    cmbStandardGear.Items.Add(possibleItem);
                }

                RefreshStandardGear();
            }
            else
            {
                txtModelName.Text = "";
                cmbModelFaction.Text = "";
                cmbModelFaction.SelectedItem = null;
                txtMovement.Text = "";
                txtAbilities.Text = "";
                txtAttacks.Text = "";
                txtKeywords.Text = "";
                txtLeadership.Text = "";
                txtSave.Text = "";
                txtStrength.Text = "";
                txtWounds.Text = "";
                txtWs.Text = "";
                txtBs.Text = "";
                txtToughness.Text = "";
            }
        }

        public void RefreshStandardGear()
        {
            lbStandardGear.Items.Clear();

            foreach (ModelClasses.Item itm in selectedMini.StandardEquip)
            {
                lbStandardGear.Items.Add(itm);
            }
        }

        public void GetFactionsWargear()
        {
            if (selectedMini != null)
            {
                wargearForFaction.Clear();

                foreach (ModelClasses.Item gear in allWargear)
                {
                    if (gear.AllowedFaction.Name == selectedMini.Faction.Name)
                    {
                        wargearForFaction.Add(gear);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedMini != null)
            {
                txtModelName.Enabled = true;
                cmbModelFaction.Enabled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PerformSearch();
            RefreshView();
        }

        private void PerformSearch()
        {
            foundMiniatures.Clear();

            if (String.IsNullOrWhiteSpace(txtSearch.Text))
            {
                foreach (ModelClasses.Miniature model in allMiniatures)
                {
                    foundMiniatures.Add(model);
                }
            }
            else
            {
                foreach (ModelClasses.Miniature model in allMiniatures)
                {
                    if (model.ToString().StartsWith(txtSearch.Text, StringComparison.InvariantCultureIgnoreCase))
                    {
                        foundMiniatures.Add(model);
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbFaction.SelectedItem != null && !String.IsNullOrWhiteSpace(txtInput.Text))
            {
                ModelClasses.Miniature newMini = new ModelClasses.Miniature();
                newMini.Faction = (ModelClasses.Faction)cmbFaction.SelectedItem;
                newMini.Name = txtInput.Text;

                if (allMiniatures.AddMiniature(newMini))
                {
                    selectedMini = newMini;
                    cmbFaction.SelectedItem = null;
                    cmbFaction.Text = "";
                    txtInput.Text = "";
                    edited = true;
                }

                PerformSearch();
                RefreshView();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (selectedMini != null)
            {
                DialogResult usersChoice = MessageBox.Show(this, "Soll die Miniatur wirklich gelöscht werden?", "Achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (usersChoice == DialogResult.Yes)
                {
                    allMiniatures.Remove(selectedMini);
                    selectedMini = null;
                    edited = true;
                }
            }
        }

        private void lbMinis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbMinis.SelectedItem != null)
            {
                selectedMini = (ModelClasses.Miniature)lbMinis.SelectedItem;
                RefreshDetails();
            }
        }
        
        private void DialogMinis_Load(object sender, EventArgs e)
        {
            LoadProcedure();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
            edited = false;
            Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Save();
            RefreshView();
            edited = false;
        }

        private void DialogMinis_FormClosing(object sender, FormClosingEventArgs e)
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

        #region Profilwerte

        private void cmbStandardGear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedMini != null)
            {
                if (cmbStandardGear.SelectedItem != null)
                {
                    selectedGear = (ModelClasses.Item)cmbStandardGear.SelectedItem;
                }
            }
        }

        private void lbStandardGear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedMini != null)
            {
                if (lbStandardGear.SelectedItem != null)
                {
                    selectedGear = (ModelClasses.Item)lbStandardGear.SelectedItem;
                }
            }
        }

        private void btnAddGear_Click(object sender, EventArgs e)
        {
            if (selectedMini != null)
            {
                if (selectedGear != null)
                {
                    selectedMini.StandardEquip.Add(selectedGear);
                    edited = true;
                }
            }

            RefreshStandardGear();
        }

        private void btnRemoveGear_Click(object sender, EventArgs e)
        {
            if (selectedMini != null)
            {
                if (selectedGear != null)
                {
                    selectedMini.StandardEquip.Remove(selectedGear);
                    edited = true;
                }

                RefreshStandardGear();
            }
        }

        private void cmbModelFaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedMini != null)
            {
                if (cmbModelFaction.SelectedItem != null)
                {
                    selectedMini.Faction = (ModelClasses.Faction)cmbModelFaction.SelectedItem;
                    edited = true;
                }
            }
        }

        private void txtModelName_TextChanged(object sender, EventArgs e)
        {
            if (selectedMini != null)
            {
                if (!String.IsNullOrWhiteSpace(txtModelName.Text))
                {
                    selectedMini.Name = txtModelName.Text;
                    edited = true;
                }
            }
        }

        private void txtMovement_TextChanged(object sender, EventArgs e)
        {
            if (selectedMini != null)
            {
                selectedMini.Movement = txtMovement.Text;
                edited = true;
            }
        }

        private void txtWs_TextChanged(object sender, EventArgs e)
        {
            if (selectedMini != null)
            {
                selectedMini.Weaponskill = txtWs.Text;
                edited = true;
            }
        }

        private void txtBs_TextChanged(object sender, EventArgs e)
        {
            if (selectedMini != null)
            {
                selectedMini.BallisticSkill = txtBs.Text;
                edited = true;
            }
        }

        private void txtStrength_TextChanged(object sender, EventArgs e)
        {
            if (selectedMini != null)
            {
                selectedMini.Strength = txtStrength.Text;
                edited = true;
            }
        }

        private void txtToughness_TextChanged(object sender, EventArgs e)
        {
            if (selectedMini != null)
            {
                selectedMini.Toughness = txtToughness.Text;
                edited = true;
            }
        }

        private void txtWounds_TextChanged(object sender, EventArgs e)
        {
            if (selectedMini != null)
            {
                selectedMini.Wounds = txtWounds.Text;
                edited = true;
            }
        }

        private void txtAttacks_TextChanged(object sender, EventArgs e)
        {
            if (selectedMini != null)
            {
                selectedMini.Attacks = txtAttacks.Text;
                edited = true;
            }
        }

        private void txtLeadership_TextChanged(object sender, EventArgs e)
        {
            if (selectedMini != null)
            {
                selectedMini.LeaderShip = txtLeadership.Text;
                edited = true;
            }
        }

        private void txtSave_TextChanged(object sender, EventArgs e)
        {
            if (selectedMini != null)
            {
                selectedMini.Save = txtSave.Text;
                edited = true;
            }
        }

        private void txtAbilities_TextChanged(object sender, EventArgs e)
        {
            if (selectedMini != null)
            {
                selectedMini.Abilities = txtAbilities.Text;
                edited = true;
            }
        }

        private void txtKeywords_TextChanged(object sender, EventArgs e)
        {
            if (selectedMini != null)
            {
                selectedMini.Keywords = txtKeywords.Text;
                edited = true;
            }
        }

        #endregion
        
    }
}
