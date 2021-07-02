using System.Collections.Generic;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        protected IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(loadEmployees);
        }

        void loadEmployees()
        {
            System.Threading.Thread.Sleep(1000);
            Employee e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "Vegeta",
                LastName = "Stephens",
                Email = "David@pragimtech.com",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                DepartmentId =  1,
                PhotoPath = "images/john.jpg"
            };
            Employee e2 = new Employee
            {
                EmployeeId = 2,
                FirstName = "Sam",
                LastName = "Galloway",
                Email = "Sam@pragimtech.com",
                DateOfBirth = new DateTime(1981, 12, 22),
                Gender = Gender.Male,
                DepartmentId = 2,
                PhotoPath = "images/sam.jpg"
            };
            Employee e3 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Mary",
                LastName = "Smith",
                Email = "mary@pragimtech.com",
                DateOfBirth = new DateTime(1979, 11, 11),
                Gender = Gender.Female,
                DepartmentId = 1,
                PhotoPath = "images/mary.jpg"
            };
            Employee e4 = new Employee
            {
                EmployeeId = 4,
                FirstName = "Sara",
                LastName = "Longway",
                Email = "sara@pragimtech.com",
                DateOfBirth = new DateTime(1982, 9, 23),
                Gender = Gender.Male,
                DepartmentId = 3,
                PhotoPath = "images/sara.jpg"
            };
            Employees = new List<Employee>{e1,e2,e3,e4};
        }
    }

}