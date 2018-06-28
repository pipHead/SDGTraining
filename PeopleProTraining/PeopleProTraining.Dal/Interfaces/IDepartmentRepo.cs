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
        IQueryable<Department2> GetDepartments();
        IEnumerable<Department2> GetDepartments(Func<Department2, bool> predicate);

        Department2 GetDepartment(Func<Department2, bool> predicate);
        Department2 GetDepartment(int id);
        #endregion
        #endregion
    }
}
