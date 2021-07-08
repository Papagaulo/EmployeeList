using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using EmployeeManagement.Brokers;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Services
{
    public class EFEmployeeRepository : IEmployeeRepository
    {
        readonly AppDbContext context;

        public EFEmployeeRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            var result = await context.AddAsync<Employee>(employee);
            await context.SaveChangesAsync();
            return result.Entity;
        }

        public async void DeleteEmployee(int employeeId)
        {
            var result = await context.Employees.FirstOrDefaultAsync(i => i.EmployeeId == employeeId);
            if (result != null)
            {
                await context.SaveChangesAsync();
            }

        }

        public async Task<Employee> GetEmployee(int employeeId)
        {
            return await context.Employees.FirstOrDefaultAsync<Employee>(i => i.EmployeeId == employeeId);

        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await context.Employees.ToListAsync();
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var result = await context.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employee.EmployeeId);

            if (result != null)
            {
                result.FirstName = employee.FirstName;
                result.LastName = employee.LastName;
                result.Email = employee.Email;
                result.DateOfBirth = employee.DateOfBirth;
                result.Gender = employee.Gender;
                result.DepartmentId = employee.DepartmentId;

                await context.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}