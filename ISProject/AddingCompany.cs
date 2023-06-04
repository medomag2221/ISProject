using ISProject.Dal.DatabaseModels;
using ISProject.Interfaces;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ISProject
{
    public partial class AddingCompany : Form
    {
        private readonly IISResourceService _resourceService;
        public UserModel user { get; set; }
        public AddingCompany(IISResourceService resourceService)
        {
            InitializeComponent();
            _resourceService = resourceService;
        }

        private void AddingCompany_Load(object sender, EventArgs e)
        {
            var holdings =_resourceService.GetHoldingsDict();
            var holdingList = holdings.Select(kv => new KeyValuePair<int, string>(kv.Key, kv.Value)).ToList();
            HoldingsComboBox.DataSource = holdingList;
            HoldingsComboBox.DisplayMember = "Value";
            HoldingsComboBox.ValueMember = "Key";
        }

        private void AddCompanyButton_Click(object sender, EventArgs e)
        {
            if (CompanyNameTextBox.Text == String.Empty)
            {
                new ErrorForm(this, "Введите название компании").Show();
            }
            else if (CompanyMobileNumberTextBox.Text == String.Empty)
            {
                new ErrorForm(this, "Введите контактный номер телефона").Show();
            }
            else if (CompanyOtherInformationRichTextBox.Text == String.Empty)
            {
                new ErrorForm(this, "Введите дополнительную информацию о компании или прочерк если данных нет").Show();
            }
            else if (HoldingsComboBox.SelectedIndex == -1)
            {
                new ErrorForm(this, "Выберите холдинг к которому принадлежит компания").Show();
            }
            else
            {
                var company = new CompanyModel()
                {
                    CompanyName = CompanyNameTextBox.Text,
                    MobileNumber = CompanyMobileNumberTextBox.Text,
                    OtherInformation = CompanyOtherInformationRichTextBox.Text,
                    DirectorId = user.UserId,
                    HoldingId = (int)HoldingsComboBox.SelectedValue
                };
                var resp = _resourceService.AddCompany(company);
                if (resp == false) new ErrorForm(this, "Такая компания уже существет").Show();
                else new SuccessForm(this, "Добавление компании успешно").Show();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {

        }
    }
}
