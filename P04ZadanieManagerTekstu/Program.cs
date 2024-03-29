﻿using P04ZadanieManagerTekstu.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieManagerTekstu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj zdanie");
            string zdanie = Console.ReadLine();

            ManagerTekstu mt = new ManagerTekstu();

            try
            { 
                string najdluzszy= mt.ZnajdzNajdluzszyWyraz(zdanie);

                Console.WriteLine("Pierwszy najdluższy: " + najdluzszy);

                string[] wyrazy = mt.ZnajdzWszystkieNajdluzszeWyrazy(zdanie);

                Console.WriteLine("Wszystkie najdłuższe: " + string.Join(", ", wyrazy));
            }
            catch (ToShortSentenseException)
            {
                Console.WriteLine("Zdanie za krótkie");
            }
            catch (Exception)
            {
                Console.WriteLine("Nieznany błąd");
            }
         

            Console.ReadKey();
        }
    }
}
