using ConsoleApp10.EmployeeManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{

    internal class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public SecurityLevel SecurityLevel { get; set; }
            public decimal Salary { get; set; }
            public HireDate HireDate { get; set; }
            public char Gender { get; set; }

            public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, HireDate hireDate, char gender)
            {
                Id = id;
                Name = name;
                SecurityLevel = securityLevel;
                Salary = salary;
                HireDate = hireDate;
                Gender = gender;
            }

            public override string ToString()
            {
                return $"ID: {Id}, Name: {Name}, Security Level: {SecurityLevel}, Salary: {Salary:C}, Hire Date: {HireDate}, Gender: {Gender}";
            }
        }
}
