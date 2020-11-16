using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Flower : Plant, IComparable
    {
        private string color;
        public string Color { get; set; }

        public int CompareTo(object obj)
        {
            Flower flower = obj as Flower;
            if (flower != null)
            {
                return this.color.CompareTo(flower.Color);
            }
            throw new Exception("Невозможно сравнить два объекта");
        }

        public Flower(string type, string color) : base(type)
        {
            this.color = color;
            Color = this.color;
        }

        public void Smell()
        {
            Console.WriteLine($"Mmm, tastes like {color}");
        }

        public override void ConsumeLight()
        {
            throw new NotImplementedException();
        }

        public override string ToString() => $"Flower: Type {type} Color {color}";
    }
}
