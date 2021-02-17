using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp8
{
    abstract class AbstractHelper
    {
        private string str;
        public string Str { get => str; set => str = value; }
        public AbstractHelper()
        {
                
        }
        public AbstractHelper(string str)
        {
            this.str = str;
        }
        abstract public string Upgrate();
        public static string UpgrateFileToString(string filePath) {
            string file = File.ReadAllText(filePath);
            DataHeplers data = new DataHeplers(file);
            file = data.Upgrate();
            MoneyHelpers money = new MoneyHelpers(file);
            file = money.Upgrate();
            return file;
        }
    }
}
