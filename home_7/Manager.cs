using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static home_7.Client;

namespace home_7
{
    public class Manager : Person, IEmployees
    {
        public Manager(string name, int age) : base(name, age)
        { }
        public void SolvingConflicts()
        {
            Console.WriteLine("I'am SolvingConflicts");
        }
        public void ManageStaff()
        {
            Console.WriteLine("I Manage Staff");
        }
        public void Cooking()
        {
            Console.WriteLine("I'am Cooking");
        }
        public override string ToString()
        {
            return "Swear";
        }
    }
}
