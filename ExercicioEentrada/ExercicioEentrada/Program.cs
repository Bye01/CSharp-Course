using System;
using System.Data;

namespace ExercicioEentrada
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com o seu nome completo");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa");
            int qntQuantos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto");
            double preço = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre seu ultimo nome, idade e altura");
            string[] dados = Console.ReadLine().Split(' ');
            Console.WriteLine(nome);
            Console.WriteLine(qntQuantos);
            Console.WriteLine(preço);
            Console.WriteLine(dados[0]);
            Console.WriteLine(dados[1]);
            Console.WriteLine(dados[2]);


        }

    }
}