using CSharpExercises.Exercises.Exercise1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
                Salary = 30000
            });

            _employees.Add(new Employee
            {
                FirstName = "Panpan",
                LastName = "Li",
                Salary = 35000
            });
        }

        public List<Employee> GetAllEmployees() {
            return _employees;
        }

        public bool AddEmployee(string firstName, string lastName, int salary) {

            _employees.Add(new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                Salary = salary
            });

            return true;
        }
    }
}
