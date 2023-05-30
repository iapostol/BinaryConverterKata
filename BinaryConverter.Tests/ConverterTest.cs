using FluentAssertions;
using FluentAssertions.Formatting;
using Xunit;
using static BinaryConverter.Converter;

namespace BinaryConverter.Tests
{
    public class ConverterTest
    {
        [Theory]
        [InlineData(0,"0")]
        [InlineData(1,"1")]
        [InlineData(2,"10")]
        [InlineData(3,"11")]
        [InlineData(4,"100")]
        [InlineData(5980,"1011101011100")]
        public void Convert_Decimal_ToBinary(int number, string binary)
        {
            BinaryFor(number).Should().Be(binary);
        }

        [Theory]
        [InlineData("0", 0)]
        [InlineData("1", 1)]
        [InlineData("10", 2)]
        [InlineData("11", 3)]
        [InlineData("100", 4)]
        [InlineData("101", 5)]
        [InlineData("1011101011100", 5980)]
        public void Convert_Binary_ToDecimal(string binary, int number)
        {
            DecimalFor(binary).Should().Be(number);
        }
    }
}