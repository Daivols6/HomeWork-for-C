using System.Runtime.Intrinsics.X86;

namespace home_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Task1();*/
            /*Task2();*/
            Task3();
            Task4();
            Task5();
            Task6();
            Task7();
            Task8();
            Task9();

        }
        /*public static void Task1()
        {
            Random random = new Random();
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\nEnter a number to search in the array:");
            int number = Convert.ToInt32(Console.ReadLine());

            bool found = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (number == array[i])
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("The number is included in the array.");
            }
            else
            {
                Console.WriteLine("The number is not included in the array.");
            }
        }*/

/*        public static void Task2()
        {
            int[] array = new int[5];
            Random random = new Random();
            int number = Convert.ToInt32(Console.ReadLine());
            bool flag = false;
            for (int i = 0; i < 5; i++)
            {
                array[i] = random.Next(1,5);
                if (number != array[i] ) 
                {
                    Console.Write(array[i]+ " ");
                }
                else
                {
                    flag = true;
                }
            }
            if (flag == true) { Console.WriteLine("\nthere is no such number"); }

        }*/
        public static void Task3()
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            Random random = new Random();
            int[] array = new int[size];
            int max = int.MinValue;
            int min = int.MaxValue; 
            double avg = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 20);

                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }

                avg += array[i];
            }
            avg /= array.Length;
            Console.WriteLine("Максимальное значение: " + max);
            Console.WriteLine("Минимальное значение: " + min);
            Console.WriteLine("Среднее значение: " + avg);

        }
        public static void Task4()
        {
            Random random = new Random();
            int[] array = new int[5];
            double number1 = 0;
            double number2 = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
                number1 = +array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
                number2 = +array[i];
            }
            number1 = number1 / 5;
            number2 = number2 / 5;
            if (number1 == number2) { Console.WriteLine($"Equal {number1} == {number2}"); }
            else if (number1 > number2) { Console.WriteLine($"number1 = {number1} Bigger"); }
            else { Console.WriteLine($"number2 = {number2} Bigger"); }
        }
        public static void Task5()
        {
            Console.WriteLine();
        }
        public static void Task6()
        {
            Console.WriteLine();
        }
        public static void Task7()
        {
            Console.WriteLine();
        }
        public static void Task8()
        {
            Console.WriteLine();
        }
        public static void Task9()
        {
            Console.WriteLine();
        }

    }
}