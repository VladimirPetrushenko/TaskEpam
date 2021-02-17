using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            //1,2
            Purchase purchase = new Purchase(args[0] + ".txt");
            purchase.Print();
            Console.WriteLine();
            //3
            Purchase purchase1 = new Purchase(args[1] + ".txt");
            //4,5,6
            Console.WriteLine();
            purchase.Insert(0, purchase1.Purchases[purchase1.Purchases.Count-1]);
            purchase.Insert(1000, purchase1.Purchases[0]);
            purchase.Insert(2, purchase1.Purchases[2]);
            //7
            purchase.Delete(3);
            purchase.Delete(10);
            purchase.Delete(-5);
            //8
            purchase.Print();
            Console.WriteLine();
            //9
            purchase.Sort(new NameCompare());
            Console.WriteLine("После сортировки");
            purchase.Print();
            //10
            Console.WriteLine();
            Console.WriteLine("Результаты поиска");
            int index = purchase.Purchases.BinarySearch(purchase1.Purchases[1],new NameCompare());
            if(index>=0 && index < purchase.Purchases.Count)
            {
                Console.WriteLine("Элемент {0} найден в позиции {1}", purchase1.Purchases[1].ToString(), index);
            }
            else
            {
                Console.WriteLine("Не найден элемент в первом листе");
            }
            index = purchase.Purchases.BinarySearch(purchase1.Purchases[3], new NameCompare());
            if (index >= 0 && index < purchase.Purchases.Count)
            {
                Console.WriteLine("Элемент {0} найден в позиции {1}",purchase1.Purchases[3].ToString(), index);
            }
            else
            {
                Console.WriteLine("Не найден элемент в первом листе");
            }
            Console.ReadLine();
        }
    }
}
