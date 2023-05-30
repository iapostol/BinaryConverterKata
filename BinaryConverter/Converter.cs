using System;
using System.Linq;

namespace BinaryConverter
{
    public static class Converter
    {
        public static string BinaryFor(int number)
        {
            if (number == 0)
                return "0";

            var binary = string.Empty;
            
            for (;number > 0;number /= 2)
                binary = (number % 2) + binary;

            return binary;
        }
        
        public static int DecimalFor(string binary)
        {
            if (binary.Length == 0)
                return int.Parse(binary);

            var index = binary.Length-1;

            return Convert.ToInt32(binary.Select(ch => ch - '0')
                .ToArray().Sum(digit => digit * Math.Pow(2, index--)));
        }
    }
}