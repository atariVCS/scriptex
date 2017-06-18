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
