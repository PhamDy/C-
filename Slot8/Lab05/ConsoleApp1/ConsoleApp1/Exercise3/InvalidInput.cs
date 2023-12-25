using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exercise3
{
    internal class InvalidInput : ApplicationException
    {
        public InvalidInput()
  : base("Enter a number greater than Zero") { }

    }
}
