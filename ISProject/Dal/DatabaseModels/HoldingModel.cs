using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISProject.Dal.DatabaseModels
{
    public class HoldingModel
    {
        [Key]
        public int HoldingId { get; set; }
        public string HoldingName { get; set; }
        public int DirectorId { get; set; }
        public string MobileNumber { get; set; }
        public string OtherInformation { get; set; }
    }
}
