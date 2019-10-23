using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace funktiot

{

    class Program

    {

        private static int Tervehdys(string nimi)

        {

            Console.WriteLine("Tervetuloa ohjelmaan " + nimi + "!");
            Console.WriteLine("Kuinka vanha olet");
            int ika = int.Parse(Console.ReadLine());
            return ika;
        }



        static void Main(string[] args)

        {
            int ika;
            Console.WriteLine("Anna Etunimi:");
            String etunimi = Console.ReadLine();
            Console.WriteLine("Anna Sukunimi");
            string sukunimi = Console.ReadLine();
            string nimi = etunimi + " " + sukunimi;
            ika = Tervehdys(nimi);
            Console.WriteLine(ika);
        }

    }

}
