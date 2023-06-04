using ISProject.Dal.DatabaseModels;
using ISProject.Interfaces;
using System.Windows.Forms;

namespace ISProject
{
    public partial class MainMenu : Form
    {
        private readonly UserModel _user;
        private readonly IISResourceService _resourceService;
        public MainMenu(UserModel user, IISResourceService resourceService)
        {
            InitializeComponent();
            _user = user;
            _resourceService = resourceService;
        }

        public void fillHoldingsTable()
        {
            dataGridView1.Rows.Clear();
            List<HoldingModel> holdings = _resourceService.GetHoldings();
            foreach (HoldingModel holding in holdings) 
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = holding.HoldingName;
                row.Cells[1].Value = holding.MobileNumber;
                row.Cells[2].Value = holding.OtherInformation;
                row.Cells[3].Value = _resourceService.GetHoldingCompanysNames(holding.HoldingId);
                row.Cells[4].Value = holding.HoldingId;
                dataGridView1.Rows.Add(row);
            }
        }

        public void fillCompaniesTable()
        {
            dataGridView2.Rows.Clear();
            List<CompanyModel> companys = _resourceService.GetCompanies();
            foreach (CompanyModel company in companys)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView2);
                row.Cells[0].Value = company.CompanyName;
                row.Cells[1].Value = company.MobileNumber;
                row.Cells[2].Value = company.OtherInformation;
                row.Cells[3].Value = company.CompanyId;
                dataGridView1.Rows.Add(row);
            }
        }

        public static string GetTimeOfDay()
        {
            DateTime currentTime = DateTime.Now;
            int currentHour = currentTime.Hour;

            if (currentHour >= 6 && currentHour < 12) return "Доброе утро";
            else if (currentHour >= 12 && currentHour < 18) return "Добрый день";
            else if (currentHour >= 18 && currentHour < 22) return "Добрый вечер";
            else return "Доброй ночи";
        }
        /*
          Глава холдинга
          Глава предприятия
          Работник отдела статистики
        */
        private void MainMenu_Load_1(object sender, EventArgs e)
        {
            if (_user.JobTitle == "Глава холдинга")
            {
                this.Size = new System.Drawing.Size(800, 520);
                STButton2.Location = new System.Drawing.Point(200, 160);
                STButton1.Location = new System.Drawing.Point(200, 120);
                DHButton3.Location = new System.Drawing.Point(200, 80);
                STButton2.Visible = true;
                STButton1.Visible = true;
                DHButton3.Visible = true;
                HoldingsLabel.Visible = true;
                dataGridView1.Visible = true;
                HelloLabel.Text = GetTimeOfDay() + ' ' + _user.SecondName + ' ' + _user.FirstName;
                fillHoldingsTable();

            }
            else if (_user.JobTitle == "Глава предприятия")
            {
                this.Size = new System.Drawing.Size(710, 470);
                GPButton1.Visible = true;
                GPButton2.Visible = true;
                GPButton3.Visible = true;
                CompanysLabel.Visible = true;
                dataGridView2.Visible = true;
                HelloLabel.Text = GetTimeOfDay() + ' ' + _user.SecondName + ' ' + _user.FirstName;
                fillCompaniesTable();
            }
            else if (_user.JobTitle == "Работник отдела статистики")
            {
                this.Size = new System.Drawing.Size(710, 260);
                STButton1.Visible = true;
                STButton2.Visible = true;
                HelloLabel.Text = GetTimeOfDay() + ' ' + _user.SecondName + ' ' + _user.FirstName;
            }
        }

        private void DHButton3_Click(object sender, EventArgs e)
        {
            new AddingHolding(_user, _resourceService).Show();
            this.Hide();
        }

        private void GPButton1_Click(object sender, EventArgs e)
        {

        }

        private void GPButton2_Click(object sender, EventArgs e)
        {

        }

        private void GPButton3_Click(object sender, EventArgs e)
        {
            new AddingCompany(_resourceService) { user = _user }.Show();
            this.Hide();
        }

        private void STButton2_Click(object sender, EventArgs e)
        {

        }

        private void STButton1_Click(object sender, EventArgs e)
        {

        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            string hours = DateTime.Now.Hour.ToString("00");
            string minutes = DateTime.Now.Minute.ToString("00");

            string time = $"{hours}:{minutes}";
            Time.Text = time;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                string holdingName = row.Cells[0].Value.ToString();
                string mobileNumber = row.Cells[1].Value.ToString();
                string otherInformation = row.Cells[2].Value.ToString();
                int holdingId = int.Parse(row.Cells[4].Value.ToString());

                HoldingModel holdingModel = new HoldingModel()
                {
                    HoldingName = holdingName,
                    MobileNumber = mobileNumber,
                    OtherInformation = otherInformation,
                    HoldingId = holdingId
                };
                _resourceService.ChangeHolding(holdingModel);
            }
        }

        private void AccountExitButton_Click(object sender, EventArgs e)
        {
            new Authorization(_resourceService).Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                int holdingId = int.Parse(row.Cells[4].Value.ToString());
                _resourceService.DeleteHolding(holdingId);
                fillHoldingsTable();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridView2.Rows[rowIndex];
                int companyId = int.Parse(row.Cells[3].Value.ToString());
                _resourceService.DeleteCompany(companyId);
                fillCompaniesTable();
            }
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridView2.Rows[rowIndex];
                string companyName = row.Cells[0].Value.ToString();
                string mobileNumber = row.Cells[1].Value.ToString();
                string otherInformation = row.Cells[3].Value.ToString();
                int companyId = int.Parse(row.Cells[4].Value.ToString());

                CompanyModel holdingModel = new CompanyModel()
                {
                    CompanyName = companyName,
                    MobileNumber = mobileNumber,
                    OtherInformation = otherInformation,
                    CompanyId = companyId
                };
                //_resourceService.ChangeHolding(holdingModel);
            }
        }
    }
}
