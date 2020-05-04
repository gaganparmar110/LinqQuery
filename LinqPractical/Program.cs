using LinqPractical.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqPractical
{
    class Program
    {
        static void Main(string[] args)
        {

            IList<Employee> employee = new List<Employee>()
            {
new Employee() { EmployeeId = 1, FirstName = "John" , LastName = "Abraham",Salary=1000000,JoiningDate="01-JAN-13 12.00.00 AM",Department="Banking" },
new Employee() { EmployeeId = 2, FirstName = "Michael" , LastName = "Clarke",Salary=800000,JoiningDate="01-JAN-13 12.00.00 AM",Department="Insurance" },
new Employee() { EmployeeId = 3, FirstName = "Roy" , LastName = "Thomas",Salary=700000,JoiningDate="01-FEB-13 12.00.00 AM",Department="Banking" },
new Employee() { EmployeeId = 4, FirstName = "Tom" , LastName = "Jose",Salary=600000,JoiningDate="01-FEB-13 12.00.00 AM",Department="Insurance" },
new Employee() { EmployeeId = 5, FirstName = "Jerry" , LastName = "Pinto",Salary=650000,JoiningDate="01-FEB-13 12.00.00 AM",Department="Insurance" },
new Employee() { EmployeeId = 6, FirstName = "Philip" , LastName = "Mathew",Salary=750000,JoiningDate="01-JAN-13 12.00.00 AM",Department="Services" },
new Employee() { EmployeeId = 7, FirstName = "TestName1" , LastName = "123",Salary=650000,JoiningDate="01-JAN-13 12.00.00 AM",Department="Services" },
new Employee() { EmployeeId = 8, FirstName = "TestName2" , LastName = "Lname%",Salary=600000,JoiningDate="01-FEB-13 12.00.00 AM",Department="Insurance" },
    };
            IList<Incentives> incentives = new List<Incentives>()
            {

new Incentives() { EmployeeRefId = 1, IncentiveDate = "01-FEB-13" , IncentiveAmount = 5000 },
new Incentives() { EmployeeRefId = 2, IncentiveDate = "01-FEB-13" , IncentiveAmount = 3000 },
new Incentives() { EmployeeRefId = 3, IncentiveDate = "01-FEB-13" , IncentiveAmount = 4000 },
new Incentives() { EmployeeRefId = 1, IncentiveDate = "01-JAN-13" , IncentiveAmount = 4500 },
new Incentives() { EmployeeRefId = 2, IncentiveDate = "01-JAN-13" , IncentiveAmount = 3500 },
  };

            /* 
             2. Get all employee details from the employee table 
             var Employee = from emp in employee
                            select new { 
                                 emp.EmployeeId,emp.FirstName,emp.LastName, emp.Salary, emp.JoiningDate, emp.Department
                            };

             foreach (var name in Employee)
             {
                 Console.WriteLine(name);
             } 
             */

            /*
            3. Get First_Name, Last_Name from employee table
            var EmployeDetail = employee.Select(s => s.FirstName);
            foreach(var fname in EmployeDetail)
            {
                Console.WriteLine(fname);
            }  
            */
            /*
            4. Get First_Name from employee table using alias name “Employee Name”   
            var Employee = from emp in employee
                           select new
                           {  EmployeeName= emp.FirstName                         
                           };

            foreach (var name in Employee)
            {
                Console.WriteLine(name);
            }
            */
            /*
            5. Get First_Name from employee table in upper case
              var Employee = from emp in employee
                           select new
                           {
                               EmployeeName = emp.FirstName.ToUpper()
                           };

            foreach (var name in Employee)
            {
                Console.WriteLine(name);
            }
            */
            /*
             6.  Get First_Name from employee table in lower case
                var Employee = from emp in employee
                           select new
                           {
                               EmployeeName = emp.FirstName.ToLower()
                           };

            foreach (var name in Employee)
            {
                Console.WriteLine(name);
            }
            */
            /*
             7.  Get unique DEPARTMENT from employee table
                 
            var uniqueDepartment = employee.Select(s => s.Department).Distinct().ToList();
        foreach(var dept in uniqueDepartment)
            {
                Console.WriteLine(dept);
            }
            */
            /*
             8. Select first 3 characters of FIRST_NAME from EMPLOYEE
            var firstName = from fname in employee
                            select new
                            {
                                FirstThreeLetterOfName = fname.FirstName.Substring(0, 3)
                            };
                            foreach(var name in firstName)
            {
                Console.WriteLine(name);
            }
        */
            /*
             9.  Get position of 'o' in name 'John' from employee table
                var firstName = employee.Where(s => s.EmployeeId == 1)
                    .Select(s=>s.FirstName.IndexOf('o'));
                foreach (var name in firstName)
                {
                    Console.WriteLine(name);
                }
                */
            /*
        12.Get length of FIRST_NAME from employee table
        var firstName = employee.Select(s => s.FirstName.Length);
        foreach (var name in firstName)
        {
            Console.WriteLine(name);
        }
        */
        /*
         13. Get First_Name from employee table after replacing 'o' with '$'
            var firstName = employee.Where(s => s.EmployeeId == 1)
                   .Select(s => s.FirstName.Replace('o','$'));
            foreach (var name in firstName)
            {
                Console.WriteLine(name);
            }
            */













        }
    }
}



