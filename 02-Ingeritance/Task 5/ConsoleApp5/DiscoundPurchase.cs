using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class DiscoundPurchase : AbstractPurchase
    {
        private decimal discount;
        public decimal Discount { get => discount; set => discount = value; }
        public DiscoundPurchase():base() { }
        public DiscoundPurchase(Commodity product, int countProduct, decimal discount)
            : base(product, countProduct)
        {
            this.discount = discount;
        }
        public override decimal GetCost()
        {
            return (this.Product.Price - this.discount) * this.CountProduct;
        }
    }
}
