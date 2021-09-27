using System;
using Xunit;
using System.Linq;

namespace Assignment03.Tests
{
  public class DelegatesTests
  {

    [Theory]
    [InlineData(new object[] { "abc", "cba" })]
    [InlineData(new object[] { "Hello World!", "!dlroW olleH" })]
    [InlineData(new object[] { "Skrrrt", "trrrkS" })]
    public void ReturnsReversedString(string input, string exp)
    {
      // Arranage
      string expected = exp;

      Func<string, string> stringOperation;
      stringOperation = str => str.ToArray().Reverse().Aggregate("", (acc, c) => acc + c);

      // Act
      string actual = stringOperation(input);

      // Assert
      Assert.Equal(expected, actual);

    }

    [Theory]
    [InlineData(new object[] { 5, 5, 25 })]
    [InlineData(new object[] { 1.5, 4, 6 })]
    [InlineData(new object[] { -1, 100, -100 })]
    public void ReturnsCorrectProduct(decimal x, decimal y, decimal exp)
    {
      // Arranage
      decimal expected = exp;

      Func<decimal, decimal, decimal> decimalOperation;
      decimalOperation = (a, b) => a * b;

      // Act
      decimal actual = decimalOperation(x, y);

      // Assert
      Assert.Equal(expected, actual);

    }



    [Theory]
    [InlineData(new object[] { " 0042", 0042 })]
    [InlineData(new object[] { "1142", 1142 })]
    [InlineData(new object[] { "11 42", 1142 })]
    [InlineData(new object[] { "  000 A 001", 1 })]
    [InlineData(new object[] { "23 b 456", 23456 })]
    public void StringShouldMatchNumber(string input, int exp)
    {
      // Arranage
      int expected = exp;

      Func<string, int> stringOperation;
      stringOperation =
        str => str
          .ToArray()
          .Aggregate(0,
            (acc, c) => {
              int n = c - '0';
              if (n > 9 || n < 0) return acc;
              return 10*acc + n;
            }
          );

      // Act
      int actual = stringOperation(input);

      // Assert
      Assert.Equal(expected, actual);

    }


  }
}