using System;

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
    }
}