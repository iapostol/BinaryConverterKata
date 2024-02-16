using Xunit;
using FluentAssertions;

namespace BinaryConverter.Tests
{
    public class ConverterTest
    {
        [Theory]
        [InlineData(0, "0")]
        [InlineData(1, "1")]
        [InlineData(2, "10")]
        [InlineData(3, "11")]
        [InlineData(4, "100")]
        [InlineData(5, "101")]
        [InlineData(174, "10101110")]
        [InlineData(1981, "11110111101")]
        public void FromDecimalToBinary(int number, string binary)
        {
            Converter.BinaryFor(number).Should().Be(binary);
        }
    }
}