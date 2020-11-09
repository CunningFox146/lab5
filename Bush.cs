using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Bush: Plant
    {
        private bool edible;
        public bool Edible { get; set; }

        public Bush(string type, bool edible) : base(type)
        {
            Edible = this.edible;
            this.edible = edible;
        }

        public void EatBerries()
        {
            Console.WriteLine(edible ? "Yummy!" : "Oh no, I'm dead");
        }
    }
}
