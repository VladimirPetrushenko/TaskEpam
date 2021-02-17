using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var f in new DirectoryInfo(@"D:\обучение\2\Kursovoi\Kursovoi").GetFiles("*.c", SearchOption.AllDirectories))
            {
                string s = File.ReadAllText(f.FullName);
                File.WriteAllText(f.FullName, s, Encoding.UTF8);
            }
        }
    }
}
