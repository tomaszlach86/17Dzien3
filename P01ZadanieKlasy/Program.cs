﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01ZadanieKlasy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj równanie");
            string rownanie = Console.ReadLine();


            Kalkulator k = new Kalkulator();

            try
            {
                double wynik = k.WykonajDzialanie(rownanie);

                Console.WriteLine(wynik);
            }
            catch (Exception)
            {
                Console.WriteLine("Przetwarzanie danych się nie powidoło"); 
            }
                      

            //Kalkulator k2 = new Kalkulator();
            // k2.WykonajDzialanie(rownanie);



            InnaKlasa ik = new InnaKlasa();

            Console.ReadKey();
        }
    }


    public class InnaKlasa 
    { 
    }

}
