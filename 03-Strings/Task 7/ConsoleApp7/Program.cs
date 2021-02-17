using System;
using System.IO;
using System.Text;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "in.txt";
            if (File.Exists(path))
            {
                string[] stroki = File.ReadAllLines(path);
                int error = 0;
                double result = 0;
                StringBuilder outFile0 = new StringBuilder("result(");
                StringBuilder outFile1 = new StringBuilder("error-lines = ");
                string[] outFile = { "result(", "error-lines = " };
                bool firstString = true;
                foreach (var item in stroki)
                {
                    string[] words = item.Split(new char[] { ';' });
                    try
                    {
                        int x = Int32.Parse(words[0]);
                        result += Double.Parse(words[x]);
                        if (firstString == false)
                        {
                            if (Double.Parse(words[x]) >= 0)
                                outFile0.AppendFormat(" + {0:0.0#}", Double.Parse(words[x]));
                            else
                                outFile0.AppendFormat(" - {0:0.0#}", -Double.Parse(words[x]));
                        }
                        else
                        {
                            outFile0.AppendFormat("{0:0.0#}", Double.Parse(words[x]));
                            firstString = false;
                        }
                    }
                    catch
                    {
                        error++;
                    }
                }
                outFile0.AppendFormat(") = {0:0.0}", result.ToString());
                outFile1.Append(error) ;
                File.WriteAllLines("out.csv", new string[] { outFile0.ToString(), outFile1.ToString()});
            }
            else
            {
                Console.WriteLine("File is not found!");
            }
            Console.ReadLine();
        }
    }
}
