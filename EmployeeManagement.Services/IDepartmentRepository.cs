using System;
using System.Collections.Generic;
using EmployeeManagement.Models;

namespace EmployeeManagement.Services
{
    public interface IDepartmentRepository
    {
         IEnumerable<Department> GetDepartments();
         Department GetDepartment(int departmentId);
    }
}