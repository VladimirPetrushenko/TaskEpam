using System;
using System.IO;
using System.Text;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("in.txt"))
            {
                string[] lines = File.ReadAllLines("in.txt");
                int index = 0;
                bool coment = false;
                int indexLine = 0;
                for (int i = 0; i < lines.Length; i++)
                {
                    int indexNach = 0;
                    int indexKon = 0;
                    if (lines[i].Contains("/*"))
                    {
                        coment = true;
                        indexLine = i;
                        if (lines[i].Contains("\""))
                        {
                            indexNach = lines[i].IndexOf("\"");
                            indexKon = lines[i].LastIndexOf("\"");
                        }
                        index = lines[i].IndexOf("/*");
                        if (index > indexNach && index < indexKon)
                        {
                            index = lines[i].IndexOf("/*", indexKon);
                            if (index == 0)
                                coment = false;
                            else
                            {
                                string line = lines[i].Substring(index);
                                if (line.Contains("*/"))
                                {
                                    int index1 = line.IndexOf("*/") + 2;
                                    lines[i] = lines[i].Remove(index, index1);
                                    coment = false;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            string line = lines[i].Substring(index);
                            if (line.Contains("*/"))
                            {
                                int index1 = line.IndexOf("*/") + 2;
                                lines[i] = lines[i].Remove(index, index1);
                                coment = false;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    if (lines[i].Contains("*/") && coment == true)
                    {
                        lines[indexLine] = lines[indexLine].Remove(index);
                        for (int j = indexLine + 1; j < i; j++)
                        {
                            lines[j] = lines[j].Remove(0);
                        }
                        lines[i] = lines[i].Remove(0, lines[i].IndexOf("*/") + 2);
                        coment = false;
                    }
                    if (lines[i].Contains("//") && coment == false)
                    {
                        index = lines[i].IndexOf("//");
                        if (lines[i].Contains("\""))
                        {
                            indexNach = lines[i].IndexOf("\"");
                            indexKon = lines[i].LastIndexOf("\"");
                        }
                        if (index <= indexNach || index >= indexKon)
                            lines[i] = lines[i].Remove(index);
                        else if ((index = lines[i].IndexOf("//", indexKon))> 0)
                            lines[i] = lines[i].Remove(index);
                    }
                }
                StringBuilder line1 = new StringBuilder();
                coment = true;
                foreach (string line in lines)
                {
                    if (line.Length == 0 && coment == true)
                        continue;
                    line1.Append(line + "\n");
                    coment = false;
                }
                Console.WriteLine(line1);
            }

        }
    }
}
