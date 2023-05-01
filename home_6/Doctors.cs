using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace home_6
{
    public class Doctors
    {

        int Id { get; set; }
        string Name { get; set; }
        string Specialization { get; set; }
        int Age { get; set; }


        public Doctors(string name, int age, int id,string specialization ) 
        {
            int Id = id;
            int Age = age;
            string Name = name;
            string Specialization = specialization;
        }    

        

        public string Treat()
        {
            return Treat();   
        }
        public void PrintData()
        {
            Console.WriteLine($" Id:{Id} Name:{Name} Age: {Age} specialization: {Specialization}");
        }
    }
}
