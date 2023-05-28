namespace ISProject
{
    partial class Register
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
            this.RegisterLabel1 = new System.Windows.Forms.Label();
            this.SecondName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Passwd1 = new System.Windows.Forms.TextBox();
            this.Passwd2 = new System.Windows.Forms.TextBox();
            this.passwdCheckbox = new System.Windows.Forms.CheckBox();
            this.RegisterFromForm = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.JobTitle = new System.Windows.Forms.ComboBox();
            this.JobTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegisterLabel1
            // 
            this.RegisterLabel1.AutoSize = true;
            this.RegisterLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.RegisterLabel1.Location = new System.Drawing.Point(37, 46);
            this.RegisterLabel1.Name = "RegisterLabel1";
            this.RegisterLabel1.Size = new System.Drawing.Size(560, 41);
            this.RegisterLabel1.TabIndex = 0;
            this.RegisterLabel1.Text = "Заполните форму для регистрации";
            // 
            // SecondName
            // 
            this.SecondName.Location = new System.Drawing.Point(211, 120);
            this.SecondName.Name = "SecondName";
            this.SecondName.PlaceholderText = "Фамилия";
            this.SecondName.Size = new System.Drawing.Size(193, 27);
            this.SecondName.TabIndex = 15;
            this.SecondName.TabStop = false;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(12, 120);
            this.FirstName.Name = "FirstName";
            this.FirstName.PlaceholderText = "Имя";
            this.FirstName.Size = new System.Drawing.Size(193, 27);
            this.FirstName.TabIndex = 2;
            this.FirstName.TabStop = false;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(410, 120);
            this.LastName.Name = "LastName";
            this.LastName.PlaceholderText = "Отчество";
            this.LastName.Size = new System.Drawing.Size(202, 27);
            this.LastName.TabIndex = 3;
            this.LastName.TabStop = false;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(12, 164);
            this.Email.Name = "Email";
            this.Email.PlaceholderText = "Email";
            this.Email.Size = new System.Drawing.Size(308, 27);
            this.Email.TabIndex = 4;
            this.Email.TabStop = false;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(12, 198);
            this.Login.Name = "Login";
            this.Login.PlaceholderText = "логин";
            this.Login.Size = new System.Drawing.Size(308, 27);
            this.Login.TabIndex = 6;
            this.Login.TabStop = false;
            // 
            // Passwd1
            // 
            this.Passwd1.Location = new System.Drawing.Point(12, 240);
            this.Passwd1.Name = "Passwd1";
            this.Passwd1.PasswordChar = '*';
            this.Passwd1.PlaceholderText = "пароль";
            this.Passwd1.Size = new System.Drawing.Size(308, 27);
            this.Passwd1.TabIndex = 7;
            this.Passwd1.TabStop = false;
            // 
            // Passwd2
            // 
            this.Passwd2.Location = new System.Drawing.Point(12, 273);
            this.Passwd2.Name = "Passwd2";
            this.Passwd2.PlaceholderText = "повторно введите пароль";
            this.Passwd2.Size = new System.Drawing.Size(308, 27);
            this.Passwd2.TabIndex = 8;
            this.Passwd2.TabStop = false;
            // 
            // passwdCheckbox
            // 
            this.passwdCheckbox.AutoSize = true;
            this.passwdCheckbox.Location = new System.Drawing.Point(12, 306);
            this.passwdCheckbox.Name = "passwdCheckbox";
            this.passwdCheckbox.Size = new System.Drawing.Size(148, 24);
            this.passwdCheckbox.TabIndex = 9;
            this.passwdCheckbox.TabStop = false;
            this.passwdCheckbox.Text = "показать пароль";
            this.passwdCheckbox.UseVisualStyleBackColor = true;
            this.passwdCheckbox.CheckedChanged += new System.EventHandler(this.PasswdCheckbox_CheckedChanged);
            // 
            // RegisterFromForm
            // 
            this.RegisterFromForm.Location = new System.Drawing.Point(410, 352);
            this.RegisterFromForm.Name = "RegisterFromForm";
            this.RegisterFromForm.Size = new System.Drawing.Size(209, 43);
            this.RegisterFromForm.TabIndex = 10;
            this.RegisterFromForm.Text = "Регистрация";
            this.RegisterFromForm.UseVisualStyleBackColor = true;
            this.RegisterFromForm.Click += new System.EventHandler(this.RegisterFromForm_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(195, 352);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(209, 43);
            this.Back.TabIndex = 11;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // JobTitle
            // 
            this.JobTitle.FormattingEnabled = true;
            this.JobTitle.Items.AddRange(new object[] {
            "Глава холдинга",
            "Глава предприятия",
            "Работник отдела статистики"});
            this.JobTitle.Location = new System.Drawing.Point(333, 197);
            this.JobTitle.Name = "JobTitle";
            this.JobTitle.Size = new System.Drawing.Size(286, 28);
            this.JobTitle.TabIndex = 12;
            this.JobTitle.TabStop = false;
            // 
            // JobTitleLabel
            // 
            this.JobTitleLabel.AutoSize = true;
            this.JobTitleLabel.Location = new System.Drawing.Point(333, 164);
            this.JobTitleLabel.Name = "JobTitleLabel";
            this.JobTitleLabel.Size = new System.Drawing.Size(86, 20);
            this.JobTitleLabel.TabIndex = 13;
            this.JobTitleLabel.Text = "Должность";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 415);
            this.Controls.Add(this.JobTitleLabel);
            this.Controls.Add(this.JobTitle);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.RegisterFromForm);
            this.Controls.Add(this.passwdCheckbox);
            this.Controls.Add(this.Passwd2);
            this.Controls.Add(this.Passwd1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.SecondName);
            this.Controls.Add(this.RegisterLabel1);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label RegisterLabel1;
        private TextBox SecondName;
        private TextBox FirstName;
        private TextBox LastName;
        private TextBox Email;
        private TextBox Login;
        private TextBox Passwd1;
        private TextBox Passwd2;
        private CheckBox passwdCheckbox;
        private Button RegisterFromForm;
        private Button Back;
        private ComboBox JobTitle;
        private Label JobTitleLabel;
    }
}