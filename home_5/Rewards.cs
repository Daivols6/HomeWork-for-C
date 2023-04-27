using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace home_5
{
    public static class Rewards
    {
        public static int Reward(Student student)
        {
            Random random = new Random();
            int summa = random.Next(0, 100);
            student.Reward+= summa;
            return summa;
        }
        public static void RewardsGroup(Group group)
        {

            foreach(var item in group.Students)
            {
                Reward(item);
            }
            
        }
        public static void MaxRewardsAll(params Group[] group)
        {
            List<Student> listStudent = new List<Student>();   
            int max = group.Max(g => g.Students.Max(r => r.Reward));
            foreach(var grup in group)
            {
                foreach (var student in grup.Students)
                {
                    if (student.Reward == max)
                    {
                        listStudent.Add(student);
                    }
                }
            }
            foreach(var student in listStudent)
            {
               student.PrintData();
            }
        }

    }
}
