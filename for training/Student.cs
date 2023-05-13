using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_training
{
     class Student
    {
        
        
            public Guid id;
            public string FirstName;
            public string LastName;
            public string MiddleName;
            public int age;
            public string group;

            public static Student GetStudent()
            {
                Student student = new Student();
                student.id = Guid.NewGuid();
                student.FirstName = "Roman";
                student.LastName = "Hamster";
                student.MiddleName = "Alexandrov";
                student.age = 24;
                student.group = "ffffqqqeee";
                return student;
            }
            public static void PrintData(Student student)
            {
                Console.WriteLine($"Id:{student.id}\nFirstName:{student.FirstName}\nLastName:{student.LastName}\nMiddleName:{student.MiddleName}\nAge:{student.age}\nGroup:{student.group}\n");
            }
        public string GetFullNameP()
        {
            return $"{LastName} {FirstName} {MiddleName}";
        }

            /* public static int IndexOf(int[] array, int value)
             {

                     for(int i=0; i < array.Length; i++)
                     {
                         if (array[i] == value)
                         {
                             return i;
                         Console.WriteLine(i);
                     }
                     }
                     return -1;

             }
             public static int[] GetRandomArray(uint length, int minValue, int maxValue) 
             { 
                 int[] myArray = new int[length];
                 Random r = new Random();
                 for (int i = 0; i < length; i++)
                 {
                     myArray[i] = r.Next(minValue,maxValue);
                 }
                 return myArray;
             }
             /// <summary>
             /// Возвращает 1-е совпадающее строковое значение.
             /// </summary>
             /// <param name="array"></param>
             /// <param name="value"></param>
             /// <returns></returns>
             public static int IndexOf(string[] array, string value)
             {

                 for (int i = 0; i < array.Length; i++)
                 {
                     if (array[i] == value)
                     {
                         return i;

                     }
                 }
                 return -1;
     */
        }

}

