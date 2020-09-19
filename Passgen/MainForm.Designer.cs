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
            this.upperCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.numbersCheckBox = new System.Windows.Forms.CheckBox();
            this.symbolsCheckBox = new System.Windows.Forms.CheckBox();
            this.masterWordTextBox = new System.Windows.Forms.TextBox();
            this.masterWordLabel = new System.Windows.Forms.Label();
            this.lengthComboBox = new System.Windows.Forms.ComboBox();
            this.lengthTextBox = new System.Windows.Forms.Label();
            this.quantityComboBox = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.passwordResultGroupBox = new System.Windows.Forms.GroupBox();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.copyAllButton = new System.Windows.Forms.Button();
            this.clearSelectedButton = new System.Windows.Forms.Button();
            this.passwordConfigGroupBox.SuspendLayout();
            this.passwordResultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordConfigGroupBox
            // 
            this.passwordConfigGroupBox.Controls.Add(this.quantityComboBox);
            this.passwordConfigGroupBox.Controls.Add(this.comboBox2);
            this.passwordConfigGroupBox.Controls.Add(this.lengthTextBox);
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
            // masterWordTextBox
            // 
            this.masterWordTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterWordTextBox.Location = new System.Drawing.Point(14, 204);
            this.masterWordTextBox.Name = "masterWordTextBox";
            this.masterWordTextBox.Size = new System.Drawing.Size(193, 27);
            this.masterWordTextBox.TabIndex = 3;
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
            // lengthTextBox
            // 
            this.lengthTextBox.AutoSize = true;
            this.lengthTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthTextBox.Location = new System.Drawing.Point(11, 253);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(58, 19);
            this.lengthTextBox.TabIndex = 6;
            this.lengthTextBox.Text = "Length";
            // 
            // quantityComboBox
            // 
            this.quantityComboBox.AutoSize = true;
            this.quantityComboBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityComboBox.Location = new System.Drawing.Point(138, 253);
            this.quantityComboBox.Name = "quantityComboBox";
            this.quantityComboBox.Size = new System.Drawing.Size(69, 19);
            this.quantityComboBox.TabIndex = 8;
            this.quantityComboBox.Text = "Quantity";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(137, 273);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(97, 27);
            this.comboBox2.TabIndex = 7;
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
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(337, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "Copy Selected";
            this.button2.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Label quantityComboBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lengthTextBox;
        private System.Windows.Forms.ComboBox lengthComboBox;
        private System.Windows.Forms.Label masterWordLabel;
        private System.Windows.Forms.TextBox masterWordTextBox;
        private System.Windows.Forms.CheckBox symbolsCheckBox;
        private System.Windows.Forms.CheckBox numbersCheckBox;
        private System.Windows.Forms.CheckBox upperCaseCheckBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.GroupBox passwordResultGroupBox;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button copyAllButton;
        private System.Windows.Forms.Button clearSelectedButton;
    }
}