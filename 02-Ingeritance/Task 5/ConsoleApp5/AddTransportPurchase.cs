using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class AddTransportPurchase : AbstractPurchase
    {
        private decimal transportRash;
        public decimal TransportRash { get => transportRash; set => transportRash = value; }
        public AddTransportPurchase() : base() { }
        public AddTransportPurchase(Commodity product, int countProduct, decimal transportRash)
            : base(product, countProduct)
        {
            this.transportRash = transportRash;
        }
        public override decimal GetCost()
        {
            return transportRash + this.Product.Price * this.CountProduct;
        }
    }
}
