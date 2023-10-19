using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220061
{
    public class Inheritance
    {
        public string affiliation {  get; set; }
        public int member {  get; set; }
    }

    class Murata: Inheritance
    {
        public Murata()
        {
            affiliation = "The Seven";
            member = 6;
        }

        public void Region()
        {
            Console.WriteLine("Natlan");
        }
    }
}
