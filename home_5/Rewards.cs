using System;
using System.Collections.Generic;
using System.Linq;
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
/*        public static int BestAVGRewards(Group group)
        {

            Random random = new Random();
            int summa = random.Next(0, 100);
            student.Reward += summa;
            return summa;
        }*/
    }
}
