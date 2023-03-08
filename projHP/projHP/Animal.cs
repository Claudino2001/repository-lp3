using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projHP
{
    internal abstract class Animal
    {
        protected float peso;
        protected int idade;
        protected int membros;

        public float Peso { get { return peso; } set { peso = value; } }
        public int Idade { get { return idade; } set { idade = value; } }
        public int Membros { get { return membros; } set { membros = value; } }

        public abstract void locomover();
        
        public abstract void alimentar();

        public abstract void emitirSom();

    }
}
