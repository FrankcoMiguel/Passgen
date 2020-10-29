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
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityComboBox = new System.Windows.Forms.ComboBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.lengthComboBox = new System.Windows.Forms.ComboBox();
            this.masterWordLabel = new System.Windows.Forms.Label();
            this.masterWordTextBox = new System.Windows.Forms.TextBox();
            this.symbolsCheckBox = new System.Windows.Forms.CheckBox();
            this.numbersCheckBox = new System.Windows.Forms.CheckBox();
            this.upperCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.passwordResultGroupBox = new System.Windows.Forms.GroupBox();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.copySelectedButton = new System.Windows.Forms.Button();
            this.copyAllButton = new System.Windows.Forms.Button();
            this.clearSelectedButton = new System.Windows.Forms.Button();
            this.passwordConfigGroupBox.SuspendLayout();
            this.passwordResultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordConfigGroupBox
            // 
            this.passwordConfigGroupBox.Controls.Add(this.quantityLabel);
            this.passwordConfigGroupBox.Controls.Add(this.quantityComboBox);
            this.passwordConfigGroupBox.Controls.Add(this.lengthLabel);
            this.passwordConfigGroupBox.Controls.Add(this.lengthComboBox);
            this.passwordConfigGroupBox.Controls.Add(this.masterWordLabel);
            this.passwordConfigGroupBox.Controls.Add(this.masterWordTextBox);
            this.passwordConfigGroupBox.Controls.Add(this.symbolsCheckBox);
            this.passwordConfigGroupBox.Controls.Add(this.numbersCheckBox);
            this.passwordConfigGroupBox.Controls.Add(this.upperCaseCheckBox);
            this.passwordConfigGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordConfigGroupBox.Location = new System.Drawing.Point(12, 12);
            this.passwordConfigGroupBox.Name = "passwordConfigGroupBox";
            this.passwordConfigGroupBox.Size = new System.Drawing.Size(301, 329);
            this.passwordConfigGroupBox.TabIndex = 0;
            this.passwordConfigGroupBox.TabStop = false;
            this.passwordConfigGroupBox.Text = "Password Configuration";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(138, 253);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(69, 19);
            this.quantityLabel.TabIndex = 8;
            this.quantityLabel.Text = "Quantity";
            // 
            // quantityComboBox
            // 
            this.quantityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quantityComboBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityComboBox.FormattingEnabled = true;
            this.quantityComboBox.Location = new System.Drawing.Point(137, 273);
            this.quantityComboBox.Name = "quantityComboBox";
            this.quantityComboBox.Size = new System.Drawing.Size(97, 27);
            this.quantityComboBox.TabIndex = 7;
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthLabel.Location = new System.Drawing.Point(11, 253);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(58, 19);
            this.lengthLabel.TabIndex = 6;
            this.lengthLabel.Text = "Length";
            // 
            // lengthComboBox
            // 
            this.lengthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lengthComboBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthComboBox.FormattingEnabled = true;
            this.lengthComboBox.Location = new System.Drawing.Point(14, 273);
            this.lengthComboBox.Name = "lengthComboBox";
            this.lengthComboBox.Size = new System.Drawing.Size(107, 27);
            this.lengthComboBox.TabIndex = 5;
            // 
            // masterWordLabel
            // 
            this.masterWordLabel.AutoSize = true;
            this.masterWordLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterWordLabel.Location = new System.Drawing.Point(11, 184);
            this.masterWordLabel.Name = "masterWordLabel";
            this.masterWordLabel.Size = new System.Drawing.Size(171, 19);
            this.masterWordLabel.TabIndex = 4;
            this.masterWordLabel.Text = "Master word (optional)";
            // 
            // masterWordTextBox
            // 
            this.masterWordTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterWordTextBox.Location = new System.Drawing.Point(14, 204);
            this.masterWordTextBox.Name = "masterWordTextBox";
            this.masterWordTextBox.Size = new System.Drawing.Size(193, 27);
            this.masterWordTextBox.TabIndex = 3;
            // 
            // symbolsCheckBox
            // 
            this.symbolsCheckBox.AutoSize = true;
            this.symbolsCheckBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbolsCheckBox.Location = new System.Drawing.Point(14, 133);
            this.symbolsCheckBox.Name = "symbolsCheckBox";
            this.symbolsCheckBox.Size = new System.Drawing.Size(209, 23);
            this.symbolsCheckBox.TabIndex = 2;
            this.symbolsCheckBox.Text = "Special Symbols (!@#$)";
            this.symbolsCheckBox.UseVisualStyleBackColor = true;
            // 
            // numbersCheckBox
            // 
            this.numbersCheckBox.AutoSize = true;
            this.numbersCheckBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbersCheckBox.Location = new System.Drawing.Point(14, 93);
            this.numbersCheckBox.Name = "numbersCheckBox";
            this.numbersCheckBox.Size = new System.Drawing.Size(137, 23);
            this.numbersCheckBox.TabIndex = 1;
            this.numbersCheckBox.Text = "Numbers (0-9)";
            this.numbersCheckBox.UseVisualStyleBackColor = true;
            // 
            // upperCaseCheckBox
            // 
            this.upperCaseCheckBox.AutoSize = true;
            this.upperCaseCheckBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upperCaseCheckBox.Location = new System.Drawing.Point(14, 51);
            this.upperCaseCheckBox.Name = "upperCaseCheckBox";
            this.upperCaseCheckBox.Size = new System.Drawing.Size(207, 23);
            this.upperCaseCheckBox.TabIndex = 0;
            this.upperCaseCheckBox.Text = "Uppercase Letters (A-Z)";
            this.upperCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.Location = new System.Drawing.Point(36, 377);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(97, 37);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
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
            this.passwordResultGroupBox.Text = "PasswordResult";
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
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(149, 377);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(97, 37);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // clearAllButton
            // 
            this.clearAllButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAllButton.Location = new System.Drawing.Point(486, 355);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(143, 46);
            this.clearAllButton.TabIndex = 5;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            // 
            // copySelectedButton
            // 
            this.copySelectedButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copySelectedButton.Location = new System.Drawing.Point(337, 355);
            this.copySelectedButton.Name = "copySelectedButton";
            this.copySelectedButton.Size = new System.Drawing.Size(143, 46);
            this.copySelectedButton.TabIndex = 6;
            this.copySelectedButton.Text = "Copy Selected";
            this.copySelectedButton.UseVisualStyleBackColor = true;
            // 
            // copyAllButton
            // 
            this.copyAllButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyAllButton.Location = new System.Drawing.Point(337, 407);
            this.copyAllButton.Name = "copyAllButton";
            this.copyAllButton.Size = new System.Drawing.Size(143, 46);
            this.copyAllButton.TabIndex = 7;
            this.copyAllButton.Text = "Copy All";
            this.copyAllButton.UseVisualStyleBackColor = true;
            // 
            // clearSelectedButton
            // 
            this.clearSelectedButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearSelectedButton.Location = new System.Drawing.Point(486, 407);
            this.clearSelectedButton.Name = "clearSelectedButton";
            this.clearSelectedButton.Size = new System.Drawing.Size(143, 46);
            this.clearSelectedButton.TabIndex = 8;
            this.clearSelectedButton.Text = "Clear Selected";
            this.clearSelectedButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 470);
            this.Controls.Add(this.clearSelectedButton);
            this.Controls.Add(this.copyAllButton);
            this.Controls.Add(this.copySelectedButton);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.passwordResultGroupBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.passwordConfigGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(673, 517);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passgen 2020";
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
        private System.Windows.Forms.Label masterWordLabel;
        private System.Windows.Forms.TextBox masterWordTextBox;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.ComboBox lengthComboBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.ComboBox quantityComboBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox passwordResultGroupBox;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.Button copySelectedButton;
        private System.Windows.Forms.Button copyAllButton;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button clearSelectedButton;
    }
}