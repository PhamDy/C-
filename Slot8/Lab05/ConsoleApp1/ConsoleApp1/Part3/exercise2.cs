using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Part3
{
    class AmountException : Exception
    {
        public string PersonName { get; }

        public AmountException(string personName, string message) : base(message)
        {
            PersonName = personName;
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public decimal Bonus { get; set; }
    }

    class Faculty : Employee
    {
        public string Rank { get; set; }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                // Creating instances of different classes
                Employee employee = new Employee { Name = "John Doe", Salary = 50000, Bonus = 12000 };
                Faculty faculty1 = new Faculty { Name = "Dr. Smith", Salary = 59000, Bonus = 5000, Rank = "Senior Lecturer" };
                Faculty faculty2 = new Faculty { Name = "Dr. Johnson", Salary = 65000, Bonus = 8000, Rank = "Professor" };

                // Demonstrate polymorphism
                DisplayInfo(employee);
                DisplayInfo(faculty1);
                DisplayInfo(faculty2);

                // Demonstrate custom exception handling
                CheckSalary(faculty1);
                CheckBonus(faculty2);
            }
            catch (AmountException ex)
            {
                Console.WriteLine($"Error for {ex.PersonName}: {ex.Message}");
            }
        }

        static void DisplayInfo(Employee employee)
        {
            Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary:C}, Bonus: {employee.Bonus:C}");
        }

        static void CheckSalary(Faculty faculty)
        {
            if (faculty.Rank == "Senior Lecturer" && faculty.Salary < 60000)
            {
                throw new AmountException(faculty.Name, "Senior Lecturer's salary cannot be less than $60,000");
            }
        }

        static void CheckBonus(Employee employee)
        {
            if (employee.Bonus > 10000)
            {
                throw new AmountException(employee.Name, "Bonus cannot exceed $10,000");
            }
        }
    }

}
