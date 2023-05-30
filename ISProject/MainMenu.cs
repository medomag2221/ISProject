using ISProject.Dal.DatabaseModels;
using ISProject.Interfaces;

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
                STButton2.Visible = true;
                STButton1.Visible = true;
                DHButton3.Visible = true;
                HelloLabel.Text = GetTimeOfDay() + ' ' + _user.SecondName + ' ' + _user.FirstName;
            }
            else if (_user.JobTitle == "Глава предприятия")
            {
                GPButton1.Visible = true;
                GPButton2.Visible = true;
                GPButton3.Visible = true;
                HelloLabel.Text = GetTimeOfDay() + ' ' + _user.SecondName + ' ' + _user.FirstName;
            }
            else if (_user.JobTitle == "Работник отдела статистики")
            {
                STButton1.Visible = true;
                STButton2.Visible = true;
                HelloLabel.Text = GetTimeOfDay() + ' ' + _user.SecondName + ' ' + _user.FirstName;
            }
        }

        private void DHButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddingHolding(_user, _resourceService).Show();
        }

        private void GPButton1_Click(object sender, EventArgs e)
        {

        }

        private void GPButton2_Click(object sender, EventArgs e)
        {

        }

        private void GPButton3_Click(object sender, EventArgs e)
        {

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
    }
}
