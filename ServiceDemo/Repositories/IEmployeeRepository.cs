using ServiceDemo.Model;

namespace ServiceDemo.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeById(int id);
        int AddEmployee(Employee employee);
        int EditEmpoyee(Employee employee);
        int DeleteEmployee(int id);
    }
}

