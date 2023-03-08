using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projHP
{
    internal class Peixe : Animal
    {
        private String corEscama;
        public override void alimentar()
        {
            Console.WriteLine("Comendo substâncias.");
        }

        public override void emitirSom()
        {
            Console.WriteLine("Peixe não faz som.");
        }

        public override void locomover()
        {
            Console.WriteLine("Nadando.");
        }

        public void soltarBolhas()
        {
            Console.WriteLine("Soltou bolhas.");
        }

    }
}
