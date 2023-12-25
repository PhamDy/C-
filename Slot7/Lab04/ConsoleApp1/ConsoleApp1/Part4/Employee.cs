using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Part4
{
    abstract class Employee : Person
    {
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public DateTime DateHired { get; set; }

        public Employee(string name, string phoneNumber, string email, string department, decimal salary, DateTime dateHired)
            : base(name, phoneNumber, email)
        {
            Department = department;
            Salary = salary;
            DateHired = dateHired;
        }

        public abstract decimal CalculateBonus();
        public abstract int CalculateVacation();
    }
}
