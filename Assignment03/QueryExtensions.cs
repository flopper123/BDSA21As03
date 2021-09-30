using System;
using System.Linq;
using System.Collections.Generic;

namespace Assignment03
{
    public static class QueryExtensions
    {
        public static IEnumerable<string> getWizardNamesFromRowling(this IEnumerable<Wizard> wizards)
        {
            return wizards
                .Where(w => w.Creator.Contains("Rowling"))
                .Select(w => w.Name);
        }

        public static int? getFirstSithLord(this IEnumerable<Wizard> wizards)
        {
            return wizards
                .Where(w => w.Name.StartsWith("Darth "))
                .Select(w => (int)w.Year)
                .OrderBy(y => y)
                .FirstOrDefault();
        }
        public static IEnumerable<(string, int?)> getUniqueHPWizards(this IEnumerable<Wizard> wizards)
        {
            return wizards
                .Where(w => w.Medium.Equals("Harry Potter"))
                .Select(w => ((String)w.Name, (int?)w.Year))
                .GroupBy(w => w.Item2)
                .Select(w => w.First());
        }

        public static IEnumerable<string> getWizardNamesByCreatorInReverseThenWizard(this IEnumerable<Wizard> wizards)
        {
            return wizards
                .OrderByDescending(w => w.Creator).ThenBy(w => w.Name)
                .Select(w => w.Name);
        }
    }
}