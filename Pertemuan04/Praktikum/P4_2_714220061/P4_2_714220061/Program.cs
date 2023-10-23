using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220061
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Constructor ava1 = new Constructor()
            {
                name = "Raiden Shogun",
                age = 400
            };
            Console.WriteLine(ava1.name);
            Console.WriteLine(ava1.status);
            Console.WriteLine(ava1.age);
            Console.WriteLine();

            //constructor
            Console.WriteLine("Constructor:");
            Constructor ava2 = new Constructor("Neuvillette", "7 Sovereign", 6000);
            Console.WriteLine(ava2.name);
            Console.WriteLine(ava2.status);
            Console.WriteLine(ava2.age);
            Console.WriteLine();

            //field & property
            Console.WriteLine("Field & Property:");
            charProperty Furina = new charProperty();
            Furina.Element = "Hydro";
            Console.WriteLine("Furina Element: {0}", Furina.Element);
            Console.WriteLine();

            //inheritance
            Console.WriteLine("Inheritance:");
            Murata himeko = new Murata();
            Console.WriteLine("Affiliation: {0}", himeko.affiliation);
            Console.WriteLine("The {0}th member", himeko.member);
            Console.Write("Originally from ");
            himeko.Region();
            Console.WriteLine();

            //Polymorphism
            Console.WriteLine("Polymorphism:");
            Polymorphism tsaritsa = new archons();
            tsaritsa.Teyvat();

            Polymorphism nibelung = new sovereign();
            nibelung.Teyvat();
        }
    }
}
