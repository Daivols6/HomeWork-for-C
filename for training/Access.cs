using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_training
{
    class Access
    {
        int z = 3;
        private int x = 5;
        private int y = 73;
        public void PrintX()
        {
            Console.WriteLine($"X:{x}");
        }
        private void PrintY()
        {
            Console.WriteLine($"Y:{y}");
        }
        public void PrintPoint()
        {
            PrintX();
            PrintY();
        }
    }
}
