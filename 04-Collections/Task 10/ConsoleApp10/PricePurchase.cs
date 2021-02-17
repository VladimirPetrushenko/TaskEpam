using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class PricePurchase :Purchase
    {
        private decimal sale;
        public decimal Sale { get => sale; set => sale = value; }
        public PricePurchase():base()
        {
                
        }
        public PricePurchase(string name, int price, int count, decimal sale) 
            :base(name, price, count)
        {
            this.sale = sale;
        }
        public override string ToString()
        {
            return Name + ";" + Price + ";" + Count + ";" + sale;
        }
        public override string ConvertToTable()
        {
            return String.Format("{0, -10} {1, 6} {2, 6} {3, 6:f0} {4,8}", Name, Price, Count, GetCost(), sale);
        }
        public override int GetCost()
        {
            return (Price - (int)Sale) * Count  ;
        }
    }
}
