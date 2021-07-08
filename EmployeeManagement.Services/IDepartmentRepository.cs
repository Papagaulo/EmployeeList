using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManagement.Models;

namespace EmployeeManagement.Services
{
    public interface IDepartmentRepository
    {
         Task<IEnumerable<Department>> GetDepartments();
         Task<Department> GetDepartment(int departmentId);
    }
}