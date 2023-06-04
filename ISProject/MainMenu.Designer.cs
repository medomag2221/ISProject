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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TableHoldingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableMobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableOtherInformation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableHoldingCompanys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoldingIDTableTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableDeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.HoldingsLabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.CompanysLabel = new System.Windows.Forms.Label();
            this.AccountExitButton = new System.Windows.Forms.Button();
            this.TableCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyTableMobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyTableOtherInformation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyTableDeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.HelloLabel.Location = new System.Drawing.Point(222, 21);
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
            this.monthCalendar1.Location = new System.Drawing.Point(18, 79);
            this.monthCalendar1.MaximumSize = new System.Drawing.Size(192, 207);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.TabIndex = 1;
            // 
            // GPButton1
            // 
            this.GPButton1.Location = new System.Drawing.Point(222, 121);
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
            this.GPButton2.Location = new System.Drawing.Point(222, 171);
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
            this.GPButton3.Location = new System.Drawing.Point(222, 222);
            this.GPButton3.Name = "GPButton3";
            this.GPButton3.Size = new System.Drawing.Size(554, 43);
            this.GPButton3.TabIndex = 6;
            this.GPButton3.Text = "Добавление/удаление предприятия";
            this.GPButton3.UseVisualStyleBackColor = true;
            this.GPButton3.Visible = false;
            this.GPButton3.Click += new System.EventHandler(this.GPButton3_Click);
            // 
            // DHButton3
            // 
            this.DHButton3.Location = new System.Drawing.Point(222, 221);
            this.DHButton3.Name = "DHButton3";
            this.DHButton3.Size = new System.Drawing.Size(554, 43);
            this.DHButton3.TabIndex = 7;
            this.DHButton3.Text = "Добавление холдинга\r\n";
            this.DHButton3.UseVisualStyleBackColor = true;
            this.DHButton3.Visible = false;
            this.DHButton3.Click += new System.EventHandler(this.DHButton3_Click);
            // 
            // STButton1
            // 
            this.STButton1.Location = new System.Drawing.Point(222, 172);
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
            this.STButton2.Location = new System.Drawing.Point(222, 222);
            this.STButton2.Name = "STButton2";
            this.STButton2.Size = new System.Drawing.Size(554, 43);
            this.STButton2.TabIndex = 9;
            this.STButton2.Text = "Выгрузка финансовой отчётности/статистики отдельного предприятия";
            this.STButton2.UseVisualStyleBackColor = true;
            this.STButton2.Visible = false;
            this.STButton2.Click += new System.EventHandler(this.STButton2_Click);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Time.Location = new System.Drawing.Point(134, 21);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableHoldingName,
            this.TableMobileNumber,
            this.TableOtherInformation,
            this.TableHoldingCompanys,
            this.HoldingIDTableTextBox,
            this.TableDeleteButton});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(18, 349);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(859, 238);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // TableHoldingName
            // 
            this.TableHoldingName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableHoldingName.DefaultCellStyle = dataGridViewCellStyle1;
            this.TableHoldingName.Frozen = true;
            this.TableHoldingName.HeaderText = "Название холдинга";
            this.TableHoldingName.MinimumWidth = 6;
            this.TableHoldingName.Name = "TableHoldingName";
            this.TableHoldingName.Width = 170;
            // 
            // TableMobileNumber
            // 
            this.TableMobileNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableMobileNumber.DefaultCellStyle = dataGridViewCellStyle2;
            this.TableMobileNumber.Frozen = true;
            this.TableMobileNumber.HeaderText = "Номер телефона";
            this.TableMobileNumber.MinimumWidth = 6;
            this.TableMobileNumber.Name = "TableMobileNumber";
            this.TableMobileNumber.Width = 80;
            // 
            // TableOtherInformation
            // 
            this.TableOtherInformation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableOtherInformation.DefaultCellStyle = dataGridViewCellStyle3;
            this.TableOtherInformation.Frozen = true;
            this.TableOtherInformation.HeaderText = "Дополнительная информация о холдинге";
            this.TableOtherInformation.MinimumWidth = 6;
            this.TableOtherInformation.Name = "TableOtherInformation";
            this.TableOtherInformation.Width = 250;
            // 
            // TableHoldingCompanys
            // 
            this.TableHoldingCompanys.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableHoldingCompanys.DefaultCellStyle = dataGridViewCellStyle4;
            this.TableHoldingCompanys.Frozen = true;
            this.TableHoldingCompanys.HeaderText = "Входящие компании";
            this.TableHoldingCompanys.MinimumWidth = 6;
            this.TableHoldingCompanys.Name = "TableHoldingCompanys";
            this.TableHoldingCompanys.Width = 170;
            // 
            // HoldingIDTableTextBox
            // 
            this.HoldingIDTableTextBox.Frozen = true;
            this.HoldingIDTableTextBox.HeaderText = "HoldingID";
            this.HoldingIDTableTextBox.MinimumWidth = 6;
            this.HoldingIDTableTextBox.Name = "HoldingIDTableTextBox";
            this.HoldingIDTableTextBox.ReadOnly = true;
            this.HoldingIDTableTextBox.Visible = false;
            this.HoldingIDTableTextBox.Width = 125;
            // 
            // TableDeleteButton
            // 
            this.TableDeleteButton.Frozen = true;
            this.TableDeleteButton.HeaderText = "";
            this.TableDeleteButton.MinimumWidth = 6;
            this.TableDeleteButton.Name = "TableDeleteButton";
            this.TableDeleteButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TableDeleteButton.Text = "Удалить";
            this.TableDeleteButton.UseColumnTextForButtonValue = true;
            this.TableDeleteButton.Width = 80;
            // 
            // HoldingsLabel
            // 
            this.HoldingsLabel.AutoSize = true;
            this.HoldingsLabel.Location = new System.Drawing.Point(18, 304);
            this.HoldingsLabel.Name = "HoldingsLabel";
            this.HoldingsLabel.Size = new System.Drawing.Size(116, 20);
            this.HoldingsLabel.TabIndex = 12;
            this.HoldingsLabel.Text = "Ваши холдинги";
            this.HoldingsLabel.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableCompanyName,
            this.CompanyTableMobileNumber,
            this.CompanyTableOtherInformation,
            this.CompanyId,
            this.CompanyTableDeleteButton});
            this.dataGridView2.Location = new System.Drawing.Point(18, 349);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(758, 206);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            // CompanysLabel
            // 
            this.CompanysLabel.AutoSize = true;
            this.CompanysLabel.Location = new System.Drawing.Point(18, 304);
            this.CompanysLabel.Name = "CompanysLabel";
            this.CompanysLabel.Size = new System.Drawing.Size(122, 20);
            this.CompanysLabel.TabIndex = 14;
            this.CompanysLabel.Text = "Ваши компании";
            this.CompanysLabel.Visible = false;
            // 
            // AccountExitButton
            // 
            this.AccountExitButton.Location = new System.Drawing.Point(12, 15);
            this.AccountExitButton.Name = "AccountExitButton";
            this.AccountExitButton.Size = new System.Drawing.Size(110, 55);
            this.AccountExitButton.TabIndex = 15;
            this.AccountExitButton.Text = "Выйти из аккаунта";
            this.AccountExitButton.UseVisualStyleBackColor = true;
            this.AccountExitButton.Click += new System.EventHandler(this.AccountExitButton_Click);
            // 
            // TableCompanyName
            // 
            this.TableCompanyName.Frozen = true;
            this.TableCompanyName.HeaderText = "Название компании";
            this.TableCompanyName.MinimumWidth = 6;
            this.TableCompanyName.Name = "TableCompanyName";
            this.TableCompanyName.Width = 125;
            // 
            // CompanyTableMobileNumber
            // 
            this.CompanyTableMobileNumber.Frozen = true;
            this.CompanyTableMobileNumber.HeaderText = "Номер телефона";
            this.CompanyTableMobileNumber.MinimumWidth = 6;
            this.CompanyTableMobileNumber.Name = "CompanyTableMobileNumber";
            this.CompanyTableMobileNumber.Width = 125;
            // 
            // CompanyTableOtherInformation
            // 
            this.CompanyTableOtherInformation.Frozen = true;
            this.CompanyTableOtherInformation.HeaderText = "Другая информация";
            this.CompanyTableOtherInformation.MinimumWidth = 6;
            this.CompanyTableOtherInformation.Name = "CompanyTableOtherInformation";
            this.CompanyTableOtherInformation.Width = 125;
            // 
            // CompanyId
            // 
            this.CompanyId.Frozen = true;
            this.CompanyId.HeaderText = "";
            this.CompanyId.MinimumWidth = 6;
            this.CompanyId.Name = "CompanyId";
            this.CompanyId.Visible = false;
            this.CompanyId.Width = 125;
            // 
            // CompanyTableDeleteButton
            // 
            this.CompanyTableDeleteButton.HeaderText = "";
            this.CompanyTableDeleteButton.MinimumWidth = 6;
            this.CompanyTableDeleteButton.Name = "CompanyTableDeleteButton";
            this.CompanyTableDeleteButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CompanyTableDeleteButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CompanyTableDeleteButton.Text = "удалить";
            this.CompanyTableDeleteButton.UseColumnTextForButtonValue = true;
            this.CompanyTableDeleteButton.Width = 125;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 599);
            this.Controls.Add(this.AccountExitButton);
            this.Controls.Add(this.CompanysLabel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.HoldingsLabel);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.STButton2);
            this.Controls.Add(this.STButton1);
            this.Controls.Add(this.DHButton3);
            this.Controls.Add(this.GPButton3);
            this.Controls.Add(this.GPButton2);
            this.Controls.Add(this.GPButton1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.HelloLabel);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.MainMenu_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private DataGridView dataGridView1;
        private Label HoldingsLabel;
        private DataGridView dataGridView2;
        private Label CompanysLabel;
        private Button AccountExitButton;
        private DataGridViewTextBoxColumn TableHoldingName;
        private DataGridViewTextBoxColumn TableMobileNumber;
        private DataGridViewTextBoxColumn TableOtherInformation;
        private DataGridViewTextBoxColumn TableHoldingCompanys;
        private DataGridViewTextBoxColumn HoldingIDTableTextBox;
        private DataGridViewButtonColumn TableDeleteButton;
        private DataGridViewTextBoxColumn TableCompanyName;
        private DataGridViewTextBoxColumn CompanyTableMobileNumber;
        private DataGridViewTextBoxColumn CompanyTableOtherInformation;
        private DataGridViewTextBoxColumn CompanyId;
        private DataGridViewButtonColumn CompanyTableDeleteButton;
    }
}