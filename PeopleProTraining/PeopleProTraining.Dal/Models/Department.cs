using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleProTraining.Dal.Models
{
    
    [MetadataType(typeof(DepartmentMetaData))]

    public partial class Department
    {
    }

    public class DepartmentMetaData
    {
        public int DepartementID { get; set; }
    
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        public float Budget { get; set; }
    }

}
