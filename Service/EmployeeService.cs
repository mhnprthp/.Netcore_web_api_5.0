using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testemp.Model;
using testemp.Service.Interface;

namespace testemp.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmpDbContext _empDbContext;
       public EmployeeService(EmpDbContext empDbContext)
{
    _empDbContext = empDbContext;
}

        
        List<Employee> IEmployeeService.GetEmployees()
        {
            List<Employee> employees= new();
            var employeesDb = _empDbContext.Employees.ToList();
             foreach (var emp in employeesDb)
            {
                  Employee empDto = new()
                {
                    Id = emp.Id,
                    EmpFirstName= emp.EmpFirstName,
                    EmpLastName = emp.EmpLastName,
                    EmpDepartment = emp.EmpDepartment,
                    EmpEmail = emp.EmpEmail,
                    EmpPhone = emp.EmpPhone
                };

                employees.Add(empDto);

            }
            return employees;
        }



 public Employee GetEmployeeById(int Id)
        {
            var employee = _empDbContext.Employees.FirstOrDefault(e => e.Id == Id);
            Employee employeeById = new()
            {
                Id = employee.Id,
                EmpFirstName = employee.EmpFirstName,
                EmpLastName = employee.EmpLastName,
                EmpDepartment = employee.EmpDepartment,
                EmpEmail = employee.EmpEmail,
                EmpPhone = employee.EmpEmail
            };

            return employeeById;
        }

        public void SaveEmployee(Employee EmpDto)
        {
            Employee EmpDB = new()
            {
                Id = EmpDto.Id,
                EmpFirstName = EmpDto.EmpFirstName,
                EmpLastName =EmpDto.EmpLastName,
                EmpDepartment = EmpDto.EmpDepartment,
                EmpEmail = EmpDto.EmpEmail,
                EmpPhone = EmpDto.EmpPhone
            };

            _empDbContext.Employees.Add(EmpDB);
            _empDbContext.SaveChanges();
        }


         public void UpdateEmployee(Employee employeeDto)
        {
            var employeeDB = _empDbContext.Employees.FirstOrDefault(x => x.Id == employeeDto.Id);
            if (employeeDB != null)
            {
                employeeDB.Id = employeeDto.Id;
                employeeDB.EmpFirstName = employeeDto.EmpFirstName;
                  employeeDB.EmpLastName = employeeDto.EmpLastName;
                employeeDB.EmpDepartment = employeeDto.EmpDepartment;
                employeeDB.EmpEmail = employeeDto.EmpEmail;
                employeeDB.EmpPhone = employeeDto.EmpPhone;
                _empDbContext.Employees.Update(employeeDB);
                _empDbContext.SaveChanges();
            }
        }

         public void DeleteEmployee(int Id)
        {
            var employee = _empDbContext.Employees.FirstOrDefault(e => e.Id == Id);
            if (employee != null)
            {
                _empDbContext.Employees.Remove(employee);
                _empDbContext.SaveChanges();
            }
        }

    }
}