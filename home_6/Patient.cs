using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_6
{
    public class Patient
    {
        public string name;
        public int id;
        public IlnessType ilness;
        
        public Patient() 
        {
           
        }
        public void PrintData(Patient patient1)
        {
            Console.WriteLine($"{patient1.id},{patient1.name},{patient1.ilness}");
        }


        public static void PrintData(Patient[] patient1)
        {
            foreach (Patient pat in patient1)
            {
                Console.WriteLine($"{pat.id}, {pat.name}, {pat.ilness}\n");
            }
        }

    }
    public enum IlnessType
    {
        Other,
        Teeth,
        Eyes
    }

}