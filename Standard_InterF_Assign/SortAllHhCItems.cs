using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Standard_InterF_Assign
{
    internal class SortAllHhCItems : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is HouseholdChemical && y is HouseholdChemical)
            {
             
                    return ((HouseholdChemical)x).InstructionOnUse.CompareTo(((HouseholdChemical)y).InstructionOnUse);
              
            }
                throw new NotImplementedException();
        }
    }
}
