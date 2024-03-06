using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Name = new List<string> { "Ehsanul", "Tamim", "Nafis"};
            foreach (string s in Name) 
            { 
                Console.WriteLine(s);
            }

            
            string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };

            var wordGroups = from w in words
                             group w by w[0] into g
                             select (FirstLetter: g.Key, Words: g);

            foreach (var g in wordGroups)
            {
                Console.WriteLine("Words that start with the letter '{0}':", g.FirstLetter);
                foreach (var w in g.Words)
                {
                    Console.WriteLine(w);
                }
            }

            Console.ReadLine();

            List<string> NameList = (from nam in Name
                                     where nam.Length ==5
                                     select nam).ToList();

            foreach (string s in NameList)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
