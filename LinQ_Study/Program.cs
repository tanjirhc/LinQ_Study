﻿using System;
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
