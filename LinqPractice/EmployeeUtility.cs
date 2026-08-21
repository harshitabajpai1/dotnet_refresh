using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeConsoleApp
{
    public class EmployeeUtility
    {
        private List<Employee> employees;

        public EmployeeUtility()
        {
            employees = EmployeeRepo.GetEmployees();
        }

        public List<Employee> GetAllEmployees()
        {
            var result = employees.ToList();
            return result;
        }
        public List<Employee> GetEmployeesNotInMumbai()
        {
            var result = employees.Where(e => e.City != "Mumbai").ToList();
            return result;
        }

        public List<Employee> GetAsstManagers()
        {
            return employees.Where(e => e.Title == "AsstManager").ToList();
        }

        public List<Employee> GetLastNameStartsWithS()
        {
            return employees.Where(e => e.LastName.StartsWith("S")).ToList();
        }

        
        public List<Employee> GetJoinedBefore2015()
        {
            return employees.Where(e => e.DOJ < new DateTime(2015, 1, 1)).ToList();
        }
    }
}