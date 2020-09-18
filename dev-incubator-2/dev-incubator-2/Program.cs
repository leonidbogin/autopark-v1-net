using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = args.Length;
            List<string>[] lists = new List<string>[n];
            for (int i = 0; i < n; i++)
            {
                lists[i] = DetailsFromFile(args[i]);
                PrintList(lists[i], i+1);
            }
            Console.WriteLine();

            DictionaryDetails dictionary = new DictionaryDetails();
            
            for (int i = 0; i < n; i++)
                for (int j = 0; j < lists[i].Count; j++)
                    dictionary.Add(lists[i][j]);

            dictionary.Print();
            Console.ReadLine();
        }

        private static List<string> DetailsFromFile(string inFile)
        {
            List<string> list = new List<string>();
            try
            {
                StreamReader sr = new StreamReader(inFile + ".csv");
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    list.Add(s);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File {inFile} not found.");
            }
            return list;
        }

        private static void PrintList(List<string> list, int index)
        {
            string output = $"List {index}: ";
            bool firstWord = true;
            foreach (string s in list)
            {
                if (firstWord) firstWord = false;
                else output += ", "; 
                
                output += s; 
            }
            Console.WriteLine(output);
        }
    }
}
