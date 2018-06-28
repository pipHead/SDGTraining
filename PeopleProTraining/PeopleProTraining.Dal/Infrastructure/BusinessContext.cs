using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleProTraining.Dal.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace PeopleProTraining.Dal.Infrastructure
{
    class BusinessContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department2> Departments { get; set; }
    }
}
