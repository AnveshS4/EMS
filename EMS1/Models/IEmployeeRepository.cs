using System;
namespace EMS1.Models
{
	public interface IEmployeeRepository
	{
        Employee GetEmployee(int v);
        List<Employee> GetEmployees();
        List<Employee> AddEmployee(Employee Employees);
	}
}

