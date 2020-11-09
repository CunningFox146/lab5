using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    interface IDiseaseable
    {
        public bool CanBeDeceased();
        public bool BecomeDeceased();
        public void CheckDeceased();
    }

    interface ITest
    {
        public void ConsumeLight();
    }
}
