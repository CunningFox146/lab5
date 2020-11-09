using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Flower : Plant
    {
        private string color;
        public string Color;

        public Flower(string type, string color) : base(type)
        {
            Color = this.color;
            this.color = color;
        }

        public void Smell()
        {
            Console.WriteLine($"Mmm, tastes like {color}");
        }
    }
}
