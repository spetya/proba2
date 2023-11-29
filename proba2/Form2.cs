using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proba2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void textBoxCode_Validating(object sender, CancelEventArgs e)
        {
            Regex regexid = new Regex("^[A-Z]{6}$");
            if (!regexid.IsMatch(textBoxCode.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxCode, "Adjon meg 6 Nagybetűt!");
            }
        }

        private void textBoxCode_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxCode, string.Empty);
        }

        private void textBoxID_Validating(object sender, CancelEventArgs e)
        {
            Regex regexid = new Regex("^[0-9]{2}$");
            if (!regexid.IsMatch(textBoxID.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxID, "Adjon meg egy számot!");
            }
        }

        private void textBoxID_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxID, string.Empty);
        }

        private void textBoxName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxName, string.Empty);
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxName.Text == string.Empty)
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxName, "A mező nem lehet üres!");
            }
        }

        private void textBoxDescr_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxDescr, string.Empty);
        }

        private void textBoxDescr_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxDescr.Text == string.Empty)
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxDescr, "A mező nem lehet üres!");
            }
        }
    }
}
