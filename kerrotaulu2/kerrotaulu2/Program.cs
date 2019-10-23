using System;

namespace kerrotaulu2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1; 
            int y = 5;
            int z = x * y;
            Console.WriteLine(x + " * " + y + " = " + z);
            Console.WriteLine(x++ + " * " + y + " = " + z);
            Console.WriteLine(x++ 2 + " * " + y + " = " + z);
            Console.WriteLine(x++ 3 + " * " + y + " = " + z);
            Console.WriteLine(x++ 4 + " * " + y + " = " + z);
            Console.WriteLine(x++ 5 + " * " + y + " = " + z);
            Console.WriteLine(x++ 6 + " * " + y + " = " + z);
            Console.WriteLine(x++ 7 + " * " + y + " = " + z);
            Console.WriteLine(x++ 8 + " * " + y + " = " + z);
            Console.WriteLine(x++ 9 + " * " + y + " = " + z);
        }
    }
}
