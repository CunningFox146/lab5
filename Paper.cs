using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Paper
    {
        private string text;
        public string Text;

        public Paper(string txt)
        {
            Text = text;
            text = txt;
        }

        public void PrintText()
        {
            if (text == null)
            {
                throw new PaperTextException();
            }
            Console.WriteLine(text);
        }

        public override string ToString() => $"Paper: text {text}";
    }
}
