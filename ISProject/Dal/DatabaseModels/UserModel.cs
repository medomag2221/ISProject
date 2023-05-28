using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISProject.Dal.DatabaseModels
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; } //ну или пока без шифрования

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string Email { get; set; }
    }

    public class AuthorisationDto
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
