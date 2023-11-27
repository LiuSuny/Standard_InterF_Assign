using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_InterF_Assign
{
    public class SortAllFoodPItems : IComparer
    {
        public int Compare(object x, object y)
        {
            int prod = ((FoodProduction)x).Price.CompareTo(((FoodProduction)y).Price);
            if (prod != 0)
            {
                return ((FoodProduction)x).Name.CompareTo(((FoodProduction)y).Name);
            }
            else return prod;

            throw new NotImplementedException();
        }
    }
}
