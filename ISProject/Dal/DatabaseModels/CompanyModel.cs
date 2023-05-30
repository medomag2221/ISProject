using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISProject.Dal.DatabaseModels
{
    public class CompanyModel
    {
        [Key]
        public int CompanyId { get; set; }

        public string CompanyName { get; set; }
        public int DirectorId { get; set; } //UserId

        public string MobileNumber { get; set; }
        public int HoldingId { get; set; }
        public string OtherInformation { get; set; }
    }
}
