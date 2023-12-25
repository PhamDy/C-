using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Part4
{
    internal class Student : Person
    {
        public string Program { get; set; }

        public Student(string name, string phoneNumber, string email, string program)
            : base(name, phoneNumber, email)
        {
            Program = program;
        }
    }
}
