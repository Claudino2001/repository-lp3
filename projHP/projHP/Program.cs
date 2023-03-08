/*
 * Atividade Avaliativa 01
 * Componentes:
    Gabriel de Araujo Claudino
    Arthur Sant'Anna de Carvalho Santos
    Luca Torres Villela
*/

using System;

namespace projHP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ave a = new Ave();
            Peixe p = new Peixe();
            Mamifero m = new Mamifero();
            Reptil r = new Reptil();

            a.Peso = 2;
            a.Idade = 1;
            a.Membros = 2;
            a.locomover();
            a.alimentar();
            a.emitirSom();

            Console.WriteLine("");

            p.Peso = 5;
            p.Idade = 3;
            p.Membros = 0;
            p.locomover();
            p.alimentar();
            p.emitirSom();

            Console.WriteLine("\n***********\n");

            m.Peso = 56;
            m.Idade = 30;
            m.Membros = 4;
            m.locomover();
            m.alimentar();
            m.emitirSom();

            Console.WriteLine("");

            Canguru c = new Canguru();
            c.Peso = 83;
            c.Idade = 12;
            c.Membros = 4;
            c.locomover(); //Polimorfismo de Sobreposição
            c.alimentar();
            c.emitirSom();

            Console.WriteLine("\n***********\n");

            Cachorro dog = new Cachorro();

            dog.reagir("comida");
            dog.reagir("oi");
            dog.reagir(11, 45);
            dog.reagir(22, 30);
            dog.reagir(true);
            dog.reagir(false);
            dog.reagir(2, 4.4f);
            dog.reagir(17, 4.2f);

            Console.ReadLine();
        }
    }
}
