using System;
using System.Linq;
using System.Collections.Generic;

namespace Assignment03
{
    public class Queries
    {
        private static IEnumerable<Wizard> GetWizards()
        {
            return Wizard.Wizards.Value;
        }

        public static IEnumerable<string> getWizardNamesFromRowlingLine()
        {
            return GetWizards()
                            .Where(w => w.Creator.Contains("Rowling"))
                            .Select(w => w.Name);
        }

        public static IEnumerable<string> getWizardNamesFromRowlingQuery()
        {
            var wizards = from w in GetWizards()
                          where w.Creator == "J.K. Rowling"
                          select w.Name;

            return wizards;
        }

        public static int? getFirstSithLordLine()
        {
            return GetWizards()
                      .Where(w => w.Name.StartsWith("Darth "))
                      .Select(w => (int)w.Year)
                      .OrderBy(y => y)
                      .FirstOrDefault();
        }

        public static int? getFirstSithLordQuery()
        {
            var firstSith = (from w in GetWizards()
                             where w.Name.StartsWith("Darth ")
                             orderby w.Year
                             select w.Year).First();
            return firstSith;
        }

        public static IEnumerable<(string, int?)> getUniqueHPWizardsLine()
        {
            return GetWizards()
                .Where(w => w.Medium.Equals("Harry Potter"))
                .Select(w => ((String)w.Name, (int?)w.Year))
                .GroupBy(w => w.Item2)
                .Select(w => w.First());
        }

        public static IEnumerable<(string, int?)> getUniqueHPWizardsQuery()
        {
            var UniqueHPWizards = from w in GetWizards()
                                  where w.Medium.Equals("Harry Potter")
                                  select (w.Name, w.Year);

            return UniqueHPWizards.Distinct();
        }

        public static IEnumerable<string> getWizardNamesByCreatorInReverseThenWizardLine()
        {
            return GetWizards()
                      .OrderByDescending(w => w.Creator).ThenBy(w => w.Name)
                      .Select(w => w.Name);
        }

        public static IEnumerable<string> getGroupedNamesByCreatorInReverseThenWizardQuery()
        {
            var GroupedWizards = from w in GetWizards()
                                 orderby w.Creator descending, w.Name
                                 select w.Name;
            return GroupedWizards;
        }

    }
}