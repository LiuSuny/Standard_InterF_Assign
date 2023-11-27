using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_InterF_Assign
{
    class Vegetable :FoodProduction
    {
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public override void Receipt()
        {
            // Call the base class Receipt method to handle common receipt logic
            base.Receipt();

            Console.WriteLine("Enter the type of the vegetable:");
            type = Console.ReadLine();

            Console.WriteLine($"Vegetable receipt successful. Type: {type}");
        }

    }
}
