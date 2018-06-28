using PeopleProTraining.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleProTraining.Dal.Interfaces
{
    public interface IDepartmentRepo 
    {
        #region access

        #region departments
        IQueryable<Department> GetDepartments();
        IEnumerable<Department> GetDepartments(Func<Department, bool> predicate);

        Department GetDepartment(Func<Department, bool> predicate);
        Department GetDepartment(int id);
        #endregion
        #endregion
    }
}
