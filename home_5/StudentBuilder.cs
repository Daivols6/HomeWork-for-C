using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_5
{
    public class StudentBuilder
    {
        private static int id = 0;
        string[] name = { "Roman", "Dimon", "Alex", "Vasya", "Masha" };
        public Student[] Build(int count, string groupname)
        {
            
            Student[] students = new Student[count];
            for (int i=0; i<count;i++)
            {
                Random random = new Random();
                int age = random.Next(18, 30);
                int mark = random.Next(1,11);
                int mark2 = random.Next(1,11);
                int mark3 = random.Next(1,11);
                int nameNumber = random.Next(0, name.Length);
                students[i] = new Student(id, name[nameNumber], age, groupname);
                students[i].BiologyMark = mark;
                students[i].PhysicalEducationMark = mark2;
                students[i].MathMark = mark3;
                id++;
            }
            return students;
        }
    }
}
