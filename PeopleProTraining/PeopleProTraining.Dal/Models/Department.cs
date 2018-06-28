using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleProTraining.Dal.Models
{
    class Department
    {
        public int DepartementID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        public float Budget { get; set; }


        public ICollection<Employee> Employees { get; set; }
    }

    
}
