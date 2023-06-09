﻿using static System.Net.Mime.MediaTypeNames;

namespace home_6
{
    public class Clinic
    {
        /// <summary>
/*        Создать программу для имитации работы клиники. (Clinic)
Пусть в клинике будет три врача: офтальмолог(ophthalmologist), терапевт(therapist) и стоматолог(dentist).  
Каждый врач имеет метод «лечить» Treat(), но каждый врач лечит по-своему.Так же предусмотреть класс «Пациент»(Patient) и enum «IlnessType» (Eyes, Teeth, Other) - (тип болезни, что человека беспокоит)
Создать объект класса «Пациент». 
Так же создать метод в классе Клиника, который будет отправлять пациента к доктору.Далее доктор должен лечить пациента. 
Если план лечения == Eyes – назначить офтальмолога и выполнить метод лечить.  
Если план лечения == Teeth – назначить стоматолог и выполнить метод лечить.  
Если план лечения == Other – назначить терапевта и выполнить метод лечить.*/
    /// </summary>

        static void Main(string[] args)
        {
            {
                //Создаем пациентов
                Patient[] patient1 = new Patient_Builder().BuildPatient(5);
                //Выводим информацию о пациентах на экран
                Patient.PrintData(patient1);
                //Вывод информации о врачах на экран
                ManagmenClinic man = new ManagmenClinic(patient1);
                man.PrintData();
                man.TreatClinic();
                // Клиника которая умеет лечить пациентов
                


            }

        }
    }
}