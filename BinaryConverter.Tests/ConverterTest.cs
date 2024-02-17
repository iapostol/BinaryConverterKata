using Xunit;
using FluentAssertions;
using System.Collections.Generic;
using System;
using System.IO;

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
        public void DecimalToBinary(int number, string binary)
        {
            Converter.BinaryFor(number).Should().Be(binary);
        }

        [Theory]
        [InlineData("0", 0)]
        [InlineData("1", 1)]
        [InlineData("10", 2)]
        [InlineData("11", 3)]
        [InlineData("100", 4)]
        [InlineData("101", 5)]
        [InlineData("10101110", 174)]
        [InlineData("11110111101", 1981)]
        public void BinaryToDecimal(string binary, int number)
        {
            Converter.DecimalFor(binary).Should().Be(number);
        }
    }
}