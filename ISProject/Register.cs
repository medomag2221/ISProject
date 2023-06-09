﻿using ISProject.Dal.DatabaseModels;
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
    public partial class Register : Form
    {
        private readonly IISResourceService _resourceService;
        public Register(IISResourceService resourceService)
        {
            InitializeComponent();
            _resourceService = resourceService;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new Authorization(_resourceService).Show();
            this.Close();
        }

        private void PasswdCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (passwdCheckbox.Checked)
            {
                Passwd1.PasswordChar = '\0';
                Passwd2.PasswordChar = '\0';
            }
            else
            {
                Passwd1.PasswordChar = '*';
                Passwd2.PasswordChar = '*';
            }
        }

        private void RegisterFromForm_Click(object sender, EventArgs e)
        {
            if (FirstName.Text == String.Empty)
            {
                new ErrorForm(this, "Введите имя").Show();
            }
            else if (SecondName.Text == String.Empty)
            {
                new ErrorForm(this, "Введите фамилию").Show();
            }
            else if (LastName.Text == String.Empty)
            {
                new ErrorForm(this, "Введите отчество или прочерк (-) если его нету").Show();
            }
            else if (Email.Text == String.Empty)
            {
                new ErrorForm(this, "Введите email").Show();
            }
            else if (Login.Text == String.Empty)
            {
                new ErrorForm(this, "Введите логин").Show();
            }
            else if (JobTitle.Text == String.Empty)
            {
                new ErrorForm(this, "Выберите должность").Show();
            }
            else if (Passwd1.Text == String.Empty)
            {
                new ErrorForm(this, "Введите пароль").Show();
            }
            else if (Passwd2.Text == String.Empty)
            {
                new ErrorForm(this, "Повторите пароль").Show();
            }
            else if (Passwd2.Text != Passwd1.Text)
            {
                new ErrorForm(this, "Пароли не совпадают. Убедитесь, что введенные пароли совпадают и повторите попытку").Show();
            }
            else
            {
                var user = new UserModel
                {
                    FirstName = FirstName.Text,
                    SecondName = SecondName.Text,
                    LastName = LastName.Text,
                    Email = Email.Text,
                    Login = Login.Text,
                    JobTitle = JobTitle.Text,
                    PasswordHash = Passwd1.Text
                };
                var ans = _resourceService.RegisterUser(user);
                if (ans == false) 
                {
                    new ErrorForm(this, "Пользователь с таким логином уже существует").Show();
                }
                else
                {
                    new SuccessForm(this, "Регистрация успешна").Show();
                }
            }

        }
    }
}
