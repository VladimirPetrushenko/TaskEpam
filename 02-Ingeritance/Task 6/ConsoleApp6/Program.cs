using System;

namespace ConsoleApp6
{
    class Program
    {
        private static void showOperation(AbstractOperation[] operations) 
        {
            foreach (var item in operations)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            AbstractOperation[] operations = { new SumOperation(10,12),
                                                new SumOperation(2,3),
                                                new SubOperation(1,11),
                                                new SubOperation(20,10),
                                                new MultiplyeOperation(10,5),
                                                new MultiplyeOperation(5,9),
                                                new DevOperation(10,5),
                                                new DevOperation(360,9),
                                                new StepOperation(2,3),
                                                new StepOperation(2,4)
            };
            showOperation(operations);
            Array.Sort(operations);
            Console.WriteLine();
            showOperation(operations);
        }
    }
}
