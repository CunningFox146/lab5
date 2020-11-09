using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    sealed class Cactus : Plant
    {
        private bool isBlooming;
        public bool IsBlooming { get; set; }

        public Cactus(string type, bool blooming) : base(type)
        {
            IsBlooming = isBlooming;
            isBlooming = blooming;
        }

        public void PickFlowers()
        {
            Console.WriteLine(isBlooming ? "Pretty flowers for pretty me" : "There's nothing to take lol");
        }

        public override void ConsumeO2()
        {
            if (!isBlooming)
            {
                Console.WriteLine("Consumed a little bit of o2.");
                return;
            }
            base.ConsumeO2();
        }

        public override void ConsumeLight()
        {
            throw new NotImplementedException();
        }
    }
}
