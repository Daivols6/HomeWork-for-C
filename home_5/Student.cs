using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_5
{
 
    /*   1. Coздайте класс Student, в классе используйте поля Id, Name, Age, Group, MathMark(Оценка по математике от 1 до 10 включительно), PhysicalEducationMark(Оценка
 * по физкультуре от 1 до 10),
 * BiologyMark(Оценка по биологии от 1 до 10), Reward(денежное вознаграждение за хорошую учебу)*/

    public class Student
    {
        private int reward;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
        public int MathMark { get; set; }
        public int PhysicalEducationMark { get; set; }
        public int BiologyMark { get; set; }
        public int Reward
        {
            get 
            { 
                return reward;
            } 
            set 
            { 
                if (value > 0 ) 
                {
                    reward = value;
                }
                 
            }
        }



        public Student(int id, string name, int age, string group)
        {
            Id = id;
            Name = name;
            Age = age;
            Group = group;
        }

        public void PrintData()
        {
            Console.WriteLine($" Id:{Id} Name:{Name} Age:{Age} Group:{Group} BM:{BiologyMark} MM:{MathMark} PEM:{PhysicalEducationMark}");
        }


    }
}
