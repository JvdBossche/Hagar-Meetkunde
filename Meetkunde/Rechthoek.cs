using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MeetkundeLogic
{
    public class Rechthoek : Figuur
    {
        //properties
        public double Lengte { get; set; }
        public double Breedte { get; set; }
        public override double Omtrek { get => 2 * (Lengte + Breedte); }
        public override double Oppervlakte { get => Lengte * Breedte; }

        //constructors
        public Rechthoek(string naam, double lengte, double breedte)
        {
            Naam = naam;
            Lengte = lengte;
            Breedte = breedte;
        }
        public Rechthoek(string naam) : this(naam, 1, 1) { }
        public Rechthoek(double lengte, double breedte) : this("", lengte, breedte) { }
        public Rechthoek() : this("", 1, 1) { }

        //methods
        public override string ToString()
        {
            return $"Rechthoek {base.ToString()}: {Lengte} x {Breedte} ";
        }
    }
}
