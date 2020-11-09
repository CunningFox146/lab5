using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    static class Printer
    {
        public static void IAmPrinting(Plant obj)
        {
            Console.WriteLine($"OwO {obj.GetType()} is so cool");
            Console.WriteLine($"STRING:\"{obj.ToString()}\" is so cool too!");
        }
    }
}
