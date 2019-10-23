using System;

namespace Loogiset_operaattorit
{
    class Program
    {
        static void Main(string[] args)
        {

        start:

            string aurinko;
            string sade;
            string lampo;

            Console.WriteLine("Paistaako aurinko (k/e)");
            aurinko = Console.ReadLine();
            Console.WriteLine("Sataako (k/e)");
            sade = Console.ReadLine();
            Console.WriteLine("Onko ulkona lammin (k/e)");
            lampo = Console.ReadLine();

            if (aurinko == sade && sade == lampo && lampo == aurinko)
                { Console.WriteLine("Aurinko paistaa ja vettä sataa taitaa tulla kesä."); }
            else if (aurinko == sade && sade == lampo && lampo != aurinko)
                { Console.WriteLine("Syksy saapui lehdet vei tuuli menneessään."); }
            else if (aurinko == sade && sade != lampo && lampo != aurinko)
                { Console.WriteLine("Jo joutui armas aika ja suvi suloinen."); }
            else if (aurinko != sade && sade != lampo && lampo == aurinko)
                { Console.WriteLine("Jo joutui armas aika ja suvi suloinen."); }
            else if (aurinko != sade && sade != lampo && lampo == aurinko)
                { Console.WriteLine("Lunta tulvillaan, on tämä maa."); }
            else if (aurinko == sade && sade != lampo && lampo != aurinko)
                { Console.WriteLine("On pimeää ja sataa, mutta lämmintä riittää."); }
            else if (aurinko == sade && sade == lampo && lampo == aurinko)
                { Console.WriteLine("keski talven taikaa."); }
            else if (aurinko != sade && sade == lampo && lampo != aurinko)
                { Console.WriteLine("Trooppinen myrsky on yllämme."); }
            else
                { Console.WriteLine("Error"); }

            Console.WriteLine("Paina jotain nappainta");
            Console.ReadKey();
            goto start;
           
        }
    }
}
