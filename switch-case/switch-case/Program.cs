using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int viikonpaiva;
            string paiva;

            Console.WriteLine("Anna viikonpäivän numero (1-7)");
            paiva = Console.ReadLine();
            viikonpaiva = int.Parse(paiva);

            switch (viikonpaiva)
            {

                case 1:
                    Console.WriteLine("Maanantai");
                    break;

                case 2:
                    Console.WriteLine("Tiistai");
                    break;

                case 3:
                    Console.WriteLine("Keskiviikko");
                    break;

                case 4:
                    Console.WriteLine("Torstai");
                    break;

                case 5:
                    Console.WriteLine("Perjantai");
                    break;

                case 6:
                    Console.WriteLine("Lauantai");
                    break;

                case 7:
                    Console.WriteLine("Sunnuntai");
                    break;

                default:
                    Console.WriteLine("viikossa on vain 7 päivää.");
                    break;

            }

            Console.WriteLine("Anna arvosana ohjelmalle (1-10)");
            int arvosana = int.Parse(Console.ReadLine());
            switch (arvosana)
            {
                case 1:
                    Console.WriteLine("1 vastaa katastrofia");
                    break;

                case 2:
                    Console.WriteLine("2 vastaa surkeaa");
                    break;

                case 3:
                    Console.WriteLine("3 vastaa huonoa");
                    break;

                case 4:
                    Console.WriteLine("4 vastaa hieman huonoa");
                    break;

                case 5:
                    Console.WriteLine("5 vastaa tyydyttävää");
                    break;

                case 6:
                    Console.WriteLine("6 vastaa erittäin tyydyttävää");
                    break;

                case 7:
                    Console.WriteLine("7 vastaa hyvää");
                    break;

                case 8:
                    Console.WriteLine("8 vastaa erittäin hyvää");
                    break;

                case 9:
                    Console.WriteLine("9 vastaa erinomaista");
                    break;

                case 10:
                    Console.WriteLine("10 vastaa täydellistä");
                    break;

                default:
                    Console.WriteLine("Arviointi epäonnistui");
                    break;
            }

            Console.WriteLine("Paina jotain lopettaaksesi ohjelman");
            Console.ReadKey();
            Console.WriteLine("Hehe huijasin");
            Console.ReadKey();

        }
    }
}
