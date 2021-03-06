﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    [Serializable]
    abstract class Plant
    {
        protected string type;
        public string Type { get; set; }
        public abstract void ConsumeLight();

        public virtual void ConsumeO2()
        {
            Console.WriteLine("consumed o2!");
        }

        public Plant(string type)
        {
            Type = this.type;
            this.type = type;
        }

        public override string ToString() => $"Plant: type {type}";
    }
}
