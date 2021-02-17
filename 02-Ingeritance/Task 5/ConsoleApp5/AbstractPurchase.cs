using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    abstract class AbstractPurchase : IComparable<AbstractPurchase>
    {
        private Commodity product;
        private int countProduct;
        public Commodity Product { get => product; set => product = value; }
        public int CountProduct { get => countProduct; set => countProduct = value; }
        public AbstractPurchase() { }
        public AbstractPurchase(Commodity product, int countProduct) {
            this.product = product;
            this.countProduct = countProduct;
        }
        public abstract decimal GetCost();
        public override string ToString()
        {
            return product.ToString() + countProduct + ";" + GetCost() + ";"; 
        }
        
        int IComparable<AbstractPurchase>.CompareTo(AbstractPurchase other)
        {
            if (this.GetCost() > other.GetCost())
            {
                return -1;
            }
            if (this.GetCost() < other.GetCost())
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
