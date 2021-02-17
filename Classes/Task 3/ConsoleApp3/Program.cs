using System;

namespace ConsoleApp3
{
    //public enum Days
    //{
    //    Monday,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday,
    //    Saturday,
    //    Sunday
    //}
    class Program
    {
        static void Main(string[] args)
        {
            Purchase[] subject = { new Purchase("milk", 400, 2, DayOfTheWeek.Monday),
                    new Purchase("bread", 300, 1, DayOfTheWeek.Tuesday),
                    new Purchase("icecream", 600, 3, DayOfTheWeek.Wednesday),
                    new Purchase("oil", 800, 4, DayOfTheWeek.Sunday),
                    new Purchase("bubblegum", 50, 5, DayOfTheWeek.Friday)
                };
            //2
            foreach (var item in subject)
            {
                Console.WriteLine(item);
            }
            double result = 0;
            int count = 0;
            double max = subject[0].GetCost();
            int index = 0;
            //3
            foreach (var item in subject)
            {
                result += item.GetCost();
                if (item.GetCost() > max)
                {
                    max = item.GetCost();
                    index = count;
                }
                count++;
            }
            Console.WriteLine($"\nСредняя стоимость всех покупок равна = {result / count}\n"
                + $"День с максимальной суммой покупки будет = {subject[index].Day}\n");
            //4
            Array.Sort(subject);
            //5
            foreach (var item in subject)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Purchase : IComparable<Purchase>
    {
        private string name;
        private int price;
        private int count;
        private DayOfTheWeek day;
        public string Name { get { return name; } set { name = value; } }
        public int Price { get { return price; } set { price = value; } }
        public int Count { get { return count; } set { count = value; } }
        public DayOfTheWeek Day
        {
            get
            {
                return day;
            }

            set
            {
                day = value;
            }
        }
        public Purchase()
        {

        }
        public Purchase(string name, int price, int count, DayOfTheWeek day)
        {
            this.name = name;
            this.price = price;
            this.count = count;
            this.day = day;

        }
        public int GetCost()
        {
            return price * count;
        }
        public override string ToString()
        {
            return name + ";" + price + ";" + count + ";" + day + ";" + GetCost();
        }

        public int CompareTo(Purchase p)
        {
            return (GetCost() - p.GetCost());
        }
    }
    enum DayOfTheWeek { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
}
