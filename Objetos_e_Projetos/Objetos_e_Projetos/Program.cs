using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace Objetos_e_Projetos
{
    class Program
    {
        static void Main()
        {
            string frase, x, y, z;
            string[] array;

            frase = Console.ReadLine();
            x = Console.ReadLine();
            y = Console.ReadLine();
            z = Console.ReadLine();

            array = Console.ReadLine().Split(' ');
            array = Console.ReadLine().Split(' ');

            Console.WriteLine("-------");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine($"{array[0]} {array[1]} {array[2]}");
        }
    }
}