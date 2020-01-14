using System;

namespace ProgramaTeste2
{
    class Program
    {
        static void Main(string[] args)
        {
            String entrada = "";

            Console.WriteLine("------------------------------------------------------------------------------");

            Pessoa pessoa1;
            pessoa1 = new Pessoa();
            
            Console.WriteLine("Este programa lê o seu nome e sua altura! Três pessoas serão analisadas!");
            Console.WriteLine("Agora vamos ler da 1º pessoa.");
            Console.WriteLine("Digite seu nome: ");
            entrada = Console.ReadLine();
            pessoa1.nome = entrada;
            Console.WriteLine("Digite sua altura: ");
            entrada = Console.ReadLine();
            pessoa1.altura = Convert.ToDouble(entrada);
            pessoa1.faleSobreVoce();

            Console.WriteLine("------------------------------------------------------------------------------");
            

            Pessoa pessoa2;
            pessoa2 = new Pessoa();

            Console.WriteLine("Agora vamos ler da 2º pessoa.");
            Console.WriteLine("Digite seu nome: ");
            entrada = Console.ReadLine();
            pessoa2.nome = entrada;
            Console.WriteLine("Digite sua altura: ");
            entrada = Console.ReadLine();
            pessoa2.altura = Convert.ToDouble(entrada);
            pessoa2.faleSobreVoce();

            Console.WriteLine("------------------------------------------------------------------------------");

            Pessoa pessoa3;
            pessoa3 = new Pessoa();

            Console.WriteLine("Agora vamos ler da 3º pessoa.");
            Console.WriteLine("Digite seu nome: ");
            entrada = Console.ReadLine();
            pessoa3.nome = entrada;
            Console.WriteLine("Digite sua altura: ");
            entrada = Console.ReadLine();
            pessoa3.altura = Convert.ToDouble(entrada);
            pessoa3.faleSobreVoce();
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.ReadKey();
                                        
        }
    }
}
