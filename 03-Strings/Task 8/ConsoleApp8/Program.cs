using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp8
{
    class Program
    {
        static void Main()
        {
            if (File.Exists("in.txt"))
            {                
                File.WriteAllText("out.txt", AbstractHelper.UpgrateFileToString("in.txt"));
            }
            else
            {
                Console.WriteLine("File is not found");
            }
        }
    }
}
