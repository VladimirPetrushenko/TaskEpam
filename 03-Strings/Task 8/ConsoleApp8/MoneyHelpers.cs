using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp8
{
    class MoneyHelpers : AbstractHelper
    {
        public MoneyHelpers()
        {

        }
        public MoneyHelpers(string s):base(s)
        {

        }
        public override string Upgrate()
        {
            Regex regex = new Regex(@"\b(\d{1,3} +)(\d{3} +)*(blr|belarusian roubles)");
            Str = regex.Replace(Str, ReplaceMoney);
            return Str;
        }
        string ReplaceMoney(Match m)
        {
            string targetStr = m.Value.Replace(" ", string.Empty);
            if (targetStr.Contains("blr"))
            {
                return targetStr.Replace("blr", " blr");
            }
            else
            {
                return targetStr.Replace("belarusian roubles", " belarusian roubles");
            }
        }
    }
}
