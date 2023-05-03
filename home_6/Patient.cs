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
           Patient
        }
        public void PrintData(Patient patient1)
        {
            Console.WriteLine($"{patient1.id},{patient1.name},{patient1.ilness}");
        }

        public static void Treats(Patient patient)
        {
            if (patient.ilness == IlnessType.Teeth)
            {
                Console.WriteLine($"{patient.name}, you need to treat your teeth at the dentist.");
                var doctor = new dentist();
                doctor.Treat();
            }
            else if (patient.ilness == IlnessType.Eyes)
            {
                Console.WriteLine($"{patient.name}, you need to have your eyes treated by an ophthalmologist.");
                var doctor = new ophthalmologist();
                doctor.Treat();
            }
            else
            {
                Console.WriteLine($"{patient.name}, you need to be treated by a therapist.");
                var doctor = new therapist();
                doctor.Treat();
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