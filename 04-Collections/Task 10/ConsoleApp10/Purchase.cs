using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Purchase : IComparable<Purchase>
    {
        private List<Purchase> purchases = new List<Purchase>();
        private string name;
        private int price;
        private int count;
        public string Name { get { return name; } set { name = value; } }
        public int Price { get { return price; } set { price = value; } }
        public int Count { get { return count; } set { count = value; } }
        public List<Purchase> Purchases { get => purchases; set => purchases = value; }
        public Purchase()
        {
            purchases = new List<Purchase>();
        }
        public Purchase(string path)
        {
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    Purchase p1 = createPurchase(line, out int error);
                    if (error == 3)
                    {
                        Purchases.Add(p1);
                    }
                    if (error == 4)
                    {
                        Purchases.Add(p1);
                    }
                }
            }
        }
        public Purchase(string name, int price, int count)
        {
            this.name = name;
            this.price = price;
            this.count = count;
        }
        public virtual int GetCost()
        {
            return price * count;
        }
        public override string ToString()
        {
            return name + ";" + price + ";" + count;
        }
        private Purchase createPurchase(string csvString, out int error)
        {
            string name = "";
            int price = -1;
            int count = -1;
            decimal sale = -1;
            error = 0;
            string[] words = csvString.Split(new char[] { ';' });
            try
            {
                for (int i = 0; i < words.Length; i++)
                {
                    string word = words[i];
                    switch (error)
                    {
                        case 0:
                            name = word;
                            if(name == string.Empty)
                            {
                                error = 10;
                            }
                            break;
                        case 1:
                            price = Int32.Parse(word);
                            break;
                        case 2:
                            count = Int32.Parse(word);
                            break;
                        case 3:
                            sale = decimal.Parse(word);
                            if (sale > price)
                            {
                                error = 10;
                            }
                            break;
                        default:
                            error = 10;
                            break;
                    }
                    error++;
                }
            }
            catch (Exception)
            {
                error = -1;
            }
            if (error == 3)
            {
                return new Purchase(name, price, count);
            }
            if (error == 4)
            {
               return new PricePurchase(name, price, count, sale);
            }
            return new Purchase();
        }
        public int CompareTo(Purchase p)
        {
            return (GetCost() - p.GetCost());
        }
        public void Insert(int index, Purchase p)
        {
            if (purchases.Count > index)
            {
                purchases.Insert(index, p);
            }
            else
            {
                purchases.Add(p);
            }
        }
        public int Delete(int index)
        {
            if (index >= purchases.Count || index<0)
            {
                return -1;
            }
            purchases.RemoveAt(index);
            return index;
        }
        public decimal TotalCost()
        {
            decimal result = 0;
            foreach(var item in purchases)
            {
                result += item.GetCost();
            }
            return result;
        }
        public void Print()
        {
            Console.WriteLine("{0, -10} {1, 6} {2, 6} {3, 6} {4, 8}", "Name", "Price", "Number", "Cost", "Discount");
            foreach(var item in purchases)
            {
                Console.WriteLine(item.ConvertToTable());
            }
            Console.WriteLine("{0, -10} {1,20}", "Total cost", TotalCost());
        }
        public virtual string ConvertToTable()
        {
            return String.Format("{0, -10} {1, 6} {2, 6} {3, 6} ", name , price , count, GetCost());
        }
        public void Sort(IComparer<Purchase> cmp)
        {
            purchases.Sort(cmp);
        }
    }
}
