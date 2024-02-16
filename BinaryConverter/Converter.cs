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

    private static string Reverse(string str)
    {
        var charArray = str.ToCharArray();

        Array.Reverse(charArray);

        return new string(charArray);
    }
}
