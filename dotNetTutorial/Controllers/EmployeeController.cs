using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotNetTutorial.Contract;
using dotNetTutorial.DbModels;
using dotNetTutorial.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotNetTutorial.Controllers
{
    [Route("api/Employee/")]
    public class EmployeeController : Controller
    {
        private readonly IEmployee _employee;

        public EmployeeController(IEmployee employee)
        {
            this._employee = employee;
        }

        [HttpGet]
        [Route("GetEmployee")]
        public IEnumerable<EmpMaster> GetEmployee()
        {
            var empResultSet = _employee.GetEmployees();
            return empResultSet;
        }
        [HttpGet]
        [Route("GetEmployeeById")]
        public EmpMaster GetEmployeeById(int id=0)
        {
            var empResultSet = _employee.GetEmployeeById(id);
            return empResultSet;
        }


        [HttpPost]
        [Route("AddEmp")]
        public EmpMaster AddEmployee(EmpMaster employee)
        {
            if (employee == null || employee.Name == null)
            {
                return null;
            }
            var empResultSet = _employee.AddEmployee(employee);
            return empResultSet;
        }


        [HttpPost]
        [Route("EditEmp")]
        public EmpMaster EditEmployee(EmpMaster employee)
        {
            if (employee == null || employee.Name == null)
            {
                return null;
            }
            var empResultSet = _employee.UpdateEmployee(employee);
            return empResultSet;
        }

        [HttpPost]
        [Route("DeleteEmp")]
        public EmpMaster DeleteEmployee(int id)
        {
            if (id == 0)
            {
                return null;
            }
            var empResultSet = _employee.DeleteEmployee(id);
            return empResultSet;
        }
    }
}
