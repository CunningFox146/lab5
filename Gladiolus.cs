using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    [Serializable]
    class Gladiolus : Flower, IDiseaseable
    {
        private bool isWatered;
        public bool IsWatered { get; set; }

        public Gladiolus(string color, bool watered) : base("gladiolus", color)
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
            return !isWatered;
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
