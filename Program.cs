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
            //Lab6();
            Lab7();
        }

        static void Lab7()
        {
            Bouquet bouquet = new Bouquet();
            try
            {
                bouquet.Display();
            }
            catch(EmptyBouquet e)
            {
                Console.WriteLine($"{e.Message} {e.StackTrace}");
            }
            finally
            {
                Console.WriteLine("Display: finalize");
            }
        }

        static void Lab6()
        {
            Bouquet bouquet = new Bouquet();
            bouquet.Add(new Gladiolus("green", true));
            bouquet.Add(new Rose("red", true));
            bouquet.Add(new Flower("dandelion", "blue"));

            var flower = new Flower("toremove", "red");
            bouquet.Add(flower);

            bouquet.Display();

            bouquet.Remove(flower);

            Console.WriteLine();
            bouquet.Display();

            Console.WriteLine($"\nPrice: {BouquetController.GetPrice(bouquet)}");
            Console.WriteLine($"Red flower: {BouquetController.GetFlowerByColor(bouquet, "red")}");
            BouquetController.Sort(bouquet);

            Console.WriteLine();
            bouquet.Display();

            BouquetController.ToFile(bouquet, "flower.dat");

            Bouquet bouquetFromFile = BouquetController.FromFile("flower.dat");
            if (bouquetFromFile != null)
            {
                Console.WriteLine();
                bouquetFromFile.Display();
            }

            BouquetController.ToJson(bouquet, "flower.json");
            Bouquet bouquetFromJson = BouquetController.FromJson("flower.json");
            if (bouquetFromJson != null)
            {
                Console.WriteLine();
                bouquetFromJson.Display();
            }
        }
    }
}
