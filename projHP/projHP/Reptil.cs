using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projHP
{
    internal class Reptil : Animal
    {
        private String corEscama;
        public override void alimentar()
        {
            Console.WriteLine("Comendo Vegetais.");
        }

        public override void emitirSom()
        {
            Console.WriteLine("Som de Réptil.");
        }

        public override void locomover()
        {
            Console.WriteLine("Rastejando.");
        }
    }
}
