using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220061
{

    public class Constructor
    {
        public string name;
        public string status;
        public int age;

        public Constructor()
        {
            this.name = "";
            this.status = "Archon";
            this.age = 0;
        }

        public Constructor(string name, string status, int age)
        {
            this.name = name;
            this.status = status;
            this.age = 100;
        }
    }
}
