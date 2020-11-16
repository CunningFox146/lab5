using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace lab5
{
    [Serializable]
    class Bouquet: IEnumerable
    {
        private List<Flower> flowers;
        public List<Flower> Flowers { get; set; }

        public Flower this[int i]
        {
            get
            {
                return flowers[i];
            }
            set
            {
                if (value is Flower)
                {
                    flowers[i] = value;
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return flowers.GetEnumerator();
        }

        public Bouquet()
        {
            flowers = new List<Flower>();
            Flowers = this.flowers;
        }

        public void Add(Flower flower)
        {
            flowers.Add(flower);
        }

        public void Remove(Flower flower)
        {
            flowers.Remove(flower);
        }

        public void Display()
        {
            for (byte i = 0; i < flowers.Count; i++)
            {
                Console.WriteLine($"Flower #{i + 1}: {flowers[i]}");
            }
        }
    }
}
