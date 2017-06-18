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

namespace WHSAArmyPlanner.Forms
{
    public partial class DialogDetachments : Form
    {
        Boolean edited = false;

        String battleRolesFile = Settings.Instance.BattlerolesFile;
        String detachmentsFile = Settings.Instance.DetachmentsFile;

        ModelClasses.BattleRoles battleRoleTemplates = new ModelClasses.BattleRoles();
        ModelClasses.Detachments detachmentTemplates = new ModelClasses.Detachments();
        ModelClasses.Detachment detachment = null;
        ModelClasses.Slot selectedSlot = null;

        public DialogDetachments()
        {
            InitializeComponent();
        }

        private void Detachments_Load(object sender, EventArgs e)
        {
            LoadTemplates();
        }

        private void RefreshView()
        {
            txtDetachmentName.Text = "";
            txtInput.Text = "";
            cmbBattleRoles.Items.Clear();
            lbDetachment.Items.Clear();
            lbSlots.Items.Clear();
            lblSlotname.Text = "";
            cbFaction.Checked = false;
            cbIncludeTransports.Checked = false;
            numMin.Value = 0;
            numMax.Value = 0;
            numCP.Value = 0;

            foreach (ModelClasses.BattleRole role in battleRoleTemplates)
            {
                cmbBattleRoles.Items.Add(role);
            }

            foreach (ModelClasses.Detachment detachment in detachmentTemplates)
            {
                lbDetachment.Items.Add(detachment);
            }
        }

        private void LoadTemplates()
        {
            FileStream fsBattleRole = null;
            FileStream fsDetachment = null;

            try
            {
                XmlSerializer battleRoleSerializer = new XmlSerializer(typeof(ModelClasses.BattleRoles));
                fsBattleRole = new FileStream(battleRolesFile, FileMode.Open);
                battleRoleTemplates = (ModelClasses.BattleRoles)battleRoleSerializer.Deserialize(fsBattleRole);
                fsBattleRole.Close();
            }
            catch (Exception excp)
            {
                if (fsBattleRole != null)
                {
                    fsBattleRole.Dispose();
                }
            }

            try
            {
                XmlSerializer detachmentSerializer = new XmlSerializer(typeof(ModelClasses.Detachments));
                fsDetachment = new FileStream(detachmentsFile, FileMode.Open);
                detachmentTemplates = (ModelClasses.Detachments)detachmentSerializer.Deserialize(fsDetachment);
                fsDetachment.Close();
            }
            catch (Exception excp)
            {
                if (fsDetachment != null)
                {
                    fsDetachment.Dispose();
                }
            }
            
            RefreshView();
        }

