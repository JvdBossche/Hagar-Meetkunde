using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeetkundeLogic
{
    public class Cirkel : Figuur
    {
        public double Straal { get; set; }
        public override double Omtrek { get => Math.Pow(Straal, 2) * Math.PI; }

        public override double Oppervlakte => throw new NotImplementedException();
    }
}