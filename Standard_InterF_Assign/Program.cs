//#define USER_INPUT_INTERFACE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_InterF_Assign
{
    class Program
    {
        public static readonly string delimeter = "\n_______________________________________________________\n";
        static void Main(string[] args)
        {

            Friuts friut = new Friuts();
            foreach (FoodProduction item in friut)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***********After Sorting Price of Goods********************\n");

            friut.Sort();
            foreach (FoodProduction item in friut)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***********After Sorting Goods name and price********************\n");
            friut.Sort(new SortAllFoodPItems());
            foreach (FoodProduction item in friut)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***********After Sorting Goods by production time ********************\n");
            friut.Sort(new SortProdTime());
            foreach (FoodProduction item in friut)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"{delimeter} Below HouseHoldChemical { delimeter}");

            Detergent detergent = new Detergent();
            foreach (HouseholdChemical j in detergent)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("***********After Sorting Name of Goods HouseHC********************\n");
            detergent.Sort();
            foreach (HouseholdChemical j in detergent)
            {
                Console.WriteLine(j);
            }

            Console.WriteLine("***********After Sorting Goods by name and price (********************\n");
            detergent.Sort(new SortAllHhCItems());
            foreach (HouseholdChemical j in detergent)
            {
                Console.WriteLine(j);
            }

            Console.WriteLine(delimeter);



#if USER_INPUT_INTERFACE
            IProducts goods;

            while (true)
            {
                Console.WriteLine("Select the type of goods:");
                Console.WriteLine("1. Food Product");
                Console.WriteLine("2. Household Chemical");
                Console.WriteLine("3. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        goods = new FoodProduction();
                        productDataPerformance(goods);
                        break;
                    case 2:
                        goods = new HouseholdChemical();
                        productDataPerformance(goods);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } 
#endif
        }
#if USER_INPUT_INTERFACE
        static void productDataPerformance(IProducts goods)
        {
            while (true)
            {
                Console.WriteLine("Select operation:");
                Console.WriteLine("1. Receipt");
                Console.WriteLine("2. Sale");
                Console.WriteLine("3. Write-off");
                Console.WriteLine("4. Print Data");
                Console.WriteLine("5. Back to main menu");

                int operationChoice = int.Parse(Console.ReadLine());

                switch (operationChoice)
                {
                    case 1:
                        goods.Receipt();
                        break;
                    case 2:
                        goods.Sale();
                        break;
                    case 3:
                        goods.WriteOff();
                        break;
                    case 4:
                        goods.PrintData();
                        break;
                    case 5:
                        return; // Exit the loop and go back to the main menu
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

#endif
    }
}
