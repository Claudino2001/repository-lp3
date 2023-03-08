using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projHP
{
    internal class Mamifero : Animal
    {
        private String corPelo;
        public override void alimentar()
        {
            Console.WriteLine("Mamando.");
        }

        public override void emitirSom()
        {
            Console.WriteLine("Som de Mamífero.");
        }

        public override void locomover()
        {
            Console.WriteLine("Correndo.");
        }
    }
}
