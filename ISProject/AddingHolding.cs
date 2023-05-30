using ISProject.Dal.DatabaseModels;
using ISProject.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISProject
{
    public partial class AddingHolding : Form
    {
        private readonly IISResourceService _resourceService;
        private readonly UserModel _user;
        public AddingHolding(UserModel user, IISResourceService resourceService)
        {
            InitializeComponent();
            _user = user;
            _resourceService = resourceService;
        }

        private void AddHoldingButton_Click(object sender, EventArgs e)
        {
            if (HoldingNameTextBox.Text == String.Empty) 
            {
                new ErrorForm(this, "Введите название холдинга").Show();
            }
            else if (HoldingMobileNumberTextBox.Text == String.Empty)
            {
                new ErrorForm(this, "Введите контактный номер телефона").Show();
            }
            else if (HoldingOtherInformationRichTextBox.Text == String.Empty)
            {
                new ErrorForm(this, "Введите дополнительную информацию о холдинге или прочерк если данных нету").Show();
            }
            else
            {
                var holding = new HoldingModel()
                {
                    HoldingName = HoldingNameTextBox.Text,
                    MobileNumber = HoldingMobileNumberTextBox.Text,
                    OtherInformation = HoldingOtherInformationRichTextBox.Text,
                    DirectorId = _user.UserId
                };
                _resourceService.AddHolding(holding);
                new SuccessForm(this, "Добавление холдинга успешно");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
