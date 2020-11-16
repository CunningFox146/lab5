using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

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

        public static void ToFile(Bouquet bouquet, string path)
        {
            // создаем объект BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            formatter.Serialize(stream, bouquet);
            stream.Close();
            Console.WriteLine("Serialized successfully!");
        }

        public static Bouquet FromFile(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);

            Bouquet newBouquet = (Bouquet)formatter.Deserialize(stream);

            stream.Close();

            Console.WriteLine("Deserialized successfully!");

            return newBouquet;
        }

        public static void ToJson(Bouquet boquet, string path)
        {
            string json = JsonSerializer.Serialize<Bouquet>(boquet);
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            File.WriteAllText(path, json);
            Console.WriteLine("Serialized and saved!");
        }

        public static Bouquet FromJson(string path)
        {
            string json = File.ReadAllText(path);
            if (json != null)
            {
                return JsonSerializer.Deserialize<Bouquet>(json);
            }
            return null;
        }

        /*
        public static void ToJson(Bouquet bouquet, string path)
        {
            string json = JsonConvert.SerializeObject(bouquet, Formatting.Indented);
            File.WriteAllText(path, json);
            Console.WriteLine("Serialized successfully!");
        }

        public static Bouquet FromJson(string path)
        {
            IList<Bouquet> dat = JsonConvert.DeserializeObject<IList<Bouquet>>(File.ReadAllText(path));
            foreach (var transformerTemplate in dat)
            {
                Console.WriteLine(transformerTemplate);
                //ControlMember.Add(TemplatesConverter.TemplateToTransformer(transformerTemplate));
            }

            return new Bouquet();//JsonConvert.DeserializeObject<Bouquet>(File.ReadAllText(path), new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
        }*/
    }
}
