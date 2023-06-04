namespace ISProject
{
    partial class AddingCompany
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
            if (disposing)
            {
                Application.Exit(); // или Environment.Exit(0);
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
            this.AddCompanyButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.CompanyMobileNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CompanyOtherInformationRichTextBox = new System.Windows.Forms.RichTextBox();
            this.HoldingsComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddCompanyButton
            // 
            this.AddCompanyButton.Location = new System.Drawing.Point(562, 230);
            this.AddCompanyButton.Name = "AddCompanyButton";
            this.AddCompanyButton.Size = new System.Drawing.Size(226, 50);
            this.AddCompanyButton.TabIndex = 0;
            this.AddCompanyButton.Text = "Добавить компанию";
            this.AddCompanyButton.UseVisualStyleBackColor = true;
            this.AddCompanyButton.Click += new System.EventHandler(this.AddCompanyButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(562, 174);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(226, 50);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Вернуться в главное меню";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите информацию о компании";
            // 
            // CompanyNameTextBox
            // 
            this.CompanyNameTextBox.Location = new System.Drawing.Point(12, 43);
            this.CompanyNameTextBox.Name = "CompanyNameTextBox";
            this.CompanyNameTextBox.PlaceholderText = "Название компании";
            this.CompanyNameTextBox.Size = new System.Drawing.Size(458, 27);
            this.CompanyNameTextBox.TabIndex = 3;
            // 
            // CompanyMobileNumberTextBox
            // 
            this.CompanyMobileNumberTextBox.Location = new System.Drawing.Point(12, 76);
            this.CompanyMobileNumberTextBox.Name = "CompanyMobileNumberTextBox";
            this.CompanyMobileNumberTextBox.PlaceholderText = "Телефонный номер";
            this.CompanyMobileNumberTextBox.Size = new System.Drawing.Size(458, 27);
            this.CompanyMobileNumberTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Другая информация о компании";
            // 
            // CompanyOtherInformationRichTextBox
            // 
            this.CompanyOtherInformationRichTextBox.Location = new System.Drawing.Point(12, 152);
            this.CompanyOtherInformationRichTextBox.Name = "CompanyOtherInformationRichTextBox";
            this.CompanyOtherInformationRichTextBox.Size = new System.Drawing.Size(458, 149);
            this.CompanyOtherInformationRichTextBox.TabIndex = 6;
            this.CompanyOtherInformationRichTextBox.Text = "";
            // 
            // HoldingsComboBox
            // 
            this.HoldingsComboBox.FormattingEnabled = true;
            this.HoldingsComboBox.Location = new System.Drawing.Point(476, 75);
            this.HoldingsComboBox.Name = "HoldingsComboBox";
            this.HoldingsComboBox.Size = new System.Drawing.Size(387, 28);
            this.HoldingsComboBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(392, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Выберите холдинг к которому принадлежит компания";
            // 
            // AddingCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 323);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HoldingsComboBox);
            this.Controls.Add(this.CompanyOtherInformationRichTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CompanyMobileNumberTextBox);
            this.Controls.Add(this.CompanyNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AddCompanyButton);
            this.Name = "AddingCompany";
            this.Text = "Добавление компании";
            this.Load += new System.EventHandler(this.AddingCompany_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AddCompanyButton;
        private Button BackButton;
        private Label label1;
        private TextBox CompanyNameTextBox;
        private TextBox CompanyMobileNumberTextBox;
        private Label label2;
        private RichTextBox CompanyOtherInformationRichTextBox;
        private ComboBox HoldingsComboBox;
        private Label label3;
    }
}