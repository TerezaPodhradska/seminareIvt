using System;
using System.Collections.Generic;
using System.Linq;

namespace VrazednaCisla
{
    class Program
    {
        static void Main(string[] args)
        {
            string popis = "Zadejte číslo, jehož dělitele budeme hledat (Q): ";
            VystupAVstup.Vstup.VstupDoPole(popis);
            string hlaska = "Zadejte pocet čísel (N) a čísla jehož součet budeme hledat (Q): ";
            VystupAVstup.Vstup.VstupString(hlaska);


        }


    }
}

namespace VystupAVstup
{
    class Vstup
    {
        public Vstup()
        {

        }
        public static int[] VstupDoPole(string popis)
        {
            string zadani = "Zadejte čísla ";
            System.Collections.Generic.List<int> pole = new List<int>();
            Console.WriteLine(popis);
            int n = int.Parse(Console.ReadLine());

            string tmpString = "";
            {
                Console.Write(zadani);
                int nn = int.Parse(Console.ReadLine());
                pole.Append(nn);

            } while (tmpString == "") ;

            return pole.ToArray();



        }
        public static string VstupString(string popis)
        {
            Console.WriteLine(popis);
            string q = Console.ReadLine();
            return q;
        }

    }
    class Q
    {
        public Q()
        {
           
        }
      
    }
    class Vystup
    {
        public Vystup()
        {

        }
    }
}

