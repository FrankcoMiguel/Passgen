namespace Passgen
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.passwordConfigGroupBox = new System.Windows.Forms.GroupBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.lengthComboBox = new System.Windows.Forms.ComboBox();
            this.symbolsCheckBox = new System.Windows.Forms.CheckBox();
            this.numbersCheckBox = new System.Windows.Forms.CheckBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.upperCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.passwordResultGroupBox = new System.Windows.Forms.GroupBox();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.copySelectedButton = new System.Windows.Forms.Button();
            this.copyAllButton = new System.Windows.Forms.Button();
            this.passwordConfigGroupBox.SuspendLayout();
            this.passwordResultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordConfigGroupBox
            // 
            this.passwordConfigGroupBox.Controls.Add(this.lengthLabel);
            this.passwordConfigGroupBox.Controls.Add(this.lengthComboBox);
            this.passwordConfigGroupBox.Controls.Add(this.symbolsCheckBox);
            this.passwordConfigGroupBox.Controls.Add(this.numbersCheckBox);
            this.passwordConfigGroupBox.Controls.Add(this.upperCaseCheckBox);
            this.passwordConfigGroupBox.Controls.Add(this.generateButton);
            this.passwordConfigGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordConfigGroupBox.Location = new System.Drawing.Point(12, 12);
            this.passwordConfigGroupBox.Name = "passwordConfigGroupBox";
            this.passwordConfigGroupBox.Size = new System.Drawing.Size(301, 329);
            this.passwordConfigGroupBox.TabIndex = 0;
            this.passwordConfigGroupBox.TabStop = false;
            this.passwordConfigGroupBox.Text = "Configuration";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthLabel.Location = new System.Drawing.Point(2, 178);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(58, 19);
            this.lengthLabel.TabIndex = 6;
            this.lengthLabel.Text = "Length";
            // 
            // lengthComboBox
            // 
            this.lengthComboBox.DropDownHeight = 110;
            this.lengthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lengthComboBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthComboBox.FormatString = "N0";
            this.lengthComboBox.FormattingEnabled = true;
            this.lengthComboBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.lengthComboBox.IntegralHeight = false;
            this.lengthComboBox.Items.AddRange(new object[] {
            "8",
            "10",
            "12"});
            this.lengthComboBox.Location = new System.Drawing.Point(5, 200);
            this.lengthComboBox.Name = "lengthComboBox";
            this.lengthComboBox.Size = new System.Drawing.Size(167, 27);
            this.lengthComboBox.TabIndex = 5;
            this.lengthComboBox.Tag = "";
            // 
            // symbolsCheckBox
            // 
            this.symbolsCheckBox.AutoSize = true;
            this.symbolsCheckBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbolsCheckBox.Location = new System.Drawing.Point(6, 130);
            this.symbolsCheckBox.Name = "symbolsCheckBox";
            this.symbolsCheckBox.Size = new System.Drawing.Size(209, 23);
            this.symbolsCheckBox.TabIndex = 2;
            this.symbolsCheckBox.Text = "Special Symbols (!@#$)";
            this.symbolsCheckBox.UseVisualStyleBackColor = true;
            this.symbolsCheckBox.CheckedChanged += new System.EventHandler(this.DisableGenerate);
            // 
            // numbersCheckBox
            // 
            this.numbersCheckBox.AutoSize = true;
            this.numbersCheckBox.Checked = true;
            this.numbersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.numbersCheckBox.Enabled = false;
            this.numbersCheckBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbersCheckBox.Location = new System.Drawing.Point(6, 46);
            this.numbersCheckBox.Name = "numbersCheckBox";
            this.numbersCheckBox.Size = new System.Drawing.Size(137, 23);
            this.numbersCheckBox.TabIndex = 1;
            this.numbersCheckBox.Text = "Numbers (0-9)";
            this.numbersCheckBox.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(17, 357);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(301, 46);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear Selected";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearSelected);
            // 
            // upperCaseCheckBox
            // 
            this.upperCaseCheckBox.AutoSize = true;
            this.upperCaseCheckBox.Checked = true;
            this.upperCaseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.upperCaseCheckBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upperCaseCheckBox.Location = new System.Drawing.Point(6, 89);
            this.upperCaseCheckBox.Name = "upperCaseCheckBox";
            this.upperCaseCheckBox.Size = new System.Drawing.Size(207, 23);
            this.upperCaseCheckBox.TabIndex = 0;
            this.upperCaseCheckBox.Text = "Uppercase Letters (A-Z)";
            this.upperCaseCheckBox.UseVisualStyleBackColor = true;
            this.upperCaseCheckBox.CheckedChanged += new System.EventHandler(this.DisableGenerate);
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.Location = new System.Drawing.Point(13, 261);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(272, 37);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.SetConfiguration);
            this.generateButton.Enter += new System.EventHandler(this.SetConfiguration);
            this.generateButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SetConfiguration);
            // 
            // passwordResultGroupBox
            // 
            this.passwordResultGroupBox.Controls.Add(this.resultListBox);
            this.passwordResultGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordResultGroupBox.Location = new System.Drawing.Point(329, 12);
            this.passwordResultGroupBox.Name = "passwordResultGroupBox";
            this.passwordResultGroupBox.Size = new System.Drawing.Size(314, 329);
            this.passwordResultGroupBox.TabIndex = 3;
            this.passwordResultGroupBox.TabStop = false;
            this.passwordResultGroupBox.Text = "Password";
            // 
            // resultListBox
            // 
            this.resultListBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.ItemHeight = 19;
            this.resultListBox.Location = new System.Drawing.Point(6, 30);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(302, 289);
            this.resultListBox.TabIndex = 0;
            // 
            // clearAllButton
            // 
            this.clearAllButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAllButton.Location = new System.Drawing.Point(335, 357);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(302, 46);
            this.clearAllButton.TabIndex = 5;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.ClearAll);
            // 
            // copySelectedButton
            // 
            this.copySelectedButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copySelectedButton.Location = new System.Drawing.Point(18, 409);
            this.copySelectedButton.Name = "copySelectedButton";
            this.copySelectedButton.Size = new System.Drawing.Size(301, 46);
            this.copySelectedButton.TabIndex = 6;
            this.copySelectedButton.Text = "Copy Selected";
            this.copySelectedButton.UseVisualStyleBackColor = true;
            this.copySelectedButton.Click += new System.EventHandler(this.CopySelected);
            // 
            // copyAllButton
            // 
            this.copyAllButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyAllButton.Location = new System.Drawing.Point(335, 412);
            this.copyAllButton.Name = "copyAllButton";
            this.copyAllButton.Size = new System.Drawing.Size(302, 46);
            this.copyAllButton.TabIndex = 7;
            this.copyAllButton.Text = "Copy All";
            this.copyAllButton.UseVisualStyleBackColor = true;
            this.copyAllButton.Click += new System.EventHandler(this.CopyAll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 470);
            this.Controls.Add(this.copyAllButton);
            this.Controls.Add(this.copySelectedButton);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.passwordResultGroupBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.passwordConfigGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(673, 517);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passgen 2020";
            this.Load += new System.EventHandler(this.LoadForm);
            this.passwordConfigGroupBox.ResumeLayout(false);
            this.passwordConfigGroupBox.PerformLayout();
            this.passwordResultGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox passwordConfigGroupBox;
        private System.Windows.Forms.CheckBox upperCaseCheckBox;
        private System.Windows.Forms.CheckBox symbolsCheckBox;
        private System.Windows.Forms.CheckBox numbersCheckBox;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.ComboBox lengthComboBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox passwordResultGroupBox;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.Button copySelectedButton;
        private System.Windows.Forms.Button copyAllButton;
        private System.Windows.Forms.Button clearAllButton;
    }
}