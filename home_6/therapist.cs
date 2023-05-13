using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_6
{
    public class Therapist : Doctor
    {
        public Therapist(string name, int age, int id) : base(name, age, id, "therapist")
        {
         
        }

        public override void Treat()
        {
            Console.WriteLine("\tTreat as a therapist");
        }
    }
}
