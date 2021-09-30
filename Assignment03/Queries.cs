using System;
using System.Linq;
using System.Collections.Generic;

namespace Assignment03
{
    public class Queries
    {
        public static IEnumerable<string> getWizardNamesFromRowling(IEnumerable<Wizard> input)
        {
            var wizards = from w in input
                          where w.Creator == "J.K. Rowling"
                          select w.Name;
            return wizards;
        }

        public static int? getFirstSithLord(IEnumerable<Wizard> input)
        {
            var firstSith = (from w in input
                             where w.Name.StartsWith("Darth ")
                             orderby w.Year
                             select w.Year).First();
            return firstSith;
        }

        public static IEnumerable<(string, int?)> getUniqueHPWizards(IEnumerable<Wizard> input)
        {
            var UniqueHPWizards = from w in input
                                  where w.Medium.Equals("Harry Potter")
                                  select (w.Name, w.Year);

            return UniqueHPWizards.Distinct();
        }

        public static IEnumerable<string> getWizardNamesByCreatorInReverseThenWizard(IEnumerable<Wizard> input)
        {
            var GroupedWizards = (from w in input
                                 orderby w.Creator descending, w.Name
                                 select w.Name).Distinct();
            return GroupedWizards;
        }

    }
}