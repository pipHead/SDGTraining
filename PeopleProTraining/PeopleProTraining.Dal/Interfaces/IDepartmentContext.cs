using PeopleProTraining.Dal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PeopleProTraining.Dal.Interfaces
{
    class interface IDepartmentContext : IDisposable
    {
        IDbSet<Department> Departments { get; set; }
        int SaveChanges();
        DbEntityEntry Entry(object entity);
    }
}
