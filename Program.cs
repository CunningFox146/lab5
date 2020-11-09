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
            ((ITest)bush).ConsumeLight();

            var flower = new Flower("butter", "yellow");
            var rose = new Rose("butter", "yellow", true);
            var gladiolus = new Gladiolus("butter", "yellow", true);
            var cactus = new Cactus("butter", false);
            var bouquet = new Bouquet("beautiful");
            var paper = new Paper("hello");

            Console.WriteLine(rose is Flower);
            Console.WriteLine(paper is Flower);
            Console.WriteLine(gladiolus is Plant);
            Console.WriteLine(bush is Paper);

            var rosePlant = rose as Plant;
            if (rosePlant != null)
            {
                Console.WriteLine(rosePlant);
            }
            
            var roseDisieaseable = rose as IDiseaseable;
            if (roseDisieaseable != null)
            {
                Console.WriteLine(roseDisieaseable);
            }
            var paperDisieaseable = paper as IDiseaseable;
            if (paperDisieaseable != null)
            {
                Console.WriteLine(paperDisieaseable);
            }
            else
            {
                Console.WriteLine("oh no");
            }

            var gladiolusPlant = (Plant)gladiolus;
            gladiolusPlant.ConsumeO2();


            Console.ReadKey();
        }
    }
}
