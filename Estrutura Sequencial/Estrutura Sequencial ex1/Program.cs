using System;
using System.Globalization;

namespace Estrutura_Sequencial
{

}
class Program
{
    static void Main(string[] args)
    {
        ex1();
    }
    static void ex1()
    {

        int A, B, soma;

        Console.WriteLine("coloque dois numeros");

        A = int.Parse(Console.ReadLine());
        B = int.Parse(Console.ReadLine());
        soma = A + B;

        Console.WriteLine("SOMA = " + soma);
        //  Console.WriteLine("SOMA = " + A + B);