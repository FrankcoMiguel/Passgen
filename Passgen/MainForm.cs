using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Passgen
{
    public partial class MainForm : Form
    {
        private Password password;
        private PasswordGenerator passgen;

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadForm(object sender, EventArgs e)
        {
            lengthComboBox.SelectedIndex = 0;
        }

        private void SetConfiguration(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("You want to generate a password", "Password message",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool HasUpperCase = upperCaseCheckBox.Checked;
                bool HasNumbers = numbersCheckBox.Checked;
                bool SpecialSymbols = symbolsCheckBox.Checked;
                int Length = int.Parse(lengthComboBox.Text);

                //New Password Object
                password = new Password(HasUpperCase, HasNumbers, SpecialSymbols, Length);
                passgen = new PasswordGenerator();
                resultListBox.Items.Add(passgen.GeneratePass(password));
                generateButton.Enabled = false;
                password = null;
                generateButton.Enabled = true;
            }
            else if (result == DialogResult.No)
            {
                
            }

        }

        private void DisableGenerate(object sender, EventArgs e)
        {
            if (!upperCaseCheckBox.Checked && !symbolsCheckBox.Checked)
            {
                if (generateButton.Enabled)
                {
                    generateButton.Enabled = false;
                }
            } else
            {
                if (!generateButton.Enabled)
                {
                    generateButton.Enabled = true;
                }
            }
        }

        private void ClearAll(object sender, EventArgs e)
        {
            resultListBox.Items.Clear();

        }


        private void ClearSelected(object sender, EventArgs e)
        {

           if (resultListBox.SelectedItem != null) 
            { 
                int index = resultListBox.SelectedIndex;
                resultListBox.Items.RemoveAt(index);
            } 
            
        }

        private void CopyAll(object sender, EventArgs e)
        {
            try
            {
                string items = "";
                foreach (object item in resultListBox.Items) items += item.ToString() + " ";
                Clipboard.SetText(items);
                MessageBox.Show("Passwords copied", "Clipboard message");
            }
            catch (Exception)
            {
                MessageBox.Show("Generate a password at least", "Clipboard error");
            }
        }

        private void CopySelected(object sender, EventArgs e)
        {
            try
            {
                if (resultListBox.SelectedItem != null)
                {
                    string item = "";
                    item = resultListBox.SelectedItem.ToString();
                    Clipboard.SetText(item);
                    MessageBox.Show("Password copied", "Clipboard message");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Generate a password at least", "Clipboard error");
            }
        }

    }
}
