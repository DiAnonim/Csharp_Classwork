using System;
using System.Collections.Generic;
using System.Collections;
using static System.Console;
using System.IO;
using System.Text;
using System.Linq;

class Program
{
    static void Main()
    {
       
            string dirName = @"D:\";
            /*WriteLine("Какой диск открыть?");

            WriteLine("Какой файл открыть?");
            string fileName = ReadLine();*/

            List<string> filesAndFolders = new();
            string[] dirs = Directory.GetDirectories(dirName);

            filesAndFolders.AddRange(dirs);

            string[] files = Directory.GetFiles(dirName);
            filesAndFolders.AddRange(files);

            if (Directory.Exists(dirName))
            {
                /*WriteLine("Папка существует:");

                WriteLine("Подкаталоги:");
                

                filesAndFolders.Sort();

                foreach (string fof in filesAndFolders)
                {
                    if (fileName == "*")
                        WriteLine(fof);
                    else
                    {
                        if (fof.Contains(fileName))
                            WriteLine(fof);
                    }
                }*/
                var searchRes = filesAndFolders.Where(x => x.Contains("G")).OrderByDescending(x => x).Skip(1)/*.Distinct()*/;
                    WriteLine($"Result:{searchRes.Count()}");
                    WriteLine($"Result:{searchRes.Min()}");
                    WriteLine($"Result:{searchRes.Max()}");
               /* foreach (string fof in searchRes)
                    WriteLine(fof);*/
            }
            else
            { 
                WriteLine("Такого диска нет:");
                WriteLine();
            }
        
    }
}

