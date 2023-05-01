using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_6
{
   class Patient_Builder: Patient
    {


    List<string> names = new List<string> { "Roman", "Dimon", "Alex", "Vasya", "Masha", "Anna", "Vadim" };

    public Patient[] BuildPatient(int count)
    {
        Patient[] patient = new Patient[count];

        for (int i = 0; i< count; i++)
        {
            Random random = new Random();
            patient[i] = new Patient();
            int age = random.Next(18, 30);
            var name = names[random.Next(0, names.Count)];
            patient[i].name = name;
            patient[i].ilness = (IlnessType)random.Next(0, 3);


        }
        return patient;
    }

 }

}
