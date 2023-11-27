using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_InterF_Assign
{
    public class Products : IProducts
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public  DateTime productionTime { get; set; }
        public decimal currentStock = 35;


        public virtual void Receipt()
        {
            Console.WriteLine("Enter the products Names ? ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the products price ? ");
            Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the production date ? ");
            productionTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the quantity for receipt:");
            decimal quantity = decimal.Parse(Console.ReadLine());

            // Perform the receipt operation
            // For simplicity, just increase the current stock by the received quantity
            currentStock += quantity;
            PrintData();
        }

        public virtual void Sale()
        {
            Console.WriteLine("Enter the products sold Names? ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the products price sold? ");
            Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the production date ? ");
            productionTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the quantity for receipt:");
            decimal quantity = decimal.Parse(Console.ReadLine());

            // To realize our sold products we decrease the current stock by the sold quantity
            if (quantity <= currentStock)
            {
                currentStock -= quantity;
                PrintData();

            }
            else
            {
                Console.WriteLine("Not enough stock for sale.");
            }
        }

        public virtual void WriteOff() { }

        public virtual void PrintData()
        {
            Console.WriteLine($"Name of the products: {Name} \nPrice: {Price:c} \nProduction time: {productionTime} \nCurrentStock: {currentStock}");
        }

       
    }
}
