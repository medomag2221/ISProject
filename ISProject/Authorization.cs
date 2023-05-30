using ISProject.Dal.DatabaseModels;
using ISProject.Interfaces;

namespace ISProject
{
    public partial class Authorization : Form
    {
        private readonly IISResourceService _resourceService;
        public Authorization(IISResourceService resourceService)
        {
            InitializeComponent();
            _resourceService = resourceService;
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Register reg = new(_resourceService);
            reg.Show();
            this.Hide();
        }

        private void Entry_Click(object sender, EventArgs e)
        {
            if (Login.Text == String.Empty)
            {
                new ErrorForm(this, "Введите логин").Show();
            }
            else if (Password.Text == String.Empty) 
            {
                new ErrorForm(this, "Введите пароль").Show();
            }
            else
            {
                var user = _resourceService.GetUserByLoginAndPassword(new AuthorisationDto() { Login = Login.Text, Password = Password.Text });
                if (user.Login == null)
                {
                    new ErrorForm(this, "Пользователя с таким логином или паролем не существует").Show();
                }
                else 
                {
                    new MainMenu(user, _resourceService).Show();
                    this.Hide();
                }
            }
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked) Password.PasswordChar = '\0';
            else Password.PasswordChar = '*';
        }
    }
}