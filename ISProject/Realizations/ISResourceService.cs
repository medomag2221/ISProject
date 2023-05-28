using ISProject.Dal;
using ISProject.Dal.DatabaseModels;
using ISProject.Interfaces;
using BCryptNet = BCrypt.Net.BCrypt;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISProject.Realizations
{
    public class ISResourceService : IISResourceService
    {
        private readonly ISDataContext _dbContext;
        private readonly PasswordHasher passwordHasher = new PasswordHasher();

        public ISResourceService(ISDataContext dbContext)
        {
            _dbContext = dbContext;
        }
        public UserModel GetUserByLoginAndPassword(AuthorisationDto auth)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Login == auth.Login && passwordHasher.VerifyPassword(u.PasswordHash, passwordHasher.HashPassword(auth.Password)));
            if (user != null)
            {
                return user;
            }
            else
            {
                return new UserModel();
            }
        }

        public void RegisterUser(UserModel user)
        {
            user.PasswordHash = passwordHasher.HashPassword(user.PasswordHash);
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }
    }
    public class PasswordHasher
    {
        public string HashPassword(string password)
        {
            string salt = BCryptNet.GenerateSalt();
            string hashedPassword = BCryptNet.HashPassword(password, salt);
            return hashedPassword;
        }

        public bool VerifyPassword(string password, string hashedPassword)
        {
            return BCryptNet.Verify(password, hashedPassword);
        }
    }
}
