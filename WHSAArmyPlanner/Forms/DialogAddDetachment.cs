using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WHSAArmyPlanner.Forms
{
    public partial class DialogAddDetachment : Form
    {
        Boolean isFixedFaction = false;
        
        ModelClasses.Detachments allDetachments = null;
        ModelClasses.Detachments possibleDetachments = new ModelClasses.Detachments();
       
        ModelClasses.Factions allFactions = null;
        ModelClasses.Factions possibleFactions = new ModelClasses.Factions();
        ModelClasses.Faction mainFaction = null;
        ModelClasses.Faction selectedFaction = null;
        Int32 numberOfDetachments = 0;

        public ModelClasses.Detachment Detachment { get; set; }
        
        public DialogAddDetachment(Boolean isFixedFaction, ModelClasses.Faction mainFaction, ModelClasses.Factions allFactions, ModelClasses.Detachments allDetachments, Int32 numberOfDetachments)
        {
            InitializeComponent();

            this.isFixedFaction = isFixedFaction;

            if (this.isFixedFaction)
            {
                this.mainFaction = mainFaction;
            }
            
            this.allFactions = allFactions;
            this.allDetachments = allDetachments;

            this.numberOfDetachments = numberOfDetachments;
        }

        private void RefreshView()
        {
            cmbFaction.Items.Clear();
            SetPossibleFactions();

            foreach (ModelClasses.Faction faction in possibleFactions)
            {
                cmbFaction.Items.Add(faction);
            }            
        }

        private void RefreshDetachments()
        {
            cmbDetachments.Items.Clear();
            SetPossibleDetachments();
          
            foreach (ModelClasses.Detachment det in possibleDetachments)
            {
                cmbDetachments.Items.Add(det);
            }
        }

        public void SetPossibleDetachments()
        {
            if (selectedFaction != null)
            {
                possibleDetachments.Clear();

                foreach (ModelClasses.Detachment detachment in allDetachments)
                {
                    possibleDetachments.AddDetachment(detachment);
                    // Maybe later, at the moment all Factions have the same detachments
                    //if (detachment.Faction == selectedFaction.Name)
                    //{
                    //    possibleDetachments.AddDetachment(detachment);
                    //}
                }
            }
        }

        public void SetPossibleFactions()
        {
            //Even if a (Main-) Faction is given, there still might be valid sub-factions (like Empire --> Imperial Knights...)
            
            if (isFixedFaction && mainFaction != null)
            {
                possibleFactions.Clear();
                possibleFactions.AddFaction(mainFaction);

                foreach (ModelClasses.Faction faction in allFactions)
                {
                    if (faction.MainFaction == mainFaction.Name)
                    {
                        possibleFactions.AddFaction(faction);
                    }
                }
            }
            else
            {
                possibleFactions.Clear();

                foreach (ModelClasses.Faction faction in allFactions)
                {
                    possibleFactions.AddFaction(faction);
                }
            }
        }

        private void cmbFaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFaction.SelectedItem != null)
            {
                selectedFaction = (ModelClasses.Faction)cmbFaction.SelectedItem;
                lblFaction.Text = selectedFaction.Name;

                RefreshDetachments();
            }
        }

        private void cmbDetachments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedFaction != null)
            {
                if (cmbDetachments.SelectedItem != null)
                { 
                    ModelClasses.Detachment tempDet = (ModelClasses.Detachment)cmbDetachments.SelectedItem;
                    Detachment = new ModelClasses.Detachment(tempDet);
                }

                if (Detachment != null)
                {
                    String infoText = Detachment.GetBasicInfoString();
                    if (infoText.Length > 80)
                    {
                        infoText = infoText.Substring(0, 80) + "...";
                    }
                    lblDetachment.Text = infoText;
                }
            }
        }

        private void DialogAddDetachment_Load(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (selectedFaction == null || Detachment == null)
            {
                MessageBox.Show("Hinweis: Bitte wähle eine Fraktion und ein Detachment aus.");
                return;
            }

            Detachment.Faction = selectedFaction.Name;
            Detachment.Name = "[" + Detachment.Faction + "] " + Detachment.Name + " | " + (numberOfDetachments + 1).ToString("##");

            this.DialogResult = DialogResult.OK;
        }
    }
}
