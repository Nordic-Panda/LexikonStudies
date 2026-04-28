using CSharpExercises.Exercises.Exercise1.Models;

namespace CSharpExercises.Exercises.Exercise1.Services
{
    internal class EmployeeService
    {
        private List<Employee> _employees = new();

        public EmployeeService()
        {
        }

        public List<Employee> GetAllEmployees() 
        {
            return _employees;
        }

        public bool AddEmployee(string firstName, string lastName, int salary) 
        {
            _employees.Add(new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                Salary = salary
            });

            return true;
        }

        public bool EditEmployee(string firstName, string lastName, int salary, int index)
        {
            var emp = _employees[index];
            emp.FirstName = firstName;
            emp.LastName = lastName;
            emp.Salary = salary;

            return true;
        }

        public bool RemoveEmployee(int index) 
        {
            _employees.RemoveAt(index);

            return true;
        }
    }
}
