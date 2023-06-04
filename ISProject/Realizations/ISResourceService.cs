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

        public bool AddCompany(CompanyModel company)
        {
            if (_dbContext.Companys.Any(h => h.CompanyName == company.CompanyName
                                    && h.DirectorId == company.DirectorId
                                    && h.MobileNumber == company.MobileNumber
                                    && h.OtherInformation == company.OtherInformation
                                    && h.HoldingId == company.HoldingId))
            {
                return false;
            }
            _dbContext.Companys.Add(company);
            _dbContext.SaveChanges();
            return true;
        }

        public void ChangeCompany(CompanyModel updatedCompany)
        {
            var existingCompany = _dbContext.Companys.FirstOrDefault(c => c.CompanyId == updatedCompany.CompanyId);
            if (existingCompany != null)
            {
                existingCompany.CompanyName = updatedCompany.CompanyName;
                existingCompany.MobileNumber = updatedCompany.MobileNumber;
                existingCompany.HoldingId = updatedCompany.HoldingId;
                existingCompany.OtherInformation = updatedCompany.OtherInformation;
                _dbContext.SaveChanges();
            }
        }

        public void DeleteCompany(int companyId)
        {
            var companyToDelete = _dbContext.Companys.FirstOrDefault(c => c.CompanyId == companyId);
            if (companyToDelete != null)
            {
                _dbContext.Companys.Remove(companyToDelete);
                _dbContext.SaveChanges();
            }
        }
        public List<CompanyModel> GetCompanies()
        {
            var companies = _dbContext.Companys
                .ToList();
            return companies;
        }
        public bool AddHolding(HoldingModel holding)
        {
            if (_dbContext.Holdings.Any(h => h.HoldingName == holding.HoldingName
                                    && h.DirectorId == holding.DirectorId
                                    && h.MobileNumber == holding.MobileNumber
                                    && h.OtherInformation == holding.OtherInformation))
            {
                return false;
            }
            _dbContext.Holdings.Add(holding);
            _dbContext.SaveChanges();
            return true;
        }

        public void ChangeHolding(HoldingModel updatedHolding)
        {
            var existingHolding = _dbContext.Holdings.FirstOrDefault(h => h.HoldingId == updatedHolding.HoldingId);
            if (existingHolding != null)
            {
                existingHolding.HoldingName = updatedHolding.HoldingName;
                existingHolding.MobileNumber = updatedHolding.MobileNumber;
                existingHolding.OtherInformation = updatedHolding.OtherInformation;
                _dbContext.SaveChanges();
            }
        }

        public void DeleteHolding(int holdingId)
        {
            var holdingToDelete = _dbContext.Holdings.FirstOrDefault(h => h.HoldingId == holdingId);
            if (holdingToDelete != null)
            {
                _dbContext.Holdings.Remove(holdingToDelete);
                _dbContext.SaveChanges();
            }
        }

        public Dictionary<int,string> GetHoldingsDict()
        {
            var holdings = _dbContext.Holdings
                .ToDictionary(h => h.HoldingId, h => h.HoldingName);
            return holdings;
        }

        public List<HoldingModel> GetHoldings()
        {
            var holdings = _dbContext.Holdings
                .ToList();
            return holdings;
        }

        public string GetHoldingCompanysNames(int holdingId)
        {
            var companyNames = _dbContext.Companys
            .Where(c => c.HoldingId == holdingId)
            .Select(c => c.CompanyName)
            .ToList();

            return string.Join("\n", companyNames);
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

        public bool RegisterUser(UserModel user)
        {
            if (_dbContext.Users.Any(u => u.Login == user.Login))
            {
                return false;
            }
            user.PasswordHash = _passwordHasher.HashPassword(user.PasswordHash);
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();

            return true;
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
