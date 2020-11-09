using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Gladiolus : Flower, IDiseaseable
    {
        private bool isWatered;
        public bool IsWatered { get; set; }
        private Random rnd = new Random();

        public Gladiolus(string type, string color, bool watered) : base(type, color)
        {
            IsWatered = isWatered;
            isWatered = watered;
        }

        public void Water()
        {
            if (isWatered)
            {
                Console.WriteLine("OMG IM DROWNING HE-L----LP");
                return;
            }
            isWatered = true;
            Console.WriteLine("I'm nice and fresh");
        }

        public bool CanBeDeceased()
        {
            return rnd.Next() <= 0.5;
        }

        public bool BecomeDeceased()
        {
            Console.WriteLine($"{type} became deceased!");
            return true;
        }

        public void CheckDeceased()
        {
            Console.WriteLine(CanBeDeceased() ? "It's sick and dead!" : "It's alive and happy!");
        }

        public override string ToString() => $"Gladiolus: isWatered {isWatered}";
    }
}
