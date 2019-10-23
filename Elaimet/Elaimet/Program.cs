using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
  
   Muista kommentoida toiminnalliset funktiot!

   https://msdn.microsoft.com/en-us/library/5ast78ax.aspx

    1. Luokassa Hevonen ei ole kuin yhden tyyppinen konstruktori,  parametriton konstruktori. Tutki luokkaa.
    2. Luo Hevonen -luokasta olio Main -metodissa
	3. Lisää rivi missä Tulostat olion nimi ja paino näytölle.
	4. Lisää koodiin rivit missä annetaan luodulle oliolle nimi ja paino.
    5. Tulosta olion tiedot nyt näytölle.
  
   
**/
namespace Elaimet
{
    class Program
    {
        static void Main(string[] args)
        {
            Hevonen hevonen = new Hevonen();
            //Tässä luot luokasta olion

            hevonen.Nimi = "Randolf";
            hevonen.Paino = 224;

            Console.WriteLine("Name " + hevonen.Nimi + " Weight " + hevonen.Paino);
            //Tulosta olion nimi ja paino

            Console.WriteLine("Change horse's name");
            hevonen.Nimi = Console.ReadLine();

            Console.WriteLine("Change horses Weight (kg)");
            hevonen.Paino = int.Parse(Console.ReadLine());
            //Muuta olion nimeä ja painoa

            Console.WriteLine("Name " + hevonen.Nimi + " Weight " + hevonen.Paino);
            Console.ReadKey();
            //Tulosta nyt olion nimi ja paino, jotta varmistat että muutos tapahtui

        }
    }
}
