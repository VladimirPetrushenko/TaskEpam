using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Purchase[] purchase = { new Purchase("сыр", 300, 3),
                                    new Purchase("сыр", 300, 5),
                                    new FixDiscountPurchase ("сыр", 300, 1, 50),
                                    new FixDiscountPurchase ("сыр", 300, 2, 30 ),
                                    new VariavleDiscountPurchase("сыр", 300, 20, 25),
                                    new VariavleDiscountPurchase("сыр", 300, 17, 30)
            };
            ////2
            //int count=0;
            //foreach (var item in purchase) {
            //    Console.WriteLine(item);
            //    if (count % 2 == 1) {
            //        Console.WriteLine();
            //    }
            //    count++;
            //}   
            //Console.WriteLine();
            ////3
            //Purchase maxCost = purchase[0];
            //foreach (var item in purchase)
            //{
            //    if (maxCost.GetCost() < item.GetCost())
            //        maxCost = item;
            //}
            //Console.WriteLine(maxCost);
            //Console.WriteLine();
            ////4
            int esqCount = 0;
            //Purchase Esq = purchase[0];
            //foreach (var item in purchase)
            //{
            //    if (item.Equals(Esq)) 
            //        esqCount++;
            //    Esq = item;
            //}
            //if (esqCount == 6) {
            //    Console.WriteLine("Все покупки равны\n");
            //}
            //else {
            //    Console.WriteLine("Покупки не равны\n");
            //}
            //Console.WriteLine(esqCount);
            //5
            Purchase maxCost1 = purchase[0];
            esqCount = 0;
            Purchase Esq1 = purchase[0];
            foreach (var item in purchase)
            {
                Console.WriteLine(item);
                if (maxCost1.GetCost() < item.GetCost())
                    maxCost1 = item;
                if (item.Equals(Esq1))
                    esqCount++;
                Esq1 = item;
            }
            Console.WriteLine(maxCost1);
            Console.WriteLine();
            if (esqCount == 6)
            {
                Console.WriteLine("Все покупки равны\n");
            }
            else
            {
                Console.WriteLine("Покупки не равны\n");
            }
        }
    }
    class Purchase
    {
        private string nameProduct;
        private int price;
        private int count;
        public string NameProduct {
            get { return nameProduct; } set { nameProduct = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public Purchase() { 
        
        }
        public Purchase(string nameProduct, int price, int count) {
            this.nameProduct = nameProduct;
            this.price = price;
            this.count = count;
        }
        virtual public int GetCost() {
            return price * count;
        }
        public override string ToString()
        {
            return nameProduct + ";" + price + ";" + count + ";" + GetCost() + ";";
        }
        public bool Equals(Purchase obj)
        {
            if (this.nameProduct == obj.nameProduct && this.price == obj.price)
                return true;
            else
                return false;
        }
    }

    class FixDiscountPurchase : Purchase
    {
        public int Discount { get; set; }
        public FixDiscountPurchase() : base() { 
        
        }
        public FixDiscountPurchase(string nameProduct, int price, int count, int discount) : base (nameProduct, price, count)
        {
            Discount = discount;
        }
        public override int GetCost()
        {
            return (Price - Discount) * Count; ;
        }
        public override string ToString()
        {
            return NameProduct + ";" + Price + ";" + Count + ";" + Discount + ";" + GetCost() + ";";
        }
    }
    class VariavleDiscountPurchase : Purchase
    {
        public double Discount { get; set; }
        public const int FixCount = 18;
        public VariavleDiscountPurchase() : base()
        {

        }
        public VariavleDiscountPurchase(string nameProduct, int price, int count, double discount) : base(nameProduct, price, count)
        {
            Discount = discount;
        }
        public override int GetCost()
        {
            if (Count > FixCount)
            {
                double result = Price * Count * (1 - Discount / 100);
                return (int)result;
            }
            else
            {
                return base.GetCost();
            }
        }
        public override string ToString()
        {
            return NameProduct + ";" + Price + ";" + Count + ";" + Discount + ";" + GetCost() + ";";
        }
    }
}
