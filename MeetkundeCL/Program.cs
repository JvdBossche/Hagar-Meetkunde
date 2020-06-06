using System;
using MeetkundeLogic;

namespace MeetkundeCL
{
    class Program
    {
        static void Main(string[] args)
        {
            //Quick and dirty, just to test MeetkundeLogic
            Rechthoek rh1 = new Rechthoek("RechtHoek1", 2, 3);
            Console.WriteLine($"rh1.Naam: {rh1.Naam}");
            Console.WriteLine($"rh1.Lengte: {rh1.Lengte}");
            Console.WriteLine($"rh1.Breedte: {rh1.Breedte}");
            Console.WriteLine($"rh1.Omtrek: {rh1.Omtrek}");
            Console.WriteLine($"rh1.Oppervlakte: {rh1.Oppervlakte}");
            Console.WriteLine($"rh1.ToString(): {rh1.ToString()}");
            /* I would like to now what casting does when casting to the base class, which is abstract.
            Console.WriteLine($"rh1.GetType(): {rh1.GetType()}");
            Console.WriteLine($"( (Figuur)rh1 ).ToString(): {( (Figuur)rh1 ).ToString()}");
            Figuur rh1AsFigImpl = rh1; // implicit conversion to base
            Console.WriteLine($"rh1AsFigImpl.ToString(): {rh1AsFigImpl.ToString()}");
            Console.WriteLine($"rh1AsFigImpl.GetType(): {rh1AsFigImpl.GetType()}");
            Figuur rh1AsFigExpl = (Figuur)rh1; // explicit conversion
            Console.WriteLine($"rh1AsFigExpl.ToString(): {rh1AsFigExpl.ToString()}");
            Console.WriteLine($"rh1AsFigExpl.GetType(): {rh1AsFigExpl.GetType()}");
            Conclusion: The casting itself works (causes no errors) but the object retains its child-class identity.
            */

            Parallellogram pl1 = new Parallellogram("Parallellogram1", 2, 3);
            Console.WriteLine($"pl1.Naam: {pl1.Naam}");
            Console.WriteLine($"pl1.Lengte: {pl1.Basis}");
            Console.WriteLine($"pl1.Breedte: {pl1.Hoogte}");
            Console.WriteLine($"pl1.Omtrek: {pl1.Omtrek}");
            Console.WriteLine($"pl1.Oppervlakte: {pl1.Oppervlakte}");
            Console.WriteLine($"pl1.ToString(): {pl1.ToString()}");
            Console.WriteLine($"pl1.ToString(): {pl1}");
            Console.ReadKey();

            //Nullable
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.14157;
            bool? boolval = new bool?();
            Console.WriteLine("Nullables at Show: {0}, {1}, {2}, {3}", num1, num2, num3, num4);
            Console.WriteLine("A Nullable boolean value: {0}", boolval);
            Console.ReadLine();
        }
    }
}
