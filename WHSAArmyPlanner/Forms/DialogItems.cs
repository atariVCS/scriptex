/*"scriptex" Scriptorum Exercitus - Armylist planning tool for tabletop games
* (c) 2017 by Matthias Breiter. Licensed under the Terms of the Apache 2.0 License
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WHSAArmyPlanner.Forms
{
    public partial class DialogItems : Form
    {
        Boolean edited = false;

        String factionsFile = Settings.Instance.FactionsFile;
        String itemsFile = Settings.Instance.ItemsFile;

        ModelClasses.Items allItems = new ModelClasses.Items();
        ModelClasses.Items selectedItems = new ModelClasses.Items();
        ModelClasses.Item selectedItem = new ModelClasses.Item();
        List<ModelClasses.Item> foundItems = new List<ModelClasses.Item>();
        ModelClasses.Factions factions = new ModelClasses.Factions();

        public DialogItems()
        {
            InitializeComponent();
        }

        private void LoadItems()
        {
            FileStream fsFaction = null;
            FileStream fsItems = null;

            selectedItem = null;
            selectedItems = null;

            try
            {
                XmlSerializer factionSerializer = new XmlSerializer(typeof(ModelClasses.Factions));
                fsFaction = new FileStream(factionsFile, FileMode.Open);
                factions = (ModelClasses.Factions)factionSerializer.Deserialize(fsFaction);
                fsFaction.Close();
            }
            catch (Exception excp)
            {
                if (fsFaction != null)
                {
                    fsFaction.Dispose();
                }
            }

            try
            {
                foundItems.Clear();
                XmlSerializer itemsSerializer = new XmlSerializer(typeof(ModelClasses.Items));
                fsItems = new FileStream(itemsFile, FileMode.Open);
                allItems = (ModelClasses.Items)itemsSerializer.Deserialize(fsItems);
                fsItems.Close();

                foreach (ModelClasses.Item item in allItems)
                {
                    foundItems.Add(item);
                }
            }
            catch (Exception excp)
            {
                if (fsItems != null)
                {
                    fsItems.Dispose();
                }
            }
        }

        private void RefreshView()
        {
            clbSelection.Items.Clear();
            cmbFaction.Items.Clear();

            if (factions != null && factions.Any())
            {
                foreach (ModelClasses.Faction faction in factions)
                {
                    cmbFaction.Items.Add(faction);
                }
            }

            if (foundItems != null && foundItems.Any())
            {
                foreach(ModelClasses.Item item in foundItems)
                {
                    clbSelection.Items.Add(item);
                }
            }

            cmbFaction.Text = "";
            cmbFaction.SelectedItem = null;

            txtInput.Text = "";

            RefreshDetails();

            if (selectedItems == null)
            {
            }
        }

        private void RefreshDetails()
        {
            cmbSeletedFaction.Enabled = false;
            txtSelectedName.Enabled = false;

            if (selectedItem != null)
            {
                txtExtraText.Enabled = true;
                cmbSeletedFaction.SelectedItem = selectedItem.AllowedFaction;
                cmbSeletedFaction.Text = selectedItem.AllowedFaction.Name;
                txtSelectedName.Text = selectedItem.Name;
                numMatchPoints.Value = selectedItem.Points;
                txtExtraText.Text = selectedItem.ExtraText;

                txtRange.Text = selectedItem.Range;
                txtRangedAbility.Text = selectedItem.RangedAbility;
                txtRangedAp.Text = selectedItem.RangedAp.ToString();
                txtRangedDamage.Text = selectedItem.RangedDamage;
                txtRangedStrength.Text = selectedItem.RangedStrength;
                txtRangedType.Text = selectedItem.RangedType;

                txtMeleeAp.Text = selectedItem.MeleeAP.ToString();
                txtMeleeDamage.Text = selectedItem.MeleeDamage;
                txtMeleeStrength.Text = selectedItem.MeleeStrength;
                txtMeleeType.Text = selectedItem.MeleeType;
                txtMeleeAbility.Text = selectedItem.MeleeAbility;
            }
            else
            {
                txtExtraText.Enabled = false;
                cmbSeletedFaction.SelectedItem = null;
                cmbSeletedFaction.Text = "";
                txtSelectedName.Text = "";

                txtRange.Text = "";
                txtRangedAbility.Text = "";
                txtRangedAp.Text = "";
                txtRangedDamage.Text = "";
                txtRangedStrength.Text = "";
                txtRangedType.Text = "";

                txtMeleeAp.Text = "";
                txtMeleeDamage.Text = "";
                txtMeleeStrength.Text = "";
                txtMeleeType.Text = "";
                txtMeleeAbility.Text = "";
            }
        }

        private void Save()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModelClasses.Items));
                TextWriter writer = new StreamWriter(itemsFile);

                if (allItems != null && allItems.Any())
                {
                    serializer.Serialize(writer, allItems);
                }

                writer.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Oh Oh, ich kann nicht speichern: " + e.Message);
            }
        }

        private void DialogItems_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foundItems.Clear();
            foundItems = allItems.FindAll(x => x.ToString().StartsWith(txtSearchtext.Text,StringComparison.InvariantCultureIgnoreCase));
            selectedItem = null;
            selectedItems = null;

            clbSelection.Items.Clear();

            if (foundItems != null && foundItems.Any())
            {
                foreach (ModelClasses.Item foundItem in foundItems)
                {
                    clbSelection.Items.Add(foundItem);
                }
            }
        }

        private void DialogItems_Load(object sender, EventArgs e)
        {
            LoadItems();
            RefreshView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtInput.Text) && cmbFaction.SelectedItem != null)
            {
                ModelClasses.Item newItem = new ModelClasses.Item();
                newItem.AllowedFaction = (ModelClasses.Faction)cmbFaction.SelectedItem;
                newItem.Name = txtInput.Text;

                if (allItems.AddItem(newItem))
                {
                    selectedItem = newItem;
                    foundItems.Add(newItem);
                    edited = true ;
                }
                else
                {
                    selectedItem = null;
                }

                RefreshView();
            }

        }

        private void clbSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbSelection.SelectedItem != null)
            {
                selectedItem = (ModelClasses.Item)clbSelection.SelectedItem;
                RefreshDetails();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
            edited = false;
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                cmbSeletedFaction.Enabled = true;
                txtSelectedName.Enabled = true;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Save();
            edited = false;
        }

        #region Profil
        private void txtExtraText_TextChanged(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                selectedItem.ExtraText = txtExtraText.Text;
                edited = true;
            }
        }

        private void txtRange_TextChanged(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                if (String.IsNullOrWhiteSpace(txtRange.Text))
                {
                    selectedItem.Range = "";
                    edited = true;
                }
                else
                {
                    selectedItem.Range = txtRange.Text;
                    edited = true;
                }
            }
        }

        private void numMatchPoints_ValueChanged(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                try
                {
                    selectedItem.Points = Convert.ToInt32(numMatchPoints.Value);
                    edited = true;
                }
                catch
                {
                    selectedItem.Points = 0;
                }
            }
        }

        private void txtRangedType_TextChanged(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                selectedItem.RangedType = txtRangedType.Text;
                edited = true;
            }
        }

        private void txtRangedStrength_TextChanged(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                selectedItem.RangedStrength = txtRangedStrength.Text;
                edited = true;
            }
        }

        private void txtRangedAp_TextChanged(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                try
                {
                    if (String.IsNullOrWhiteSpace(txtRangedAp.Text))
                    {
                        selectedItem.RangedAp = 0;
                        edited = true;
                    }
                    else
                    {
                        selectedItem.RangedAp = Convert.ToInt32(txtRangedAp.Text);
                        edited = true;
                    }
                }
                catch
                {
                    selectedItem.RangedAp = 0;
                }
            }
        }

        private void txtRangedDamage_TextChanged(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                selectedItem.RangedDamage = txtRangedDamage.Text;
                edited = true;
            }
        }

        private void txtRangedAbility_TextChanged(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                selectedItem.RangedAbility = txtRangedAbility.Text;
                edited = true;
            }
        }

        private void txtMeleeType_TextChanged(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                selectedItem.MeleeType = txtMeleeType.Text;
                edited = true;
            }
        }

        private void txtMeleeStrength_TextChanged(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                selectedItem.MeleeStrength = txtMeleeStrength.Text;
                edited = true;
            }
        }

        private void txtMeleeAp_TextChanged(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                try
                {
                    if (String.IsNullOrWhiteSpace(txtMeleeAp.Text))
                    {
                        selectedItem.MeleeAP = 0;
                        edited = true;
                    }
                    else
                    {
                        selectedItem.MeleeAP = Convert.ToInt32(txtMeleeAp.Text);
                        edited = true;
                    }
                }
                catch
                {
                    selectedItem.MeleeAP = 0;
                }
            }
        }

        private void txtMeleeDamage_TextChanged(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                selectedItem.MeleeDamage = txtMeleeDamage.Text;
                edited = true;
            }
        }

        private void txtMeleeAbility_TextChanged(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                selectedItem.MeleeAbility = txtMeleeAbility.Text;
                edited = true;
            }
        }
        #endregion

        private void txtSelectedName_TextChanged(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                selectedItem.Name = txtSelectedName.Text;
            }
        }
    }
}
