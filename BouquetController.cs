using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    static class BouquetController
    {
        static Dictionary<string, float> prices = new Dictionary<string, float>
        {
            {"red", 1f},
            {"green", 2.5f},
            {"blue", 3.1f},
        };

        static public float GetPrice(Bouquet bouquet)
        {
            float result = 0f;
            foreach (Flower flower in bouquet)
            {
                if (prices.ContainsKey(flower.Color))
                {
                    result += prices[flower.Color];
                }
                else
                {
                    Console.WriteLine($"ERROR: Undefined color! {flower.Color}");
                }
            }

            return result;
        }

        // Returns only FIRST matching flower
        static public Flower GetFlowerByColor(Bouquet bouquet, string color)
        {
            foreach (Flower flower in bouquet)
            {
                if (flower.Color == color)
                {
                    return flower;
                }
            }
            return null;
        }

        static public void Sort(Bouquet bouquet)
        {
            bouquet.Flowers.Sort();
        }
    }
}
