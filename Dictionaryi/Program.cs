using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaryi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Cars = new Dictionary<string, string>();
            Cars.Add("IN", "Maruti");
            Cars.Add("IT", "Farari");
            Cars.Add("BN", "Proton");

            Console.WriteLine(Cars["BN"]);
            Console.ReadLine();
        }
    }
}
