namespace ISProject
{
    public partial class ErrorForm : Form
    {

        public ErrorForm(Form owner, string error)
        {
            InitializeComponent();
            Owner = owner;
            ErrorLabel.Text = error;
        }

        private void InitializeComponents()
        {
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ErrorForm_Load(object sender, EventArgs e)
        {
        }

    }
}
