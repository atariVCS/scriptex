/*"scriptex" Scriptorum Exercitus - Armylist planning tool for tabletop games
* (c) 2017 by Matthias Breiter. Licensed under the Terms of the Apache 2.0 License
*/
using System;
using System.Windows.Forms;

namespace WHSAArmyPlanner.Forms
{
    public partial class DialogPreferences : Form
    {
        public String TemplatePath { get; set; }

        public DialogPreferences()
        {
            InitializeComponent();
            txtCurrentTemplatesPath.Text = Settings.Instance.TemplateBasePath;
        }

        private void btnPickDirectory_Click(object sender, EventArgs e)
        {
            DialogResult usersChoice = fbdTemplateDirectory.ShowDialog(this);
            if (usersChoice == DialogResult.OK)
            {
                txtCurrentTemplatesPath.Text = fbdTemplateDirectory.SelectedPath;
            }
        }

        private void txtCurrentTemplatesPath_TextChanged(object sender, EventArgs e)
        {
            TemplatePath = txtCurrentTemplatesPath.Text;
        }
    }
}
