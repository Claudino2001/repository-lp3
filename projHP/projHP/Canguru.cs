using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projHP
{
    internal class Canguru : Mamifero
    {
        public void usarBolsa()
        {
            Console.WriteLine("Usando bolsa.");
        }

        //Polimorfismo de Sobreposição
        //Mesma assinatura
        //Classes diferentes
        public override void locomover()
        {
            Console.WriteLine("Saltando.");
        }
    }
}
