using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            AbstractPurchase[] purchases = { new DiscoundPurchase(new Commodity("сыр",9),9,3),
                                            new DiscoundPurchase(new Commodity("сыр",9),12,3),
                                            new FixDiscountPurchase(new Commodity("сыр",10),20,20),
                                            new FixDiscountPurchase(new Commodity("сыр",10),2,20),
                                            new AddTransportPurchase(new Commodity("сыр",10),9,30),
                                            new AddTransportPurchase(new Commodity("сыр",12),9,30)
            };
            //2
            foreach (var item in purchases) {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //3
            Array.Sort(purchases);
            //4
            foreach (var item in purchases)
            {
                Console.WriteLine(item);
            }
        }
    }
}
