using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace home_7
{
    public class Cook : Person, IEmployees
    {
        public Cook(string name, int age) : base(name, age)
        { }
        
        public void Cooking()
        {
            Console.WriteLine("I'am Cooking");
        }
        public void Cleaning()
        {
            Console.WriteLine("I'am Cleaning");
        }

        public override string ToString()
        {
            return "Order food";
        }
    }
}
