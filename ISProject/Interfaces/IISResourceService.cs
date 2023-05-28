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
        public void RegisterUser(UserModel user);
    }
}
