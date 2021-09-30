using System;
using Xunit;
using System.Collections.Generic;

namespace Assignment03.Tests
{
  public class QueriesTests
  {
    [Fact]
    public void Returns_Character_Names_From_Rowling()
    {
      // Arrange
      IEnumerable<string> expected = new List<string> {
        "Harry Potter", "Snape", "Hagrid"
      };

      // Act
      IEnumerable<string> actual = Queries.extension_getWizardNamesFromRowling();

      // Assert
      Assert.Equal(expected, actual);
    
    }

    [Fact]
    public void Finds_First_Sith_Lord()
    {
      // Arrange
      int expected = 1977;

      // Act
      int actual = Queries.extension_getFirstSithLord();

      // Assert
      Assert.Equal(expected, actual);

    }

    [Fact]
    public void Should_Return_HP_Touple()
    {
      // Arrange
      IEnumerable<(int, string)> expected = new List<(int, string)> {
        (1652, "Harry Potter"),
        (1888, "Snape"),
        (2232, "Hagrid")
      };

      // Act
      IEnumerable<(int, string)> actual = Queries.extension_getUniqueHPWizards();

      // Assert
      Assert.Equal(expected, actual);

    }

    /**

      "Darth Vader","Star Wars",1977,"George Lucas"
      "Sauron","The Fellowship of the Ring",1954,"J.R.R. Tolkien"
      "Harry Potter","Harry Potter",1652,"J.K. Rowling"
      "Snape","Harry Potter",1888,"J.K. Rowling"
      "Hagrid","Harry Potter",2232,"J.K. Rowling"
      "Darth Maul","Star Wars",1982,"George Lucas"


      "J.R.R. Tolkien" - "Sauron"
      "J.K. Rowling" - "Snape"
      "J.K. Rowling" - "Harry Potter"
      "J.K. Rowling" - "Hagrid"
      "George Lucas" - "Darth Vader"
      "George Lucas" - "Darth Maul"
    */

    /*[Fact]
    public void Should_Return_Correct_Answer()
    {
      // Arrange
      IEnumerable<(String, IEnumerable<String>)> expected = new List<(String, IEnumerable<String>)> {
        ("J.R.R. Tolkien", new List<String> {
          "Sauron"
        }),

        ("J.K. Rowling", new List<String> {
          "Snape",
          "Harry Potter",
          "Hagrid"
        }),

        ("George Lucas", new List<String> {
          "Darth Vader",
          "Darth Maul"
        }),
      };

      // Act
      IEnumerable<(String, IEnumerable<String>)> actual = Queries.extension_getGroupedNamesByCreatorInReverseThenWizard();
       

      // Assert
      Assert.Equal(expected, actual);

    }*/
  }
}