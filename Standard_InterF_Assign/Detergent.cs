using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_InterF_Assign
{
    class Detergent : HouseholdChemical, IEnumerable
    {
        private string cleaningType;

        public string CleaningType
        {
            get { return cleaningType; }
            set { cleaningType = value; }
        }


        HouseholdChemical[] HholdChemical =
       {
            new HouseholdChemical{Name= "Detergent", Price= 659, productionTime = new DateTime(2003,05,08),
                currentStock=100, InstructionOnUse="Used for washing clothes"},

            new HouseholdChemical{Name= "ToothPast", Price= 700, productionTime = new DateTime(2007,10,30),
                currentStock=90, InstructionOnUse="Used for cleaning teeth while brushing"},

            new HouseholdChemical{Name= "Soap", Price= 800, productionTime = new DateTime(2010,11,21),
                currentStock=120, InstructionOnUse="Used for bathing and washing clothes"},

            new HouseholdChemical{Name= "Mouthwash", Price= 753, productionTime = new DateTime(2014,2,17),
                currentStock=100, InstructionOnUse= "Used for personal hygiene."},

            new HouseholdChemical{Name= "Sanitizers.", Price= 987, productionTime = new DateTime(2018,09,27),
                currentStock=100, InstructionOnUse= "Sanitiser is used to kill bacteria and viruses"}
        };

        IEnumerator IEnumerable.GetEnumerator()
        {
            return HholdChemical.GetEnumerator();
        }

        public void Sort()
        { Array.Sort(HholdChemical); }

        public void Sort(IComparer comparer)
        { Array.Sort(HholdChemical, comparer); }
        //public override void Receipt()
        //{
        //    // Call the base class Receipt method to handle common receipt logic
        //    base.Receipt();

        //    Console.WriteLine("Enter the cleaning type of the detergent:");
        //    cleaningType = Console.ReadLine();

        //    Console.WriteLine($"Detergent receipt successful. Cleaning Type: {cleaningType}");
        //}
        //Note we can realize other method like printdata, sales etc using the same method
    }
}
