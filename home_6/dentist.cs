using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_6
{
    public class Dentist : Doctor
    {


        public Dentist(string name, int age, int id) : base(name, age, id, "dentist")
        {
        }

        public override void Treat()
        {
            Console.WriteLine("\tTreat as a dentist");
        }
    }
}
