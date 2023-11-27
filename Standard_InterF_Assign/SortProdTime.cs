using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_InterF_Assign
{
    class SortProdTime : IComparer
    {
        public int Compare(object x, object y)
        {

            if (x is FoodProduction && y is FoodProduction)
            {
                return DateTime.Compare((x as FoodProduction).productionTime, (y as FoodProduction).productionTime);
            }
            throw new NotImplementedException();
        }
    }
}
