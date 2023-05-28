using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISProject.Dal.DatabaseModels
{
    public class ReportModel
    {
        [Key]
        public int ReportId { get; set; }
        public int CompanyId { get; set; }
        public DateTime CreationTime { get; set; }
        public float Coming { get; set; }
        public float Spending { get; set; }
        public float Income { get; set; }
    }
}
