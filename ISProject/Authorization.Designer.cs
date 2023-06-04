namespace ISProject
{
    partial class Authorization
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AuthorizationLabel1 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.entry = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AuthorizationLabel1
            // 
            this.AuthorizationLabel1.AutoSize = true;
            this.AuthorizationLabel1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AuthorizationLabel1.Location = new System.Drawing.Point(80, 37);
            this.AuthorizationLabel1.Name = "AuthorizationLabel1";
            this.AuthorizationLabel1.Size = new System.Drawing.Size(198, 38);
            this.AuthorizationLabel1.TabIndex = 0;
            this.AuthorizationLabel1.Text = "Авторизация";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(54, 93);
            this.Login.Name = "Login";
            this.Login.PlaceholderText = "логин";
            this.Login.Size = new System.Drawing.Size(256, 27);
            this.Login.TabIndex = 1;
            this.Login.TabStop = false;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(54, 126);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.PlaceholderText = "пароль";
            this.Password.Size = new System.Drawing.Size(256, 27);
            this.Password.TabIndex = 2;
            this.Password.TabStop = false;
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Location = new System.Drawing.Point(54, 159);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(148, 24);
            this.ShowPassword.TabIndex = 3;
            this.ShowPassword.TabStop = false;
            this.ShowPassword.Text = "показать пароль";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // entry
            // 
            this.entry.Location = new System.Drawing.Point(80, 208);
            this.entry.Name = "entry";
            this.entry.Size = new System.Drawing.Size(198, 27);
            this.entry.TabIndex = 4;
            this.entry.Text = "вход";
            this.entry.UseVisualStyleBackColor = true;
            this.entry.Click += new System.EventHandler(this.Entry_Click);
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(80, 241);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(198, 28);
            this.register.TabIndex = 5;
            this.register.Text = "регистрация";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 295);
            this.Controls.Add(this.register);
            this.Controls.Add(this.entry);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.AuthorizationLabel1);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информационная Система";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AuthorizationLabel1;
        private TextBox Login;
        private TextBox Password;
        private CheckBox ShowPassword;
        private Button entry;
        private Button register;
    }
}