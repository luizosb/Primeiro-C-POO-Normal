using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaTeste2
{
    class Pessoa
    {
        public string nome;
        public double altura;

        public void faleSobreVoce()
        {
            Console.WriteLine("Meu nome é " + this.nome + ".");
            Console.WriteLine("Minha altura é de " + this.altura + " metros.");
        }
    }
}
