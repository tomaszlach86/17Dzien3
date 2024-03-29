﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P08KonstruktoryPogoda
{
    internal class ManagerPogody
    {
       // public string PolePubliczne;

        private const string znakKoncowy = ">";
        private const string adres = "https://www.google.com/search?q=pogoda";

        private string jednostka;
        private string szukanyZnak;

        public ManagerPogody(string jednostka, string szukanyZnak)
        {
            this.jednostka = jednostka;
            this.szukanyZnak = szukanyZnak;
        }


        public string Jednostka
        {
            get
            {
                return jednostka;
            }
            set
            {
                jednostka = value;
            }
        }
        //  public string Jednostka { get; set; }
      
        // public string SzukanyZnak  { get; set; }

        private double TransformujTemeprature(double temp)
        {
            if (jednostka == "c")
                return temp;

            if(jednostka == "f")
                return (temp *1.8)+32;


            if (jednostka == "k")
                return temp + 273.15;

            throw new Exception("Nieznana jednostka");
        }

        public double PodajTemperature(string miasto)
        {
           // adres = "www.yahoo.com";

            WebClient wc = new WebClient();
            string dane = wc.DownloadString(adres + "+" + miasto);

            int indx = dane.IndexOf(szukanyZnak);
            int aktuanaPozycja = indx;

            while (dane.Substring(aktuanaPozycja, 1) != znakKoncowy)
                aktuanaPozycja--;

            string wynik = dane.Substring(aktuanaPozycja + 1, indx - aktuanaPozycja + 1);

            double wynikInt = Convert.ToInt32(wynik.Substring(0,wynik.Length-2));

            return TransformujTemeprature(wynikInt);
        }
    }
}
