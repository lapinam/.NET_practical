using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PersonTask2
{
    class NameValidation
    {
        public static string Valid(string value)
        {
            while (true)
            {
                if (Regex.Match(value, @"^[a-zA-Z]{1,}").Success)
                    return value;
                else
                    Console.WriteLine("Input is not valid");
            }
        }
    }
}
