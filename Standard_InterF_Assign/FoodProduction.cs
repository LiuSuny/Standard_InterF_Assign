using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Standard_InterF_Assign
{
     class FoodProduction : Products, IComparable
    {
        public DateTime expirationDate { get; set; } 

        public override void Receipt()
        {

            base.Receipt();

            Console.WriteLine("Enter the expiration date for the food product:");
            expirationDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine($"Food product receipt successful. Expiration date: {expirationDate}");
        }

        public override void Sale()
        {
            base.PrintData();
        }

        public override void WriteOff()
        {
            Console.WriteLine("Enter the quantity for write-off:");
            decimal quantity = decimal.Parse(Console.ReadLine());

            // Perform the write-off operation
            // For simplicity, just decrease the current stock by the written-off quantity
            if (quantity <= currentStock)
            {
                currentStock -= quantity;
                Console.WriteLine($"******Sale successful****** \nName of the products: {Name} \nPrice: {Price:c} \nProduction time: {productionTime} \n Current stock: {currentStock}");
            }
            else
            {
                Console.WriteLine("Not enough stock for write-off.");
            }
        }

        public override void PrintData()
        {
            base.PrintData();
            Console.WriteLine($"Expiration Date: {expirationDate}");
        }

        public override string ToString()
        {
            return $" {Name, -15} {Price,  -15:c} {productionTime.ToShortDateString(),-15} {currentStock,-15} {expirationDate.ToShortDateString(),-15}";
        }

        public int CompareTo(object obj)
        {
            if (obj is FoodProduction)
            {
                return Price.CompareTo((obj as FoodProduction).Price);
            }
            throw new NotImplementedException();
        }
    }
}
