using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_6
{
    public class Ophthalmologist: Doctor
    {


        public Ophthalmologist(string name, int age, int id) : base(name, age, id, "ophthalmologist")
        {
        }

        public override void Treat()
        {
            Console.WriteLine("\tTreat as a ophthalmologist");
        }
    }
}
