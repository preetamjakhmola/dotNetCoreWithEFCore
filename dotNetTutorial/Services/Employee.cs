using dotNetTutorial.Contract;
using dotNetTutorial.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetTutorial.Services
{
    public class Employee : IEmployee
    {
        private readonly StudentManagementContextRepository _dbContext;

        public Employee(StudentManagementContextRepository dbContext)
        {
            this._dbContext = dbContext;
        }

        public EmpMaster AddEmployee(EmpMaster employee)
        {
            if (employee == null)
            { return null; }
            employee.Id = 0;
            _dbContext.EmpMaster.Add(employee);
            _dbContext.SaveChanges();
            return employee;
        }

        public EmpMaster DeleteEmployee(int id)
        {
            var getEmp = _dbContext.EmpMaster.FirstOrDefault(x => x.Id == id);
            _dbContext.Entry(getEmp).State = EntityState.Deleted;
            _dbContext.SaveChanges();
            return getEmp;
        }

        public EmpMaster GetEmployeeById(int id)
        {
            var getEmp = _dbContext.EmpMaster.FirstOrDefault(x => x.Id == id);
            return getEmp;
        }

        public IEnumerable<EmpMaster> GetEmployees()
        {
            var emp = _dbContext.EmpMaster.ToList();
            return emp;
        }

        public EmpMaster UpdateEmployee(EmpMaster employee)
        {
            var getEmp = _dbContext.EmpMaster.FirstOrDefault(x => x.Id == employee.Id);
            if (getEmp == null)
            {
                return null;
            }
            getEmp.Name = employee.Name;
            getEmp.City = employee.City;
            getEmp.Phone = employee.Phone;
            getEmp.Email = employee.Email;  
            _dbContext.Entry(getEmp).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return getEmp; 
        }
    }
}
