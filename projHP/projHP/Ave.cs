using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projHP
{
    internal class Ave : Animal
    {
        private String corPena;
        public override void alimentar()
        {
            Console.WriteLine("Comendo frutas.");
        }

        public override void emitirSom()
        {
            Console.WriteLine("Som de Ave.");
        }

        public override void locomover()
        {
            Console.WriteLine("Voando.");
        }

        public void fazerNinho()
        {
            Console.WriteLine("Construiu um ninho.");
        }
    }
}
