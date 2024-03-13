using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void PrinteDelegate(string message);
    public class Program
    {
        private static void Print(string message)
        {
            Console.WriteLine(message);
        }
        private static void Print2(string msg) 
        { 
            Console.WriteLine(msg+"Print int from method 2");
        }
        public static void calculate(int a, int b, PrinteDelegate printer)
        {
            int result = a + b;
            printer(result.ToString());
        }
        static void Main(string[] args)
        {
            calculate(1, 2, Print2);
            Console.ReadLine();
        }
    }
}
