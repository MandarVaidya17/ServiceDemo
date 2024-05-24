using ServiceDemo.Model;

namespace ServiceDemo.Service
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeById(int id);
        int AddEmployee(Employee employee);
        int EditEmpoyee(Employee employee);
        int DeleteEmployee(int id);
    }
}
