using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Part4
{
    internal class Program
    {
        static void Main()
        {
            Student student = new Student("John Doe", "123-456-7890", "john@example.com", "Computer Science");
            Console.WriteLine(student);

            Faculty faculty = new Faculty("Dr. Smith", "987-654-3210", "smith@example.com", "Computer Science", 80000, new DateTime(2010, 1, 1), "Professor", "Monday 2-4 PM");
            Console.WriteLine(faculty);

            Staff staff = new Staff("Jane Johnson", "555-555-5555", "jane@example.com", "Human Resources", 60000, new DateTime(2015, 1, 1), "HR Specialist");
            Console.WriteLine(staff);

            Console.WriteLine($"Faculty Bonus: {faculty.CalculateBonus()}");
            Console.WriteLine($"Faculty Vacation: {faculty.CalculateVacation()} weeks");

            Console.WriteLine($"Staff Bonus: {staff.CalculateBonus()}");
            Console.WriteLine($"Staff Vacation: {staff.CalculateVacation()} weeks");
        }
    }
}
