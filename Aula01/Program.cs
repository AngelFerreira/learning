using System;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes =
            {
                "Sol",
                "Lua",
                "Estrela",
                "Mar",
                "Ondas"
            };

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i]);
            }

            Console.ReadKey();
        }
    }
}

