﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passgen
{
    public partial class MainForm : Form
    {




        public MainForm()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            Password pass = new Password(upperCaseCheckBox.Checked, numbersCheckBox.Checked,
                symbolsCheckBox.Checked, masterWordTextBox.Text, int.Parse(lengthComboBox.SelectedItem.ToString()));

            string passgen = pass.

        }
    }
}
