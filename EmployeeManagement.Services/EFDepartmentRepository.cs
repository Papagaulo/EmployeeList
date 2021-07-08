using System.Collections.Generic;
using EmployeeManagement.Models;
using EmployeeManagement.Brokers;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Services
{
    public class EFDepartmentRepository : IDepartmentRepository
    {
        readonly AppDbContext context;

        public EFDepartmentRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<Department> GetDepartment(int departmentId)
        {
            return await context.Departments.FirstOrDefaultAsync<Department>(i => i.DepartmentId == departmentId);

        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await context.Departments.ToListAsync();
        }
    }
}