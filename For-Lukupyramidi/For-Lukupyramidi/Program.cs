using System;

namespace For_Lukupyramidi
{
    class Program
    {
        static void Main(string[] args)
        {
            int kerros, tila, numero;
            Console.WriteLine("Tehdään pyramidi, anna luku.");
            kerros = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= kerros; i++)
            {
                for (tila = 1; tila <= (kerros - i); tila++)
                    Console.Write(" ");
                for (numero = 1; numero <= i; numero++)
                    Console.Write(numero);
                for (numero = (i - 1); numero >= 1; numero--)
                    Console.Write(numero);
                Console.WriteLine();
            }

        }
    }
}
