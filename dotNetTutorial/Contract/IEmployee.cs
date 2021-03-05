using dotNetTutorial.DbModels;
using dotNetTutorial.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetTutorial.Contract
{
    public interface IEmployee
    {
        IEnumerable<EmpMaster> GetEmployees();
        EmpMaster GetEmployeeById(int id);
        EmpMaster AddEmployee(EmpMaster employee);
        EmpMaster UpdateEmployee(EmpMaster employee);
        EmpMaster DeleteEmployee(int id);
    }
}
