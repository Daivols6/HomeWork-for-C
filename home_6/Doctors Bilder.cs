using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace home_6
{

    public class Doctors_Bilder
    {

        public static int id = 0;
        string[] names = { "Roman", "Dimon", "Alex", "Vasya", "Masha", "Anna", "Vadim" };
        string[] specializations = { "ophthalmologist", "therapist", "dentist" };
        public Doctors[] BuildDoc(int count) 
        { 
        Doctors[] doctors = new Doctors[count];
           
            for (int i=0; i<count; i++)
            {
                Random random = new Random();
                int age = random.Next(18, 30);
               var name = names[random.Next(0, names.Length)];
               var specialization = specializations [random.Next(0,specializations.Length)];
                int id = i;
/*                doctors[i] = new Doctors(name, age, id, specialization);*/
            }
            return doctors;
        }
    }
}
