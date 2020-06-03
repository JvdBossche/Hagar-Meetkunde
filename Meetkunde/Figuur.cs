using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetkundeLogic
{
    public abstract class Figuur
    {
        public string Naam { get; set; } //concrete (not abstract) proprty, without a field, without explicit bodies for get and set (a.k.a. "auto property")
        public abstract double Omtrek { get; } //abstract property, without a field
        public abstract double Oppervlakte { get; } //abstract property, without a field
        public override string ToString()
        {
            return Naam.ToUpper();
        }
    }
}
