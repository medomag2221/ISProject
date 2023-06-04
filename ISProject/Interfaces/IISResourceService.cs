using ISProject.Dal.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISProject.Interfaces
{
    public interface IISResourceService
    {
        public UserModel GetUserByLoginAndPassword(AuthorisationDto auth);
        public bool RegisterUser(UserModel user);

        public bool AddHolding(HoldingModel holding);
        void ChangeHolding(HoldingModel updatedHolding);
        void DeleteHolding(int holdingId);
        public Dictionary<int, string> GetHoldingsDict();
        public bool AddCompany(CompanyModel holding);
        void ChangeCompany(CompanyModel updatedCompany);
        void DeleteCompany(int companyId);
        public List<CompanyModel> GetCompanies();
        public List<HoldingModel> GetHoldings();
        public string GetHoldingCompanysNames(int holdingId);
    }
}
