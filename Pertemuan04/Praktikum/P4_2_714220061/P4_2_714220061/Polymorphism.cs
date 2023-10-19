using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220061
{
    class Polymorphism
    {
        public virtual void Teyvat()
        {
            Console.WriteLine("Ini adalah virtual world Teyvat");
        }
    }

    class archons: Polymorphism
    {
        public override void Teyvat()
        {
            Console.WriteLine("Creating The Seven Archon");
        }
    }

    class sovereign: Polymorphism
    {
        public override void Teyvat()
        {
            Console.WriteLine("Calling The Seven Sovereign");
        }
    }
}
