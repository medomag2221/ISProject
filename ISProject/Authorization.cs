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
            this.Hide();
            Register reg = new(_resourceService);
            reg.Show();
        }

        private void Entry_Click(object sender, EventArgs e)
        {
            if (Login.Text == String.Empty)
            {
                new ErrorForm(this, "¬ведите логин").Show();
            }
            else if (Password.Text == String.Empty) 
            {
                new ErrorForm(this, "¬ведите пароль").Show();
            }
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked) Password.PasswordChar = '\0';
            else Password.PasswordChar = '*';
        }
    }
}