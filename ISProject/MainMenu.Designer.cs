namespace ISProject
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.GPButton1 = new System.Windows.Forms.Button();
            this.GPButton2 = new System.Windows.Forms.Button();
            this.GPButton3 = new System.Windows.Forms.Button();
            this.DHButton3 = new System.Windows.Forms.Button();
            this.STButton1 = new System.Windows.Forms.Button();
            this.STButton2 = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Label();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.HelloLabel.Location = new System.Drawing.Point(207, 9);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(352, 35);
            this.HelloLabel.TabIndex = 0;
            this.HelloLabel.Text = "Доброе утро вася пупкин";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.Location = new System.Drawing.Point(18, 53);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.TabIndex = 1;
            // 
            // GPButton1
            // 
            this.GPButton1.Location = new System.Drawing.Point(222, 114);
            this.GPButton1.Name = "GPButton1";
            this.GPButton1.Size = new System.Drawing.Size(554, 44);
            this.GPButton1.TabIndex = 4;
            this.GPButton1.Text = "Загрузка финансовой отчётности за период";
            this.GPButton1.UseVisualStyleBackColor = true;
            this.GPButton1.Visible = false;
            this.GPButton1.Click += new System.EventHandler(this.GPButton1_Click);
            // 
            // GPButton2
            // 
            this.GPButton2.Location = new System.Drawing.Point(222, 164);
            this.GPButton2.Name = "GPButton2";
            this.GPButton2.Size = new System.Drawing.Size(554, 44);
            this.GPButton2.TabIndex = 5;
            this.GPButton2.Text = "Выгрузка финансовой отчётности/статистики за период";
            this.GPButton2.UseVisualStyleBackColor = true;
            this.GPButton2.Visible = false;
            this.GPButton2.Click += new System.EventHandler(this.GPButton2_Click);
            // 
            // GPButton3
            // 
            this.GPButton3.Location = new System.Drawing.Point(222, 214);
            this.GPButton3.Name = "GPButton3";
            this.GPButton3.Size = new System.Drawing.Size(554, 43);
            this.GPButton3.TabIndex = 6;
            this.GPButton3.Text = "Добавление/удаление предприятия";
            this.GPButton3.UseVisualStyleBackColor = true;
            this.GPButton3.Click += new System.EventHandler(this.GPButton3_Click);
            // 
            // DHButton3
            // 
            this.DHButton3.Location = new System.Drawing.Point(222, 114);
            this.DHButton3.Name = "DHButton3";
            this.DHButton3.Size = new System.Drawing.Size(554, 43);
            this.DHButton3.TabIndex = 7;
            this.DHButton3.Text = "Добавление/удаление/изменение холдинга\r\n";
            this.DHButton3.UseVisualStyleBackColor = true;
            this.DHButton3.Visible = false;
            this.DHButton3.Click += new System.EventHandler(this.DHButton3_Click);
            // 
            // STButton1
            // 
            this.STButton1.Location = new System.Drawing.Point(222, 164);
            this.STButton1.Name = "STButton1";
            this.STButton1.Size = new System.Drawing.Size(554, 44);
            this.STButton1.TabIndex = 8;
            this.STButton1.Text = "Выгрузка финансовой статистики/отчётности всего холдинга";
            this.STButton1.UseVisualStyleBackColor = true;
            this.STButton1.Visible = false;
            this.STButton1.Click += new System.EventHandler(this.STButton1_Click);
            // 
            // STButton2
            // 
            this.STButton2.Location = new System.Drawing.Point(222, 214);
            this.STButton2.Name = "STButton2";
            this.STButton2.Size = new System.Drawing.Size(554, 43);
            this.STButton2.TabIndex = 9;
            this.STButton2.Text = "Выгрузка финансовой отчётности/статистики отдельного предприятия";
            this.STButton2.UseVisualStyleBackColor = true;
            this.STButton2.Click += new System.EventHandler(this.STButton2_Click);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Time.Location = new System.Drawing.Point(18, 9);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(76, 35);
            this.Time.TabIndex = 10;
            this.Time.Text = "9:31";
            // 
            // ClockTimer
            // 
            this.ClockTimer.Enabled = true;
            this.ClockTimer.Interval = 60000;
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 577);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.STButton2);
            this.Controls.Add(this.STButton1);
            this.Controls.Add(this.DHButton3);
            this.Controls.Add(this.GPButton3);
            this.Controls.Add(this.GPButton2);
            this.Controls.Add(this.GPButton1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.HelloLabel);
            this.Name = "MainMenu";
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.MainMenu_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label HelloLabel;
        private MonthCalendar monthCalendar1;
        private Button GPButton1;
        private Button GPButton2;
        private Button GPButton3;
        private Button DHButton3;
        private Button STButton1;
        private Button STButton2;
        private Label Time;
        private System.Windows.Forms.Timer ClockTimer;
    }
}