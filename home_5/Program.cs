using System.Text.RegularExpressions;
using System;

namespace home_5
{
    internal class Program
    {
        /*        1. Coздайте класс Student, в классе используйте поля Id, Name, Age, Group, MathMark(Оценка по математике от 1 до 10 включительно), PhysicalEducationMark(Оценка 
         *        по физкультуре от 1 до 10),
         *        BiologyMark(Оценка по биологии от 1 до 10), Reward(денежное вознаграждение за хорошую учебу)
        Допустим есть 3 группы(Group1, Group2, Group3). Создайте 3 массива студентов по 5 в каждой группе.Оценки по дисциплинам задайте с использованием Random

        Создайте метод вывода в консоль студента из каждой группы с наилучшей оценкой по Математике.Если существуют студенты с одинаковыми наилучшими оценками - выведите любого из них.
        (ex: Anton, Math mark: 10)
        Создайте метод вывода в консоль студента из каждой группы с наилучшей оценкой по Физкультуре.Если существуют студенты с одинаковыми наилучшими оценками - выведите любого из них.
        Создайте метод вывода в консоль студента из каждой группы с наилучшей оценкой по Биологии. Если существуют студенты с одинаковыми наилучшими оценками - выведите любого из них.
        Установите каждому из лучших студентов выше - денежное вознаграждение в рублях - reward (rand: 0 - 100) (предусмотрите, чтобы нельзя было установить значение reward< 1 рубля)
        Создайте методы подсчета и вывода среднего балла группы студентов по каждой из дисциплин и вывода этой информации в консоль (разные методы) (ex: Group1, avarage mark math: 8.3)
        Создайте метод расчета среднего балла группы студентов по всем 3 дисциплинам(средняя оценка группы по каждой дисциплине / количество дисциплин) и выведите эту информацию в консоль.
        (Avearage mark of Group1 - Math, PhysicalEducation, Biology - 8.3)
        Добавьте каждому студенту из группы с наибольшим средним баллом по всем дисциплинам произвольный reward.
        Выведите на экран студента с наибольшим reward. Если таких студентов несколько - выведите их всех.*/
        static void Main(string[] args)
        {
            // Create Students
            Student[] groupOne = new StudentBuilder().Build(5, "McDonalds");
            Student[] groupTwo = new StudentBuilder().Build(5, "Sturbacks");
            Student[] groupThree = new StudentBuilder().Build(5, "DimCoffe");

            //Create Groups
            Group newGroup = new Group(groupOne);
            Group newGroup2 = new Group(groupTwo);
            Group newGroup3 = new Group(groupThree);

            //View Groups

            newGroup.PrintData();
            Console.WriteLine();
            newGroup2.PrintData();
            Console.WriteLine();
            newGroup3.PrintData();
            Console.WriteLine();

            //The best mark of student 
            //Rewards of the students
            //Rewards of the group

            //Group 1
            Student bestStudentMath = newGroup.GetBestStudentOfMath();
            Student bestStudentBiologi = newGroup.GetBestStudentOfBiology();
            Student bestStudentPysical = newGroup.GetBestStudentOfPhysicalEducation();
            Console.WriteLine("Math");
            bestStudentMath.PrintData();
            Console.WriteLine("Arerage Math: " + newGroup.GetAVGMath());
            Console.WriteLine("Rewards: " + Rewards.Reward(bestStudentMath));
            Console.WriteLine("\nBiology");
            bestStudentBiologi.PrintData();
            Console.WriteLine("Arerage Biology: " + newGroup.GetAVGBiology());
            Console.WriteLine("Rewards: " + Rewards.Reward(bestStudentBiologi));
            Console.WriteLine("\nPhysicalEducation");
            bestStudentPysical.PrintData();
            Console.WriteLine("Arerage PhysicalEducation: " + newGroup.GetAVGPhysical());
            Console.WriteLine("Rewards: " + Rewards.Reward(bestStudentPysical));
            
            //Group 2
            bestStudentMath = newGroup2.GetBestStudentOfMath();
            bestStudentBiologi = newGroup2.GetBestStudentOfBiology();
            bestStudentPysical = newGroup2.GetBestStudentOfPhysicalEducation();
            Console.WriteLine("Math");
            bestStudentMath.PrintData();
            Console.WriteLine("Arerage Math: " + newGroup2.GetAVGMath());
            Console.WriteLine("Rewards: " + Rewards.Reward(bestStudentMath));
            Console.WriteLine("\nBiology");
            bestStudentBiologi.PrintData();
            Console.WriteLine("Arerage Biology: " + newGroup2.GetAVGBiology());
            Console.WriteLine("Rewards: " + Rewards.Reward(bestStudentBiologi));
            Console.WriteLine("\nPhysicalEducation");
            bestStudentPysical.PrintData();
            Console.WriteLine("Arerage PhysicalEducation: " + newGroup2.GetAVGPhysical());
            Console.WriteLine("Rewards: " + Rewards.Reward(bestStudentPysical));
            
            //Group3
            bestStudentMath = newGroup3.GetBestStudentOfMath();
            bestStudentBiologi = newGroup3.GetBestStudentOfBiology();
            bestStudentPysical = newGroup3.GetBestStudentOfPhysicalEducation();
            Console.WriteLine("Math");
            bestStudentMath.PrintData();
            Console.WriteLine("Arerage Math: "+newGroup3.GetAVGMath());
            Console.WriteLine("Rewards: " + Rewards.Reward(bestStudentMath));
            Console.WriteLine("\nBiology");
            bestStudentBiologi.PrintData();
            Console.WriteLine("Arerage Biology: "+newGroup3.GetAVGBiology());
            Console.WriteLine("Rewards: " + Rewards.Reward(bestStudentBiologi));
            Console.WriteLine("\nPhysicalEducation");
            bestStudentPysical.PrintData();
            Console.WriteLine("Arerage PhysicalEducation: "+newGroup3.GetAVGPhysical());
            Console.WriteLine("Rewards: " + Rewards.Reward(bestStudentPysical));


        }
    }
}