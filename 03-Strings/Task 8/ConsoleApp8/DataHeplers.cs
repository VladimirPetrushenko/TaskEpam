using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp8
{
    class DataHeplers : AbstractHelper
    {
        
        public DataHeplers():base()
        {

        }
        public DataHeplers(string s):base(s)
        {

        }

        public string ReplaceDate(Match m)
        {
            try
            {
                DateTime date = DateTime.Parse(m.Value);
                return date.ToString("MMMM dd, yyyy", CultureInfo.CreateSpecificCulture("en-US"));
            }
            catch (FormatException)
            {
                return m.Value.ToString();
            }
        }

        public override string Upgrate()
        {
            Regex regex = new Regex(@"\b\d{1,2}[/|.|-]\d{1,2}[/|.|-]\d{2,4}\b");
            Str = regex.Replace(Str, ReplaceDate);
            return Str;
        }
    }
}
