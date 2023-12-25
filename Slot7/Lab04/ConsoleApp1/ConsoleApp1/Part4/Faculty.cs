using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Part4
{
    internal class Faculty : Employee
    {
        public string Rank { get; set; }
        public string OfficeHours { get; set; }

        public Faculty(string name, string phoneNumber, string email, string department, decimal salary, DateTime dateHired, string rank, string officeHours)
            : base(name, phoneNumber, email, department, salary, dateHired)
        {
            Rank = rank;
            OfficeHours = officeHours;
        }

        public override decimal CalculateBonus()
        {
            return 1000 + 0.05m * Salary;
        }

        public override int CalculateVacation()
        {
            int baseVacation = 4;

            if ((DateTime.Now - DateHired).TotalDays > 3 * 365)
            {
                baseVacation = 5;

                if (Rank == "Senior Lecturer")
                {
                    baseVacation++;
                }
            }

            return baseVacation;
        }
    }
}
