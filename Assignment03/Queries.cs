using System;
using System.Linq;
using System.Collections.Generic;

namespace Assignment03
{
  public class Queries
  {

    public IEnumerable<Wizard> getWizardNamesFromRowling() {
      return Wizard.Wizards.Value.Where(w => w.Creator == "Rowling");
    }
/*
    public int getFirstSithLord() {

    }

    public (int, string) getUniqueHPWizards() {
      
    }

    public (int, string) getGroupedNamesByCreatorInReverseThenWizard()
    {

    }*/

  }
}