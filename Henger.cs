using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Henger
    {
        private double magassag;
        private double sugar;
        static private double szuletesSzamlalo;

        public Henger(double sugar, double magassag)
        {
            this.magassag = magassag;
            this.sugar = sugar;
            szuletesSzamlalo++;
        }

        public double GetMagassag
        {
            get => magassag;
        }

        public double GetSugar
        {
            get => sugar;
        }

        public static double SzuletesSzamlalo
        {
            get => szuletesSzamlalo;
        }

        

        public virtual double Terfogat()
        {
            return Math.Round(Math.Pow(sugar, 2) * Math.PI * magassag, 2);

        }

        public override string? ToString()
        {
            return $"Jellemzők >> térfogat: {Terfogat()}; sugár:{sugar}; magasság:{magassag}";
        }


    }
}