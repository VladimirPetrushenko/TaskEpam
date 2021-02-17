using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ComandRashWorker[] man = { new ComandRashWorker("Anton Slutsky", 50000, 5),
                                    new ComandRashWorker("Vasily Petrov", 30, 2),
                                    null,
                                    new ComandRashWorker("Katerina Kisel", 50000, 5),
                                    new ComandRashWorker()
                                    };
            foreach (var people in man) {
                if(people != null)
                    people.Show();
            }
            man[man.Length-1].Rash = 20000;
            try
            {
                int duration = man[0].CountDay + man[3].CountDay;
                Console.WriteLine($"Duration = {duration}\n");
            }
            catch 
            {
                Console.WriteLine("Один из элементов равен NULL\n");
            }
            foreach (ComandRashWorker people in man)
            {
                if (people != null)
                    Console.WriteLine(people);
            }
            Console.ReadLine();
        }
        
    }
    class ComandRashWorker
    {
        public const double Sut = 25000;
        private string name;
        private double rash;
        private int countDay;
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public double Rash
        {
            get { return rash; }
            set { rash = value; }
        }
        public int CountDay
        {
            get { return countDay; }
            set { countDay = value; }
        }
        public ComandRashWorker()
        {

        }
        public ComandRashWorker(string name, double rash, int countDay)
        {
            this.name = name;
            this.rash = rash;
            this.countDay = countDay;
        }
        public double GetTotal() {
            return Rash + (double)CountDay * Sut;
        }
        public void Show() {
            Console.WriteLine($"Суточные = {Sut}\nФИ = {Name}\nТранспортные расходы = {Rash}\nКоличество дней = {CountDay}\nВсего = {GetTotal()}\n");
        }
        public override string ToString()
        {
            return Sut + ";" + Name + ";" + Rash + ";" +CountDay + ";" + GetTotal()+ ";";
        }
    }
}
