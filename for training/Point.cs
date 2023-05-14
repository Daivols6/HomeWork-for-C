using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace for_training
{
    class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void SetX(int x)
        {
            this.X = x;
        }
        public void SetY(int y)
        {
            if (y < 1)
            {
                this.Y = 1;
                return;
            }
            if (y > 1)
            {
                this.Y = 5;
                return;
            }
        }
        public int GetX()
        {
            return X;
        }
        private int X;
        private int Y;
        public Color color;
        public enum Color
        {
            Red,
            Green,
            Blue,
            Yellow,
            Orange
        }
        public void Print()
        {
            Console.WriteLine($"X:{X}, Y:{Y}");
        }
        private int z;

        public int Z
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }


    }
    /*internal class Class1
    {


        public static int Sum(int value_1, int value_2)
        {
            int result = value_1 + value_2;
            return result;
        }
        int a;
        public static void PrintData(int a)
        {

            Console.WriteLine("================");
            Console.WriteLine(a);
            Console.WriteLine("================");
        }

        public static void PrintLine()
        {
            string symbol;
            uint symbolCount;
            Console.WriteLine("Input symbol: ");
            symbol = Console.ReadLine();
            Console.WriteLine("Input count symbol: ");
            symbolCount =uint.Parse(Console.ReadLine()); 
            for (int i = 0; i < symbolCount; i++)
            {
                Console.Write(symbol);
            }
        }
*/
}

