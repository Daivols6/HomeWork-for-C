using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_7
{
    public class Cleaner : Person, IEmployees
    {
        public Cleaner(string name, int age) : base(name, age)
        { }
        public void Cleaning()
        {
            Console.WriteLine("I'am Cleaning");
        }
        public override string ToString()
        {
            return "Litter";
        }
    }
}
