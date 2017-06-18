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
    public partial class DialogFactions : Form
    {
        String factionsFile = Settings.Instance.FactionsFile;
        ModelClasses.Factions factions = new ModelClasses.Factions();
        ModelClasses.Faction selectedFaction = null;

        public DialogFactions()
        {
            InitializeComponent();
        }

        private void Save()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModelClasses.Factions));
                TextWriter writer = new StreamWriter(factionsFile);

                if (factions.Any())
                {
                    serializer.Serialize(writer, factions);
                }

                writer.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Oh Oh, ich kann nicht speichern: " + e.Message);
            }
        }

        private void LoadFactionList()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModelClasses.Factions));
                FileStream fs = new FileStream(factionsFile, FileMode.Open);
                factions = (ModelClasses.Factions)serializer.Deserialize(fs);
                RefreshView();
                fs.Close();
            }
            catch (Exception excp)
            {

            }
        }

        private void RefreshView()
        {
            if (factions != null)
            {
                lbFactions.Items.Clear();
                txtInput.Text = "";

                foreach (ModelClasses.Faction faction in factions)
                {
                    lbFactions.Items.Add(faction);
                }
            }

            RefreshDetails();
        }

        private void RefreshDetails()
        {
            txtName.Enabled = false;

            if (selectedFaction != null)
            {
                txtName.Text = selectedFaction.Name;
                cmbParentfaction.Items.Clear();

                List<ModelClasses.Faction> appliableParentFactions = GetParentFactionList();

                foreach (ModelClasses.Faction fct in appliableParentFactions)
                {
                    cmbParentfaction.Items.Add(fct);
                }

                cmbParentfaction.Text = selectedFaction.MainFaction;
            }
            else
            {
                txtName.Text = "";
                cmbParentfaction.Text = "";
                cmbParentfaction.SelectedItem = null;
                cmbParentfaction.Items.Clear();
            }
        }

        private List<ModelClasses.Faction> GetParentFactionList()
        {
            List<ModelClasses.Faction> availableFactions = new List<ModelClasses.Faction>();
            availableFactions.Clear();

            foreach (ModelClasses.Faction faction in factions)
            {
                if (faction.Name != selectedFaction.Name)
                {
                    availableFactions.Add(faction);
                }
            }

            return availableFactions;
        }

        private void DialogFactions_Load(object sender, EventArgs e)
        {
            LoadFactionList();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtInput.Text))
            {
                ModelClasses.Faction newFaction = new ModelClasses.Faction();
                newFaction.Name = txtInput.Text;

                factions.AddFaction(newFaction);

                RefreshView();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (selectedFaction != null)
            {
                factions.Remove(selectedFaction);
                selectedFaction = null;

                RefreshView();
            }
        }

        private void lbFactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFactions.SelectedItem != null)
            {
                selectedFaction = (ModelClasses.Faction)lbFactions.SelectedItem;
                RefreshDetails();
            }
        }

        private void cmbParentfaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedFaction != null)
            {
                if (cmbParentfaction.SelectedItem != null)
                {
                    ModelClasses.Faction parentFaction = (ModelClasses.Faction)cmbParentfaction.SelectedItem;
                    if (parentFaction != null)
                    {
                        selectedFaction.MainFaction = parentFaction.Name;
                    }
                }
            }
        }
    }
}
