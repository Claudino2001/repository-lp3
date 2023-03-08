using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projHP
{
    internal class Cachorro : Mamifero
    {
        public void enterrarOsso()
        {
            Console.WriteLine("Enterrando Osso.");
        }

        public void abanarrabo()
        {
            Console.WriteLine("Abanando o rabo.");
        }


        //Polimorfismo de Sobrecarga
        //Assinaturas diferentes
        //Mesma classe
        public void reagir(String frase)
        {
            if (frase == "comida")
            {
                Console.WriteLine("Abanar o rabo.");
            }
            else
            {
                Console.WriteLine("Rosnar.");
            }
        }

        public void reagir(int hora, int min)
        {
            if (hora >= 19)
            {
                Console.WriteLine("Ignorar.");
            }
            else
            {
                Console.WriteLine("Abanar o rabo.");
            }
        }
        public void reagir(Boolean input)
        {
            if (input)
            {
                Console.WriteLine("Abanar o rabo.");
            }
            else
            {
                Console.WriteLine("Rosnar.");
            }
        }
        public void reagir(int idade, float peso)
        {
            if (idade < 5)
            {
                if (peso < 10)
                {
                    Console.WriteLine("Abanar o rabo.");
                }
                else
                {
                    Console.WriteLine("Latir.");
                }
            }
            if (idade > 5)
            {
                if (peso < 10)
                {
                    Console.WriteLine("Latir.");
                }
                else
                {
                    Console.WriteLine("Rosnar.");
                }
            }        
        }
    }
}
