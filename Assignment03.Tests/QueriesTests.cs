using System;
using Xunit;
using System.Collections.Generic;

namespace Assignment03.Tests
{

    public class QueriesTests
    {
        static IEnumerable<Wizard> WizardDB = Wizard.Wizards.Value;

        [Fact]
        public void Returns_Character_Names_From_Rowling()
        {
            // Arrange
            IEnumerable<string> expected = new List<string>
              {
                "Harry Potter", "Snape", "Hagrid"
              };

            // Act
            IEnumerable<string> LineActual = WizardDB.getWizardNamesFromRowling();
            IEnumerable<string> QueryActual = Queries.getWizardNamesFromRowling(WizardDB);
            // Assert
            Assert.Equal(expected, LineActual);
            Assert.Equal(expected, QueryActual);
        }

        [Fact]
        public void Finds_First_Sith_Lord()
        {
            // Arrange
            int expected = 1977;

            // Act
            var LineActual = WizardDB.getFirstSithLord();
            var QueryActual = Queries.getFirstSithLord(WizardDB);
            // Assert
            Assert.Equal(expected, LineActual);
            Assert.Equal(expected, QueryActual);
        }

        [Fact]
        public void Should_Return_HP_Touple()
        {
            // Arrange
            var expected = new List<(string, int?)>
              {
                ("Harry Potter", 1652),
                ("Snape", 1888),
                ("Hagrid", 2232)
              };

            // Act
            IEnumerable<(string, int?)> LineActual = WizardDB.getUniqueHPWizards();
            IEnumerable<(string, int?)> QueryActual = Queries.getUniqueHPWizards(WizardDB);
            // Assert
            Assert.Equal(expected, LineActual);
            Assert.Equal(expected, QueryActual);

        }

        [Fact]
        public void Should_Return_Correct_Answer()
        {


        }
    }
}