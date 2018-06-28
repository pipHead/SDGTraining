using PeopleProTraining.Dal.Interfaces;
using PeopleProTraining.Dal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleProTraining.Dal.Infrastructure
{
    class DepartmentContext : DbContext, IDepartmentContext
    {
        public DepartmentContext() : base("name=PeopleProTrainingDB")
        {

        }

        public IDbSet<Department2> Departments { get; set; }

    }
}
