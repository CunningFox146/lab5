using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    abstract class Plant
    {
        protected string type;
        public string Type { get; set; }

        public void ConsumeO2()
        {
            Console.WriteLine("consumed o2!");
        }

        public Plant()
        {
            Type = type;
        }
    }
}
