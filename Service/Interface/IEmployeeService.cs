using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testemp.Controllers;
using testemp.Model;

namespace testemp.Service.Interface
{
    public interface IEmployeeService
    {
        public List<Employee> GetEmployees();
        public void SaveEmployee(Employee EmpDto);
        public Employee GetEmployeeById(int Id);
        public void UpdateEmployee(Employee employeeDto);
        public void DeleteEmployee(int Id);
    }
}