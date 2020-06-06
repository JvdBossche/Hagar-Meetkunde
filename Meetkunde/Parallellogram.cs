using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeetkundeLogic
{
    public class Parallellogram : Figuur
    {
        //properties
        public double Basis { get; set; }
        public double Hoogte { get; set; }

        public override double Omtrek { get => 2 * (Basis + Hoogte); }

        public override double Oppervlakte { get => Basis * Hoogte; }

        //constructors
        public Parallellogram(string naam, double basis, double hoogte)
        {
            Naam = naam;
            Basis = basis;
            Hoogte = hoogte;
        }

        public Parallellogram(double basis, double hoogte) : this("", basis, hoogte) { }

        public Parallellogram(string naam) : this(naam, 1, 1) { }

        public Parallellogram() : this("", 1, 1) { }

        //methods
        public override string ToString()
        {
            return $"Parallellogram {base.ToString()}: {Basis} x {Hoogte} ";
        }
    }
}