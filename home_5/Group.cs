using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_5
{
    public class Group //Название класса = Конструктор сам конструктор принимает переменную, которую потом присваивает. 1 слово тип данных
        //второе имя обьекта, которое будешь использовать. 
    {
        public Student[] Students { get; set; }
        public Group(Student[] students)
        { 
            Students = students; 
        } 
        public void PrintData()
        {
            foreach (Student s in Students)
            {
                s.PrintData();
            }
        }
        public Student GetBestStudentOfMath()
        {
            int maxValueMathMark = Students[0].MathMark;
            Student student = Students[0];

            foreach (Student s in Students)
            {
                if (maxValueMathMark < s.MathMark)
                {
                    maxValueMathMark = s.MathMark;
                    student = s;
                }
                
            }
            return student;
        }
        public Student GetBestStudentOfBiology()
        {
            int maxValueMathMark = Students[0].BiologyMark;
            Student student = Students[0];

            foreach (Student s in Students)
            {
                if (maxValueMathMark < s.BiologyMark)
                {
                    maxValueMathMark = s.BiologyMark;
                    student = s;
                }

            }
            return student;
        }
        public Student GetBestStudentOfPhysicalEducation()
        {
            int maxValueMathMark = Students[0].PhysicalEducationMark;
            Student student = Students[0];

            foreach (Student s in Students)
            {
                if (maxValueMathMark < s.PhysicalEducationMark)
                {
                    maxValueMathMark = s.PhysicalEducationMark;
                    student = s;
                }

            }
            return student;
        }
        public double GetAVGBiology()
        {
            double mark = 0;
            

            foreach (Student s in Students)
            {
                mark += s.BiologyMark;

            }
            return mark / Students.Length;
        }

        public double GetAVGPhysical()
        {
            double mark = 0;


            foreach (Student s in Students)
            {
                mark += s.PhysicalEducationMark;

            }
            return mark / Students.Length;
        }

        public double GetAVGMath()
        {
            double mark = 0;


            foreach (Student s in Students)
            {
                mark += s.MathMark;

            }
            return mark / Students.Length;
        }
        public double GetAVGall()
        {
            double mark = 0;

            mark += GetAVGBiology();
            mark += GetAVGPhysical();
            mark += GetAVGMath();   

            return mark / 3;
        }
        public static Group PrintAndGetAVGGroup(Group newGroup, Group newGroup2, Group newGroup3)
        {
            double groupOneAvg = newGroup.GetAVGall();
            double groupTwoAvg = newGroup2.GetAVGall();
            double groupTrheeAvg = newGroup3.GetAVGall();
            double maxAVG;
            Group maxAVGgrop;
            if (groupOneAvg > groupTwoAvg && groupOneAvg > groupTrheeAvg)
            {
                maxAVGgrop = newGroup;
                maxAVG = groupOneAvg;
            }
            else if (groupTwoAvg > groupTrheeAvg)
            {
                maxAVGgrop = newGroup2;
                maxAVG = groupTwoAvg;
            }
            else
            {
                maxAVGgrop = newGroup3;
                maxAVG = groupTrheeAvg;
            }
            Console.WriteLine($"Avearage mark of {maxAVGgrop.Students[0].Group} - Math, PhysicalEducation, Biology - {maxAVG:0.##}");
            return maxAVGgrop;
        }
    }
}
