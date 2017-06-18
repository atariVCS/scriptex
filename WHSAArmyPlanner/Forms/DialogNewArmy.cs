using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WHSAArmyPlanner.Forms
{
    public partial class DialogNewArmy : Form
    {
        public String ArmyName { get; set; }
        public Boolean IsPowerlevelLimited { get; set; }
        public Boolean IsPointsLimited { get; set; }
        public Boolean IsStrictMatchedList { get; set; }
        public Int32 PowerleveLimit { get; set; }
        public Int32 PointsLimit { get; set; }
        public ModelClasses.Faction SelectedFaction { get; set; }

        String factionsFile = Settings.Instance.FactionsFile;
        ModelClasses.Factions allFactions = new ModelClasses.Factions();

        public DialogNewArmy()
        {
            InitializeComponent();
            LoadFactions();
        }

        private void LoadFactions()
        {
            FileStream fs = null;
            cmbFaction.Items.Clear();

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

            foreach (ModelClasses.Faction faction in allFactions)
            {
                cmbFaction.Items.Add(faction);
            }
        }

        #region Data

        private void cbPowerlevelLimit_CheckedChanged(object sender, EventArgs e)
        {
            IsPowerlevelLimited = cbPowerlevelLimit.Checked;
            if (IsPowerlevelLimited)
            {
                txtPowerlevelLimit.Enabled = true;
            }
            else
            {
                txtPowerlevelLimit.Enabled = false;
            }
        }

        private void cbPointsLimit_CheckedChanged(object sender, EventArgs e)
        {
            IsPointsLimited = cbPointsLimit.Checked;
            if (IsPointsLimited)
            {
                txtPointsLimit.Enabled = true;
            }
            else
            {
                txtPointsLimit.Enabled = false;
            }
        }

        private void txtPowerlevelLimit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PowerleveLimit = Convert.ToInt32(txtPowerlevelLimit.Text);
            }
            catch
            {
                PowerleveLimit = 0;
                txtPowerlevelLimit.Text = "";
            }
        }

        private void txtPointsLimit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PointsLimit = Convert.ToInt32(txtPointsLimit.Text);
            }
            catch
            {
                PointsLimit = 0;
                txtPointsLimit.Text = "";
            }
        }

        private void cbStrictPlay_CheckedChanged(object sender, EventArgs e)
        {
            IsStrictMatchedList = cbStrictPlay.Checked;

            if (IsStrictMatchedList)
            {
                cmbFaction.Enabled = true;
            }
            else
            {
                cmbFaction.Enabled = false;
            }
        }

        private void cmbFaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFaction.SelectedItem != null)
            {
                SelectedFaction = (ModelClasses.Faction)cmbFaction.SelectedItem;
            }
        }

        #endregion

        private void btnOK_Click(object sender, EventArgs e)
        {
            ArmyName = txtName.Text;

            if (String.IsNullOrWhiteSpace(ArmyName))
            {
                MessageBox.Show("Hinweis: Bitte gib einen Namen für deine Armee ein.");
                return;
            }

            if (IsPointsLimited && !(PointsLimit > 0))
            {
                MessageBox.Show("Hinweis: Du hast dich für eine Armee mit Punktelimit entschieden, aber keine Punkte eingetragen. Bitte Punkte nachtragen (Beispiel: 1500).");
                return;
            }

            if (IsPowerlevelLimited && !(PowerleveLimit > 0))
            {
                MessageBox.Show("Hinweis: Du hast dich für eine Armee mit Powerlevel-Vorgabe entschieden, aber kein Powerlevel-Limit eingetragen. Bitte Limit nachtragen (Beispiel: 50).");
                return;
            }

            if (IsStrictMatchedList && SelectedFaction == null)
            {
                MessageBox.Show("Hinweis: Du hast Dich für eine \'Strict Matched\' Liste entschieden. Du musst dafür noch eine Fraktion auswählen.");
                return;
            }


            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
