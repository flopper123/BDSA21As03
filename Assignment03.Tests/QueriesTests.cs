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
            IEnumerable<string> QueryActual = Queries.getWizardNamesFromRowling(WizardDB);

            // Assert
            Assert.Equal(expected, WizardDB.getWizardNamesFromRowling());
            Assert.Equal(expected, QueryActual);
        }

        [Fact]
        public void Finds_First_Sith_Lord()
        {
            // Arrange
            int expected = 1977;

            // Act
            var QueryActual = Queries.getFirstSithLord(WizardDB);

            // Assert
            Assert.Equal(expected, WizardDB.getFirstSithLord());
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
            IEnumerable<(string, int?)> QueryActual = Queries.getUniqueHPWizards(WizardDB);

            // Assert
            Assert.Equal(expected, WizardDB.getUniqueHPWizards());
            Assert.Equal(expected, QueryActual);

        }
        
        [Fact]
        public void return_List_Sorted_By_Author_then_Name()
        {
            var expected = new List<string>
            {
              "Eggplant Wizard", "Baron Mordo", "Wizard of Oz", "Sauron", "Hagrid", "Harry Potter", "Snape", "Darth Maul", "Darth Vadar", "Ice King"
            };

            foreach (var item in expected)
            {
              Console.WriteLine(item);
            }

            IEnumerable<string> QueryActual = Queries.getWizardNamesByCreatorInReverseThenWizard(WizardDB);

            Assert.NotStrictEqual(expected, QueryActual);
            Assert.NotStrictEqual(expected, WizardDB.getWizardNamesByCreatorInReverseThenWizard());
        }
    }
}