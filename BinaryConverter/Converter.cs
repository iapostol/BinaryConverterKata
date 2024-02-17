namespace BinaryConverter;

public static class Converter
{
    public static string BinaryFor(int number)
    {
        if (number == 0)
            return "0";

        var binary = "";

        for (; number > 0; number /= 2)
            binary += (number % 2).ToString();

        return Reverse(binary);
    }

    public static int DecimalFor(string binary)
    {
        if (string.IsNullOrEmpty(binary))
            throw new ArgumentNullException("binary is empty");

        if (binary.Length == 1)
            return int.Parse(binary);

        var number = 0;

        var length = binary.Length;

        for (int i = 0, power = length - 1; i < length; i++, power--)
            number += int.Parse(binary[i].ToString()) * (int)Math.Pow(2, power);

        return number;
    }

    private static string Reverse(string str)
    {
        var charArray = str.ToCharArray();

        Array.Reverse(charArray);

        return new string(charArray);
    }
}
