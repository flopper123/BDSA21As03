using System;
using Xunit;
using System.Collections.Generic;

namespace Assignment03.Tests
{
  public class LeapYearsTest
  {
    [Theory]
    [InlineData(new object[] {new int[] {1844, 1888, 420, 2000, 2002, 2003}, new int[]{1844, 1888, 2000}})] // chaos
    [InlineData(new object[] {new int[] {1200, 4, 400, 800, 404, 808, 1582}, new int[]{}})]                 // Leap year is less than 1582
    [InlineData(new object[] {new int[] {}, new int[]{}})]                                                  // emptyy list
    public void FindLeapYearsTests(params object[] data)
    {
      // Arrange
      IEnumerable<int> input = (IEnumerable<int>)data[0];

      IEnumerable<int> expected = (IEnumerable<int>) data[1];

      // Act
      IEnumerable<int> actual = input.LeapYears();

      // Assert
      Assert.Equal(expected, actual);
    }


  }
}