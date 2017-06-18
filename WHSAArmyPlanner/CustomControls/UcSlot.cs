using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WHSAArmyPlanner.CustomControls
{
    public partial class UcSlot : UserControl
    {
        public Boolean IsRequired { get; set; }
        public Boolean IsFilled { get; set; }

        public event EventHandler OnUnitChanged;

        public ModelClasses.Unit CreatedUnit { get; set; }
        public ModelClasses.Unit UnitTemplate { get; set; }
        public ModelClasses.Units PossibleUnits { get; set; }

        ModelClasses.UnitModel userSelectedEntry = null;

        int number = 0;

        public UcSlot()
        {
            InitializeComponent();
            IsFilled = false;
        }

        public UcSlot(ModelClasses.Units FilteredUnits, int number)
        {
            InitializeComponent();
            PossibleUnits = FilteredUnits;
            this.number = number;
        }
        
        public UcSlot(ModelClasses.Units FilteredUnits, int number, ModelClasses.Unit existingUnit)
        {
            InitializeComponent();
            PossibleUnits = FilteredUnits;
            this.number = number;
            CreatedUnit = existingUnit;
            IsFilled = true;
        }

        public void SetPos(Point xy)
        {
            this.Location = xy;
        }

        #region Redraws / Refreshs

        private void RefreshView()
        {
            if (IsRequired)
            {
                lblIndicator.BackColor = Color.Firebrick;
            }
            else
            {
                lblIndicator.BackColor = Color.LightGray;
            }

            if (IsFilled)
            {
                lblIndicator.BackColor = Color.MediumSeaGreen;
                btnLock.Enabled = true;
                cmbUnitTemplate.Enabled = false;
            }
            else
            {
                btnLock.Enabled = false;
                cmbUnitTemplate.Enabled = true;
            }

            lblUnitNUmber.Text = number.ToString("00");

            cmbUnitTemplate.Items.Clear();
            if (PossibleUnits != null)
            {
                foreach (ModelClasses.Unit unit in PossibleUnits)
                {
                    cmbUnitTemplate.Items.Add(unit);
                }
            }

            if (CreatedUnit != null)
            {
                foreach (ModelClasses.Unit unit in PossibleUnits)
                {
                    if (unit.Name == CreatedUnit.Name)
                    {
                        UnitTemplate = unit;
                        break;
                    }
                }
                
                InitModelTemplateList();

                lbActualComposition.Items.Clear();
                
                foreach (ModelClasses.UnitModel entry in CreatedUnit.ListEntries)
                {
                    lbActualComposition.Items.Add(entry);
                }
            }

            RefreshValidation();
        }

        private void FireChangedEvent()
        {
            if (OnUnitChanged != null)
            {
                OnUnitChanged(this, null);
            }
        }

        private void InitModelTemplateList()
        {
            if (CreatedUnit != null && UnitTemplate != null)
            {
                lbAllModels.Items.Clear();

                foreach (ModelClasses.UnitModel model in UnitTemplate.ListEntries)
                {
                    lbAllModels.Items.Add(model);
                }
            }
        }

        private void RefreshModelsInList()
        {
            lbActualComposition.Items.Clear();

            foreach (ModelClasses.UnitModel entry in CreatedUnit.ListEntries)
            {
                lbActualComposition.Items.Add(entry);
            }
        }

        private void RefreshValidation()
        {
            if (CreatedUnit != null)
            {
                lblPLVal.Text = CreatedUnit.CurrentPowerLevel.ToString();
                lblPointsVal.Text = CreatedUnit.CurrentPoints.ToString();
            }
        }

        private void RefreshEntryView()
        {
            if (userSelectedEntry == null)
            {
                ClearEntry();
            }
            else
            {
                if (userSelectedEntry.IsWargear && userSelectedEntry.Wargear != null)
                {
                    ClearEntry();
                    lblName.Text = "Waffe / Wargear " + userSelectedEntry.Name;
                    numExtraModels.Value = userSelectedEntry.ExtraModelsCount;
                    numExtraModels.Maximum = userSelectedEntry.CountLimit - userSelectedEntry.Count;

                    if (userSelectedEntry.IsReplacement && userSelectedEntry.ModelToReplace != null)
                    {
                        lblReplacementInfo.Text = userSelectedEntry.ModelToReplace.Name;
                    }
                }
                else
                {
                    lblName.Text = userSelectedEntry.Name;
                    numExtraModels.Maximum = userSelectedEntry.CountLimit - userSelectedEntry.Count;
                    numExtraModels.Value = userSelectedEntry.ExtraModelsCount;
                   
                    if(userSelectedEntry.IsReplacement && userSelectedEntry.ModelToReplace != null)
                    {
                        lblReplacementInfo.Text = userSelectedEntry.ModelToReplace.Name; 
                    }

                    if (userSelectedEntry.Miniature != null)
                    {
                        lblLeadership.Text = userSelectedEntry.Miniature.LeaderShip;
                        lblMovement.Text = userSelectedEntry.Miniature.Movement;
                        lblSave.Text = userSelectedEntry.Miniature.Save;
                        lblStrength.Text = userSelectedEntry.Miniature.Strength;
                        lblToughness.Text = userSelectedEntry.Miniature.Toughness;
                        lblWounds.Text = userSelectedEntry.Miniature.Wounds;
                        lblWS.Text = userSelectedEntry.Miniature.Weaponskill;
                        lblBS.Text = userSelectedEntry.Miniature.BallisticSkill;
                        lblAttacks.Text = userSelectedEntry.Miniature.Attacks;
                    }
                }
            }
        }

        private void ClearEntry()
        {
            lblLeadership.Text= "-";
            lblMovement.Text = "-";
            lblName.Text = "-";
            lblMP.Text = "-";
            lblSave.Text = "-";
            lblStrength.Text = "-";
            lblToughness.Text = "-";
            lblWounds.Text = "-";
            lblWS.Text = "-";
        }

        #endregion

        private void UcSlot_Load(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void cmbUnitTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUnitTemplate.SelectedItem != null)
            {
                UnitTemplate = (ModelClasses.Unit)cmbUnitTemplate.SelectedItem;
                CreatedUnit = new ModelClasses.Unit(UnitTemplate);
                CreatedUnit.ListEntries.Clear();
                InitModelTemplateList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CreatedUnit != null && lbAllModels.SelectedItem != null)
            {
                ModelClasses.UnitModel selectedEntry = (ModelClasses.UnitModel)lbAllModels.SelectedItem;

                if (CreatedUnit.ListEntries.Count < 1 && selectedEntry.IsUpgradeOnly)
                {
                    MessageBox.Show("Dieser Listeneintrag ist ein Update [U], er kann nur zu vorhandenen Basis-Einträgen hinzugefügt werden.");
                }
                else
                {
                    ModelClasses.UnitModel newModel = new ModelClasses.UnitModel(selectedEntry);
                    ActionResult res = new ActionResult();
                    res = CreatedUnit.InsertEntry(newModel);

                    if (res.Success)
                    {
                        IsFilled = true;
                        RefreshView();
                        RefreshModelsInList();
                        FireChangedEvent();
                    }
                    else
                    {
                        MessageBox.Show("Dieser Eintrag kann nicht hinzugefügt werden: \r\n" + res.Message);
                    }
                }
            }
        }

        private void lbActualComposition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbActualComposition.SelectedItem != null)
            {
                userSelectedEntry = (ModelClasses.UnitModel)lbActualComposition.SelectedItem;
                RefreshEntryView();
            }
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            if (IsFilled)
            {
                if (cmbUnitTemplate.Enabled)
                {
                    cmbUnitTemplate.Enabled = false;
                }
                else
                {
                    DialogResult usersChoice = MessageBox.Show(this, "Wenn Du die gewählte Grund-Einheit änderst, verlierst Du Deine eigenen Einstellungen. Möchtest Du fortfahren?", "Vorsicht", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (usersChoice == DialogResult.Yes)
                    {
                        cmbUnitTemplate.Enabled = true;
                    }
                    else
                    {
                        cmbUnitTemplate.Enabled = false;
                    }
                }
            }
        }

        private void numExtraModels_ValueChanged(object sender, EventArgs e)
        {
            if (userSelectedEntry != null)
            {
                int newModelCount = Convert.ToInt32(numExtraModels.Value);
                int oldModelCount = userSelectedEntry.ExtraModelsCount;

                if (userSelectedEntry.DidModelCountChange(newModelCount))
                {
                    #region Try to Change values
                    String extraCost = "";
                    try
                    {
                        ModelClasses.UnitModel tmpModel = new ModelClasses.UnitModel(userSelectedEntry);

                        tmpModel.ExtraModelsCount = newModelCount;
                        var testval = tmpModel.CurrentModelCount;

                        ActionResult res = new ActionResult();
                        if (newModelCount > oldModelCount)
                        {
                            res = CreatedUnit.TestUpgrade(tmpModel);
                        }
                        else
                        {
                            res.Success = true;
                        }

                        if (!res.Success)
                        {
                            userSelectedEntry.ExtraModelsCount = oldModelCount;
                            numExtraModels.Value = oldModelCount;
                            MessageBox.Show("Kann diesen Eintrag nicht eweitern: " + res.Message);
                        }
                        else
                        {
                            userSelectedEntry.ExtraModelsCount = tmpModel.ExtraModelsCount;
                            extraCost = "(+" + (userSelectedEntry.CurrentPowerlevel - userSelectedEntry.PowerLevel) + " PL/ +" + (userSelectedEntry.CurrentPoints - userSelectedEntry.Points) + " Pkt)";
                            lblExtraCosts.Text = extraCost;
                            RefreshValidation();
                            FireChangedEvent();
                        }

                    }
                    catch
                    {
                        userSelectedEntry.ExtraModelsCount = 0;
                        extraCost = "(+ PL/ + Pkt)";
                        lblExtraCosts.Text = extraCost;
                        RefreshValidation();
                        FireChangedEvent();
                    }
                    #endregion
                }
                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (CreatedUnit != null && CreatedUnit.ListEntries.Any())
            {
                DialogResult usersChoice = MessageBox.Show(this, "Willst Du die Einheit wirklich entfernen?", "Vorsicht", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (usersChoice == DialogResult.Yes)
                {
                    cmbUnitTemplate.Enabled = true;
                    lbActualComposition.Items.Clear();
                    IsFilled = false;
                    UnitTemplate = new ModelClasses.Unit();
                    ClearEntry();
                    FireChangedEvent();
                    RefreshView();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (CreatedUnit != null && CreatedUnit.ListEntries != null && userSelectedEntry != null)
            {
                try
                {
                    CreatedUnit.ListEntries.Remove((ModelClasses.UnitModel)userSelectedEntry);
                    userSelectedEntry = null;
                    ClearEntry();
                    RefreshModelsInList();
                    RefreshEntryView();
                    RefreshValidation();
                }
                catch
                {

                }
            }
        }
    }
}
