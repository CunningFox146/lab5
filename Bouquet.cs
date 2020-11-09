using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Bouquet
    {
        private string name;
        public string Name;

        public Bouquet(string name)
        {
            Name = name;
            this.name = name;
        }

        public override bool Equals(object obj)
        {
            var other = obj as Bouquet;
            if (other == null)
            {
                return false;
            }
            return this.name == other.name;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }

        // Return the point's value as a string.
        public override string ToString()
        {
            return $"(Bouquet: {name})";
        }

        // Return a copy of this point object by making a simple field copy.
        public Bouquet Copy()
        {
            return (Bouquet)this.MemberwiseClone();
        }

    }
}
