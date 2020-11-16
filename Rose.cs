using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Rose : Flower, IDiseaseable
    {
        private bool pointy;
        public bool Pointy { get; set; }
        private Random rnd = new Random();

        public Rose(string color, bool pointy) : base("rose", color)
        {
            Pointy = this.pointy;
            this.pointy = pointy;
        }

        public void Touch()
        {
            Console.WriteLine(pointy ? "mmm soft to my teeth" : "pointy to my tongue and gums");
        }

        public bool CanBeDeceased()
        {
            return rnd.Next() <= 0.1;
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

        public override string ToString() => $"Rose: pointy {pointy}";
    }
}