        private Boolean Save()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModelClasses.Detachments));
                TextWriter writer = new StreamWriter(detachmentsFile);

                if (detachmentTemplates.Any())
                {
                    serializer.Serialize(writer, detachmentTemplates);
                }

                writer.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void RefreshDetachment()
        {
            if (detachment != null)
            {
                txtDetachmentName.Text = detachment.Name;
                cbFaction.Checked = detachment.AllowsSingleFactionOnly;
                cbIncludeTransports.Checked = detachment.DoesContainTransports;
                numCP.Value = detachment.CommandPoints;

                lbSlots.Items.Clear();

                foreach (ModelClasses.Slot slot in detachment.Slots)
                {
                    lbSlots.Items.Add(slot);
                }
            }
        }

        private void RefreshSlotInfo()
        {
            if (detachment != null)
            {
                if (selectedSlot != null)
                {
                    lblSlotname.Text = selectedSlot.BattleRole.Name;
                    numMin.Value = selectedSlot.MinimumUnits;
                    numMax.Value = selectedSlot.MaximumUnits;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtInput.Text))
            {
                ModelClasses.Detachment newDetachment = new ModelClasses.Detachment();
                newDetachment.Name = txtInput.Text;
                newDetachment.Slots = new List<ModelClasses.Slot>();
                newDetachment.CommandPoints = 0;
                detachmentTemplates.AddDetachment(newDetachment);
                edited = true;
                RefreshView();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (detachment != null)
            {
                DialogResult userFeedback = MessageBox.Show(this, "Wollen sie das gewählte Detachment \'" +detachment.Name + "\'wirklich löschen?", "Achtung", MessageBoxButtons.YesNo);
                if (userFeedback == DialogResult.Yes)
                {
                    detachmentTemplates.Remove(detachment);
                    detachment = null;
                    edited = true;
                    RefreshView();
                }
            }
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
            edited = false;
        }

        private void DialogDetachments_FormClosing(object sender, FormClosingEventArgs e)
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

        #region Profile

        private void lbDetachment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDetachment.SelectedItem != null)
            {
                detachment = (ModelClasses.Detachment)lbDetachment.SelectedItem;
                edited = true;
                RefreshDetachment();
            }
        }
        
        private void numCP_ValueChanged(object sender, EventArgs e)
        {
            if (detachment != null)
            {
                detachment.CommandPoints = Convert.ToInt32(numCP.Value);
                edited = true;
            }
        }

        private void txtDetachmentName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtDetachmentName.Text))
            {
                if (detachment != null)
                {
                    detachment.Name = txtDetachmentName.Text;
                    edited = true;
                }
            }
        }

        private void btnEditName_Click(object sender, EventArgs e)
        {
            if (detachment != null)
            {
                txtDetachmentName.Enabled = !txtDetachmentName.Enabled;
                edited = true;
            }
        }

        private void cbFaction_CheckedChanged(object sender, EventArgs e)
        {
            if (detachment != null)
            {
                detachment.AllowsSingleFactionOnly = cbFaction.Checked;
                edited = true;
            }
        }

        private void cbIncludeTransports_CheckedChanged(object sender, EventArgs e)
        {
            if (detachment != null)
            {
                detachment.DoesContainTransports = cbIncludeTransports.Checked;

                bool alreadyExists = false;

                if (detachment.DoesContainTransports)
                {
                    foreach (ModelClasses.Slot existingslot in detachment.Slots)
                    {
                        if (existingslot.BattleRole != null && existingslot.BattleRole.Name == "Transport")
                        {
                            alreadyExists = true;
                            break;
                        }
                    }

                    if (!alreadyExists)
                    {
                        ModelClasses.Slot transportSlot = new ModelClasses.Slot();
                        transportSlot.BattleRole = new ModelClasses.BattleRole();
                        transportSlot.BattleRole.Name = "Transport";
                        detachment.Slots.Add(transportSlot);
                    }
                }
                else
                {
                    ModelClasses.Slot foundSlot = null;
                    foreach (ModelClasses.Slot existingslot in detachment.Slots)
                    {
                        if (existingslot.BattleRole != null && existingslot.BattleRole.Name == "Transport")
                        {
                            alreadyExists = true;
                            foundSlot = existingslot;
                            break;
                        }
                    }

                    if (alreadyExists)
                    {
                        detachment.Slots.Remove(foundSlot);
                    }
                }

                RefreshDetachment();
                edited = true;
            }
        }

        private void btnAddSlot_Click(object sender, EventArgs e)
        {
            if (detachment != null)
            {
                if (cmbBattleRoles.SelectedItem != null)
                {
                    Boolean IsSlotAlreadyAssigned = false;
                    ModelClasses.BattleRole selectedRole = (ModelClasses.BattleRole)cmbBattleRoles.SelectedItem;
                    ModelClasses.Slot newSlot = new ModelClasses.Slot();
                    newSlot.BattleRole = selectedRole;
                    newSlot.MinimumUnits = 0;
                    newSlot.MaximumUnits = 0;

                    foreach(ModelClasses.Slot slot in detachment.Slots)
                    {
                        if (slot.BattleRole.Name == newSlot.BattleRole.Name)
                        {
                            IsSlotAlreadyAssigned = true;
                            break;
                        }
                    }

                    if (!IsSlotAlreadyAssigned)
                    {
                        detachment.Slots.Add(newSlot);
                        edited = true;
                        RefreshDetachment();
                    }
                }
            }
        }

        private void lbSlots_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (detachment != null)
            {
                if (lbSlots.SelectedItem != null)
                {
                    selectedSlot = (ModelClasses.Slot)lbSlots.SelectedItem;
                    RefreshSlotInfo();
                }
            }
        }

        private void numMin_ValueChanged(object sender, EventArgs e)
        {
            if (detachment != null && selectedSlot != null)
            {
                selectedSlot.MinimumUnits = Convert.ToInt32(numMin.Value);
                edited = true;
            }
        }

        private void numMax_ValueChanged(object sender, EventArgs e)
        {
            if (detachment != null && selectedSlot != null)
            {
                selectedSlot.MaximumUnits = Convert.ToInt32(numMax.Value);
                edited = true;
            }
        }

        #endregion
        
    }
}
