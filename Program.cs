using System;
using senai.OO.exercicio1.Classes;

namespace senai.OO.exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Pessoa1

            //Criação do objeto Pessoa
            Pessoa pessoa1 = new Pessoa();

            Console.WriteLine("Informe o nome da Pessoa 1");
            //Atribui o nome da pessoa ao objeto
            pessoa1.Nome = Console.ReadLine();

            Console.WriteLine($"Informe a altura de {pessoa1.Nome}.");
            pessoa1.Altura = float.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o peso de {pessoa1.Nome}.");
            pessoa1.Peso = float.Parse(Console.ReadLine());

            Console.WriteLine($"O IMC de {pessoa1.Nome} é {pessoa1.Peso/ Math.Pow(pessoa1.Altura, 2)}");
            #endregion

            #region Pessoa2
            
            //Criação Pessoa 2
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Informe o nome da Pessoa 2");
            //Atribui o nome da pessoa ao objeto
            pessoa2.Nome = Console.ReadLine();

            Console.WriteLine($"Informe a altura de {pessoa2.Nome}.");
            pessoa2.Altura = float.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o peso de {pessoa2.Nome}.");
            pessoa2.Peso = float.Parse(Console.ReadLine());

            Console.WriteLine($"O IMC de {pessoa1.Nome} é {pessoa2.Peso/ Math.Pow(pessoa2.Altura, 2)}");

            #endregion

            #region Pessoa3

            //Criação do objeto Pessoa
            Pessoa pessoa3 = new Pessoa();

            Console.WriteLine("Informe o nome da Pessoa 3");
            //Atribui o nome da pessoa ao objeto
            pessoa3.Nome = Console.ReadLine();

            Console.WriteLine($"Informe a altura de {pessoa3.Nome}.");
            pessoa3.Altura = float.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o peso de {pessoa3.Nome}.");
            pessoa3.Peso = float.Parse(Console.ReadLine());

            Console.WriteLine($"O IMC de {pessoa3.Nome} é {pessoa3.Peso/ Math.Pow(pessoa3.Altura, 2)}");
            #endregion
        }
    }
}
