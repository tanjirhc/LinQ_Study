﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaryi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            honda honda1 = new honda();
            Dictionary<string, string> Cars = new Dictionary<string, string>();
            Cars.Add("IN", "Maruti");
            Cars.Add("IT", "Farari");
            Cars.Add("BN", "Proton");

            Console.WriteLine(Cars["BN"]);
            foreach (KeyValuePair<string, string> c in Cars) 
            {
                Console.WriteLine($"{c.Key} = {c.Value}");
            }
            Console.ReadLine();

            Public class honda
        {
            public int hondaNum { get; set; }
        }

        
        }    
}
