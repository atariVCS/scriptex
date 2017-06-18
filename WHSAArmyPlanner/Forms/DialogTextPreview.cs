using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WHSAArmyPlanner.Forms
{
    public partial class DialogTextPreview : Form
    {
        string[] lines;
        int linesPrinted = 0;
        ModelClasses.ForceOrgChart foc = null;


        public DialogTextPreview()
        {
            InitializeComponent();
        }

        public DialogTextPreview(ModelClasses.ForceOrgChart armyFoc)
        {
            InitializeComponent();
            foc = armyFoc;
            if (foc != null)
            {
                rtbArmylist.Text = foc.GetSummary(false, false);
            }
        }
        
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                printDocument1.Print();
            }
        }

        private void OnBeginPrint(object sender,
                          System.Drawing.Printing.PrintEventArgs e)
        {
            char[] param = { '\n' };

            linesPrinted = 0;
            lines = null;

            if (printDialog1.PrinterSettings.PrintRange == PrintRange.Selection)
            {
                lines = rtbArmylist.SelectedText.Split(param);
            }
            else
            {
                lines = rtbArmylist.Text.Split(param);
            }

            int i = 0;
            char[] trimParam = { '\r' };
            foreach (string s in lines)
            {
                lines[i++] = s.TrimEnd(trimParam);
            }
        }

        private void OnPrintPage(object sender,
                                   System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;
            Brush brush = new SolidBrush(rtbArmylist.ForeColor);

            while (linesPrinted < lines.Length)
            {
                e.Graphics.DrawString(lines[linesPrinted++],
                     rtbArmylist.Font, brush, x, y);
                y += 15;
                if (y >= e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
                else {
                    e.HasMorePages = false;
                }
            }
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            OnBeginPrint(sender, e);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            OnPrintPage(sender, e);
        }

        private void printDocument1_EndPrint(object sender, PrintEventArgs e)
        {

        }

        private void cbIncludeProfile_CheckedChanged(object sender, EventArgs e)
        {
            if (foc != null)
            {
                rtbArmylist.Text = "";
                rtbArmylist.Text = foc.GetSummary(cbIncludeProfile.Checked, cbIncludeWargear.Checked);
            }
        }

        private void cbIncludeWargear_CheckedChanged(object sender, EventArgs e)
        {
            if (foc != null)
            {
                rtbArmylist.Text = "";
                rtbArmylist.Text = foc.GetSummary(cbIncludeProfile.Checked, cbIncludeWargear.Checked);
            }
        }
    }
}
