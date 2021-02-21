using System;

namespace bootExemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroDeVezes =5;

            for (int i=1; i<numeroDeVezes; i++)
            {
                Console.WriteLine($"Me tornei autosuficiente! Você tem apenas {i} segundos..");
            }
        }
    }
}
