using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_6
{
    public class ManagmenClinic
    {
        Doctor[] Doctors { get; set; }

        Patient[] Patients { get; set; }
        public ManagmenClinic(Patient[] patient) 
        {
            Doctors = new Doctor[] { new Dentist("Vasia", 45, 0), new Ophthalmologist("Petia", 34, 1), new Therapist("Alex", 25, 2) };
            Patients = patient;
        }
        public void PrintData()
        {
            foreach (Doctor pat in Doctors)
            {
                Console.WriteLine($"\nId: {pat.Id}, Name: {pat.Name},Age: {pat.Age}, Specialization: {pat.Specialization}\n");
            }
        }
        public void Treats(Patient patient)
        {
            if (patient.ilness == IlnessType.Teeth)
            {
                Console.WriteLine($"\n{patient.name}, you need to treat your teeth at the dentist.");
                Doctor Dantist = Doctors.First(x=> x.Specialization == "dentist");
                Dantist.Treat();
            }
            else if (patient.ilness == IlnessType.Eyes)
            {
                Console.WriteLine($"\n{patient.name}, you need to have your eyes treated by an ophthalmologist.");
                Doctor Ophthalmologist = Doctors.First(x => x.Specialization == "ophthalmologist");
                Ophthalmologist.Treat();
            }
            else
            {
                Console.WriteLine($"\n{patient.name}, you need to be treated by a therapist.");
                Doctor Therapist = Doctors.First(x => x.Specialization == "therapist");
                Therapist.Treat();
            }
        }
        public void TreatClinic()
        {
            foreach(Patient pat in Patients ) 
            {
                Treats(pat); 
            }
        }
    }
}
