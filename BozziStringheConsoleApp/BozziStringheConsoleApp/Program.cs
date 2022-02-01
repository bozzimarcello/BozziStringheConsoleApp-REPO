using System;

namespace BozziStringheConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stringhe Console App");
            Console.WriteLine("Questo programma analizza una frase, lettera per lettera");

            Console.WriteLine("Inserisci una frase:");
            string frase = Console.ReadLine();

            for(int i = 0; i<frase.Length; i++)
            {
                char carattere = frase[i];
                Console.WriteLine(carattere);
            }
        }
    }
}
