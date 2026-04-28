using CSharpExercises.Exercises.Exercise1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExercises.Exercises.Exercise1.Services
{
    internal class EmployeeService
    {
        private List<Employee> _employees = new();

        public EmployeeService()
        {
            // mock
            _employees.Add(new Employee
            {
                FirstName = "Yang",
                LastName = "Li",
                Salaray = 30000
            });

            _employees.Add(new Employee
            {
                FirstName = "Panpan",
                LastName = "Li",
                Salaray = 35000
            });
        }

        public List<Employee> GetAllEmployees() {
            return _employees;
        }
    }
}
