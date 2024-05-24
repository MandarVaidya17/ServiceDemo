﻿
using ServiceDemo.Model;
using ServiceDemo.Repositories;

namespace ServiceDemo.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository repo;
        public EmployeeService(IEmployeeRepository repo)
        {
            this.repo = repo;
        }

        public int AddEmployee(Employee employee)
        {
            return repo.AddEmployee(employee);
        }

        public int DeleteEmployee(int id)
        {
            return repo.DeleteEmployee(id);
        }

        public int EditEmpoyee(Employee employee)
        {
            return repo.EditEmpoyee(employee);
        }

        public Employee GetEmployeeById(int id)
        {
            return repo.GetEmployeeById(id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return repo.GetEmployees();
        }
    }
}
