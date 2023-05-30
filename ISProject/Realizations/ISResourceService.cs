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
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ISProject.Realizations
{
    public class ISResourceService : IISResourceService
    {
        private readonly ISDataContext _dbContext;
        private readonly PasswordHasher _passwordHasher = new PasswordHasher();

        public ISResourceService(ISDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddCompany(CompanyModel company)
        {
            _dbContext.Companys.Add(company);
            _dbContext.SaveChanges();
        }

        public void AddHolding(HoldingModel holding)
        {
            _dbContext.Holdings.Add(holding);
            _dbContext.SaveChanges();
        }

        public UserModel GetUserByLoginAndPassword(AuthorisationDto auth)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Login == auth.Login);
            if (user != null && _passwordHasher.VerifyPassword(auth.Password, user.PasswordHash))
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
            user.PasswordHash = _passwordHasher.HashPassword(user.PasswordHash);
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
