using System.Linq;
using System;
using System.Collections.Generic;
namespace BDSA2020.Assignment02
{
    public class Queries
    {
        public static IEnumerable<string> GetRowlingsWizards()
        {
            return Wizard.Wizards.Value.Where(x => x.Creator == "J.K. Rowling").Select(x => x.Name);
        }

        public static IEnumerable<string> GetRowlingsWizardsLinq()
        {
            return from x in Wizard.Wizards.Value where x.Creator == "J.K. Rowling" select x.Name;
        }

        public static int GetSithYear()
        {
            return Wizard.Wizards.Value.Where(x => x.Name.Contains("Darth")).OrderBy(x => x.Year).Select(x => x.Year).First().Value;
        }

        public static int GetSithYearLinq()
        {
            return (from x in Wizard.Wizards.Value where x.Name.Contains("Darth") orderby x.Year select x.Year).First().Value;
        }

        public static IEnumerable<(string, int?)> GetUniqueHarryWizards()
        {
            return Wizard.Wizards.Value.Where(x => x.Medium.Contains("Harry Potter")).Distinct(new WizardComparer()).Select(x => (x.Name, x.Year));
        }

        public static IEnumerable<(string, int?)> GetUniqueHarryWizardsLinq()
        {
            return (from x in Wizard.Wizards.Value where x.Medium.Contains("Harry Potter") select x).Distinct(new WizardComparer()).Select(x => (x.Name, x.Year));
        }


        public static IEnumerable<string> GetWizardNamesInReverse()
        {
            return Wizard.Wizards.Value.OrderBy(x => x.Name).OrderByDescending(x => x.Creator).Select(x => x.Name);
        }

        public static IEnumerable<string> GetWizardNamesInReverseLinq()
        {
            return from x in Wizard.Wizards.Value orderby x.Name orderby x.Creator descending select x.Name;
        }

    }

    class WizardComparer : IEqualityComparer<Wizard>
    {
        public bool Equals(Wizard w1, Wizard w2)
        {
            if (w2 == null && w1 == null)
                return true;
            else if (w1 == null || w2 == null)
                return false;
            else if (w1.Name == w2.Name)
                return true;
            else
                return false;
        }
        public int GetHashCode(Wizard w)
        {
            return w.Name.GetHashCode();
        }

    }


}
