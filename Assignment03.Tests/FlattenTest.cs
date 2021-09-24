using System;
using Xunit;
using System.Collections.Generic;

namespace Assignment03.Tests
{
  public class FlattenTest
  {
    [Theory]
    [MemberData(nameof(ValidInput))]
    public void FlattensCorrectlyOnValidInput(List<int>[] test, List<int> exp)
    {
      // Arrange
      int[] expected = new int[exp.Count];
      for (int i = 0; i < exp.Count; i++) {
        expected[i] = exp[i];
      }

      IEnumerable<int>[] input = (IEnumerable<int>[])test;

      // Act
      int[] actual = input.Flatten();

      // Assert
      Assert.Equal(expected, actual);
    }

    public static IEnumerable<object[]> ValidInput =>
    new List<object[]>
    {
      new object[] {
        new List<int>[] { // Input
          new List<int> { 2, 5, 7 },
          new List<int> { 3, 4, 1}
        },
        new List<int> { // Expected
          2, 5, 7, 3, 4, 1
        }
      },
      new object[] {
        new List<int>[] { // Input
          new List<int> { 6, 5, 4, 3 },
          new List<int> { 2, 1 }
        },
        new List<int> { // Expected
          6, 5, 4, 3, 2, 1
        }
      },
      new object[] {
        new List<int>[] { // Input
          new List<int> { 2, 4, 6 },
          new List<int> {8, 10 , 12},
          new List<int> { 14, 16, 18 }
        },
        new List<int> { // Expected
          2, 4, 6, 8, 10, 12, 14, 16, 18
        }
      },
      new object[] {
        new List<int>[] { // Input
          new List<int> { 7, 14, 21 },
          new List<int> { 28, 35, 42 },
          new List<int> { 49, 56, 63 }
        },
        new List<int> { // Expected
          7, 14, 21, 28, 35, 42, 49, 56, 63
        }
      }
    };
  }
}
