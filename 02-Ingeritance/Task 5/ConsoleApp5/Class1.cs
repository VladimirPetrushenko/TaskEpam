using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Commodity
    {
        private string nameProduct;
        private decimal price;
        public string NameProduct { get => nameProduct; set => nameProduct = value; }
        public decimal Price { get => price; set => price = value; }
        public Commodity() { }
        public Commodity(string nameProduct, decimal price) {
            this.nameProduct = nameProduct;
            this.price = price;
        }
        public override string ToString()
        {
            return nameProduct + ";" + price + ";";
        }
    }
}
