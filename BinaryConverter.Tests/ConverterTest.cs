using FluentAssertions;
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
    }
}