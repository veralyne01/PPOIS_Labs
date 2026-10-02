using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostMachine
{
    internal class InputValidator
    {
        internal static int ValidateInt()
        {
            if (int.TryParse(Console.ReadLine(), out int input) && input >= 0) return input;
            else throw new FormatException("Invalid data type!\n");
        }
    }
}
