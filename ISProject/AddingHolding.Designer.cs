namespace ISProject
{
    partial class AddingHolding
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
            this.AddHoldingButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.HoldingNameTextBox = new System.Windows.Forms.TextBox();
            this.HoldingOtherInformationRichTextBox = new System.Windows.Forms.RichTextBox();
            this.HoldingMobileNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddHoldingButton
            // 
            this.AddHoldingButton.Location = new System.Drawing.Point(242, 326);
            this.AddHoldingButton.Name = "AddHoldingButton";
            this.AddHoldingButton.Size = new System.Drawing.Size(226, 50);
            this.AddHoldingButton.TabIndex = 0;
            this.AddHoldingButton.Text = "Добавить холдинг";
            this.AddHoldingButton.UseVisualStyleBackColor = true;
            this.AddHoldingButton.Click += new System.EventHandler(this.AddHoldingButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(11, 326);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(226, 50);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Вернуться в главное меню";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 18);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(245, 20);
            this.label.TabIndex = 2;
            this.label.Text = "Введите информацию о холдинге";
            // 
            // HoldingNameTextBox
            // 
            this.HoldingNameTextBox.Location = new System.Drawing.Point(12, 53);
            this.HoldingNameTextBox.Name = "HoldingNameTextBox";
            this.HoldingNameTextBox.PlaceholderText = "Название холдинга";
            this.HoldingNameTextBox.Size = new System.Drawing.Size(457, 27);
            this.HoldingNameTextBox.TabIndex = 3;
            // 
            // HoldingOtherInformationRichTextBox
            // 
            this.HoldingOtherInformationRichTextBox.Location = new System.Drawing.Point(12, 162);
            this.HoldingOtherInformationRichTextBox.Name = "HoldingOtherInformationRichTextBox";
            this.HoldingOtherInformationRichTextBox.Size = new System.Drawing.Size(458, 149);
            this.HoldingOtherInformationRichTextBox.TabIndex = 4;
            this.HoldingOtherInformationRichTextBox.Text = "";
            // 
            // HoldingMobileNumberTextBox
            // 
            this.HoldingMobileNumberTextBox.Location = new System.Drawing.Point(11, 86);
            this.HoldingMobileNumberTextBox.Name = "HoldingMobileNumberTextBox";
            this.HoldingMobileNumberTextBox.PlaceholderText = "Телефонный номер";
            this.HoldingMobileNumberTextBox.Size = new System.Drawing.Size(457, 27);
            this.HoldingMobileNumberTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Другая информация о холдинге";
            // 
            // AddingHolding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 397);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HoldingMobileNumberTextBox);
            this.Controls.Add(this.HoldingOtherInformationRichTextBox);
            this.Controls.Add(this.HoldingNameTextBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AddHoldingButton);
            this.Name = "AddingHolding";
            this.Text = "Добавление холдинга";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AddHoldingButton;
        private Button BackButton;
        private Label label;
        private TextBox HoldingNameTextBox;
        private RichTextBox HoldingOtherInformationRichTextBox;
        private TextBox HoldingMobileNumberTextBox;
        private Label label2;
    }
}