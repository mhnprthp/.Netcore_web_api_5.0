using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testemp.Model;
using testemp.Service;
using testemp.Service.Interface;

namespace testemp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeContoller : ControllerBase
    {
       private readonly IEmployeeService _iemployeeservice;
    // //     public EmployeeContoller(IEmployeeService empserv)
    // //    {
    // //     empserv = _iemployeeservice;
            
    // //    }

public EmployeeContoller(IEmployeeService empserv)
{
    _iemployeeservice = empserv;
}
    

       [HttpGet]
        public List<Employee> GetEmployees()
        {
           
           return _iemployeeservice.GetEmployees();
        }

          [HttpGet("GetEmployeebyId")]
        public Employee EmployeeById(int Id)
        {
            return _iemployeeservice.GetEmployeeById(Id);
        }


        [HttpPost]
        public void SaveEmployee([FromBody] Employee employee)
        {
            _iemployeeservice.SaveEmployee(employee);
        }


        [HttpPut]
        public void Put(int Id, [FromBody] Employee employeeDto)
        {
            _iemployeeservice.UpdateEmployee(employeeDto);
        }

        [HttpDelete("Delete")]
        public void Delete(int Id)
        {
            _iemployeeservice.DeleteEmployee(Id);
        }
    }
}