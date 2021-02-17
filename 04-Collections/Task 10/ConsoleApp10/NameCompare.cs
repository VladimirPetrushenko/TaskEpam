using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class NameCompare : IComparer<Purchase>
    {
        public int Compare(Purchase x, Purchase y)
        {
            if(x.Name == y.Name)
            {
                if (x.GetType() == y.GetType())
                {
                    return x.CompareTo(y);
                }
                if (x.GetType() == typeof(PricePurchase))
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return x.Name.CompareTo(y.Name);
            }
        }
    }
}
