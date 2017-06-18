/*"scriptex" Scriptorum Exercitus - Armylist planning tool for tabletop games
* (c) 2017 by Matthias Breiter. Licensed under the Terms of the Apache 2.0 License
*/
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WHSAArmyPlanner.Forms
{
    public partial class DialogBattleroles : Form
    {
        String filename = Settings.Instance.BattlerolesFile;
        ModelClasses.BattleRoles battleRoles = new ModelClasses.BattleRoles();
        ModelClasses.BattleRole selectedBattleRole = null;

        public DialogBattleroles()
        {
            InitializeComponent();
        }

        private void RefreshView()
        {
            txtName.Text = "";
            lbBattleRoles.Items.Clear();

            foreach (ModelClasses.BattleRole role in battleRoles)
            {
                lbBattleRoles.Items.Add(role);
            }
        }

        private Boolean Save()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModelClasses.BattleRoles));
                TextWriter writer = new StreamWriter(filename);

                if (battleRoles.Any())
                {
                    serializer.Serialize(writer, battleRoles);
                }

                writer.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void Battleroles_Load(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModelClasses.BattleRoles));
                FileStream fs = new FileStream(filename, FileMode.Open);
                battleRoles = (ModelClasses.BattleRoles)serializer.Deserialize(fs);
                RefreshView();
                fs.Close();
            }
            catch (Exception excp)
            {
                Debug.WriteLine("Error Loading Battleroles: " + excp.Message);
            }
        }

        private void lbBattleRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBattleRoles.SelectedItem != null)
            {
                selectedBattleRole = (ModelClasses.BattleRole)lbBattleRoles.SelectedItem;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String newRoleName = txtName.Text;
            if (!String.IsNullOrWhiteSpace(newRoleName))
            {
                ModelClasses.BattleRole newBattleRole = new ModelClasses.BattleRole();
                newBattleRole.Name = newRoleName;
                battleRoles.AddRole(newBattleRole);
                RefreshView();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (selectedBattleRole != null)
            {
                battleRoles.Remove(selectedBattleRole);
                selectedBattleRole = null;
                RefreshView();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }
    }
}
