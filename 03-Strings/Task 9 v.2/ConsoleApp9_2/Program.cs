using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp9_2
{
    class Program
    {
        public static string CheckReg(Match match)
        {
            if (match.Value.StartsWith("/*"))
            {
                return string.Empty;
            }
            else if (match.Value.StartsWith("//"))
            {
                return "\r";
            }
            return match.Value;
        }
        static void Main()
        {
            string file = File.ReadAllText("in.txt");
            string delComments = @"/\*[\s\S]*?\*/";
            string chargeComments = @"//([\s\S]*?)(\r+|\z)";
            string strWithQuotes = @"(""(.*?)"")";
            string regularStr = delComments + "|" + chargeComments + "|" + strWithQuotes;
            Regex regex = new Regex(regularStr);
            string output = regex.Replace(file,CheckReg);
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
