using System;
using System.Linq;
using System.Collections.Generic;

namespace Assignment03
{
  public class Queries
  {

    private static IEnumerable<Wizard> GetWizards() {
      return Wizard.Wizards.Value;
    }

    public static IEnumerable<String> extension_getWizardNamesFromRowling() { 
      return GetWizards()
                .Where(w => w.Creator.Contains("Rowling"))
                .Select(w => w.Name);
    }

    public static int extension_getFirstSithLord()
    {
      return GetWizards()
                .Where(w => w.Name.StartsWith("Darth"))
                .Select(w => (int)w.Year)
                .OrderBy(y => y)
                .First();
    }

    public static IEnumerable<(int, String)> extension_getUniqueHPWizards() {
      return GetWizards()
                .Where(w => w.Medium.Equals("Harry Potter"))
                .Select(w => ((int)w.Year, (String)w.Name))
                .GroupBy(w => w.Item2)
                .Select(w => w.First());
    }

    /*public static IEnumerable<(String, IEnumerable<String>)> extension_getGroupedNamesByCreatorInReverseThenWizard()
    {
      return GetWizards()
                .GroupBy(w => w.Creator)
                .Select(g => (g.First().Creator, g.Select(w => w.Name)));
    }*/
/*


    public (int, string) getGroupedNamesByCreatorInReverseThenWizard()
    {

    }*/

  }
}