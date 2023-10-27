using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class TomorHenger : Henger
    {
        private double fajsuly;

        public TomorHenger(double sugar, double magassag) : base(sugar, magassag)
        {
            this.fajsuly = 7.87;
        }

        public TomorHenger(double sugar, double magassag, double fajsuly) : base(sugar, magassag)
        {
            this.fajsuly = fajsuly;
        }

        public double GetFajsuly
        {
            get => fajsuly;
        }

        public double Suly
        {
            get => fajsuly * Terfogat();
        }

        public override string? ToString()
        {
            return $"Jellemzők >> térfogat: {Terfogat()}; sugár:{GetSugar}; magasság:{GetMagassag}; fajsúly:{fajsuly}";
        }
    }
}