using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class FixDiscountPurchase:AbstractPurchase
    {
        private decimal discount;
        private const int countProductFix = 5;
        public decimal Discount { get => discount; set => discount = value; }
        public FixDiscountPurchase() : base() { }
        public FixDiscountPurchase(Commodity product, int countProduct, decimal discount)
            : base(product, countProduct)
        {
            this.discount = discount;
        }
        public override decimal GetCost()
        {
            if (this.CountProduct > countProductFix)
                return this.Product.Price * this.CountProduct * (1 - discount / 100);
            else
                return this.Product.Price * this.CountProduct;
        }
    }
}
