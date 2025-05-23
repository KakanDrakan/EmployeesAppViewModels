﻿using EmployeesApp.Web.Models;
using EmployeesApp.Web.Views.Employees;

namespace EmployeesApp.Web.Services
{
    public class EmployeeService
    {
        List<Employee> employees =
        [
            new Employee()
            {
                Id = 562,
                Name = "Anders Hejlsberg",
                Email = "a.h@outlook.com",
            },
            new Employee()
            {
                Id = 62,
                Name = "Kathleen Dollard",
                Email = "k.d@outlook.com",
            },
            new Employee()
            {
                Id = 15662,
                Name = "Mads Torgersen",
                Email = "m.t@outlook.com",
            },
            new Employee()
            {
                Id = 52,
                Name = "Scott Hanselman",
                Email = "s.h@outlook.com",
            },
            new Employee()
            {
                Id = 563,
                Name = "Jon Skeet",
                Email = "j.s@outlook.com",
            },
        ];

        public void Add(Employee employee)
        {
            employee.Id = employees.Count < 0 ? 1 : employees.Max(e => e.Id) + 1;
            employees.Add(employee);
        }

        public Employee[] GetAll() => employees
            .OrderBy(e => e.Name)
            .ToArray();

        public Employee GetById(int id) => employees
            .Single(e => e.Id == id);

        public IndexVM[] GetAllIndexViewModels() => employees
            .Select(e => new IndexVM()
            {
                Id = e.Id,
                Name = e.Name,
                Email = e.Email,
                ShowAsHighlighted = ShowAsHighlighted(e),
            })
            .ToArray();
        public DetailsVM GetDetailsViewModel(int id)
        {
            var employee = GetById(id);
            return new DetailsVM()
            {
                Id = employee.Id,
                Name = employee.Name,
                Email = employee.Email,
            };
        }

        public bool ShowAsHighlighted(Employee employee)
        {
            return employee.Email.StartsWith("admin");
        }
    }
}