using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Part4
{
    internal class Staff : Employee
    {
        public string Title { get; set; }

        public Staff(string name, string phoneNumber, string email, string department, decimal salary, DateTime dateHired, string title)
            : base(name, phoneNumber, email, department, salary, dateHired)
        {
            Title = title;
        }

        public override decimal CalculateBonus()
        {
            return 0.06m * Salary;
        }

        public override int CalculateVacation()
        {
            return (DateTime.Now - DateHired).TotalDays > 5 * 365 ? 4 : 3;
        }
    }
}
