using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_InterF_Assign
{
    class Friuts : FoodProduction, IEnumerable
    {
        private string variety;


        public string Variety
        {
            get { return variety; }
            set { variety = value; }
        }

        FoodProduction[] Fproduction =
        {
            new FoodProduction{Name= "Bread", Price= 659, productionTime = new DateTime(2003,05,08),
                currentStock=100, expirationDate= new DateTime(2006, 04, 25)},

            new FoodProduction{Name= "Meat", Price= 700, productionTime = new DateTime(2007,10,30),
                currentStock=90, expirationDate= new DateTime(2009, 09, 20)},

            new FoodProduction{Name= "Vegetable", Price= 800, productionTime = new DateTime(2010,11,21),
                currentStock=120, expirationDate= new DateTime(2013, 08, 10)},

             new FoodProduction{Name= "Yogurt", Price= 987, productionTime = new DateTime(2018,09,27),
                currentStock=100, expirationDate= new DateTime(2024, 04, 29)},

            new FoodProduction{Name= "Apple", Price= 753, productionTime = new DateTime(2014,2,17),
                currentStock=100, expirationDate= new DateTime(2016, 03, 19)}
        };
        public override void Receipt()
        {
            // Call the base class Receipt method to handle common receipt logic
            base.Receipt();

            Console.WriteLine("Enter the variety of the fruit:");
            variety = Console.ReadLine();

            Console.WriteLine($"Fruit receipt successful. Variety: {variety}");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Fproduction.GetEnumerator();
        }

        public void Sort()
        { Array.Sort(Fproduction); }

        public void Sort(IComparer comparer)
        { Array.Sort(Fproduction, comparer); }
    }
}
