using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            var bush = new Bush("bush", true);
            bush.ConsumeLight();
            var testBush = (ITest)bush;
            testBush.ConsumeLight();

        }
    }
}
