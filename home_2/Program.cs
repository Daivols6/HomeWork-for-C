using System.Security.Cryptography.X509Certificates;

namespace home_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();

        }
        public static void Task1()
        {
            Console.WriteLine("Task 1 Please input number");
            double operand1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input number");
            double operand2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("select sign *, /, +, -");
            string sign = Console.ReadLine();
            switch (sign)
            {

                case "+": Console.WriteLine(operand1 + operand2); break;
                case "-": Console.WriteLine(operand1 - operand2); break;
                case "*": Console.WriteLine(operand1 * operand2); break;
                case "/":

                    if (operand2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not possible.");
                    }
                    else
                    {
                        Console.WriteLine(operand1 / operand2);
                    }
                    break;
                default:
                    Console.WriteLine("Input Error");
                    break;
            }
        }
        public static void Task2()
        {
            /*   Задание 2

   Напишите программу определения, попадает ли указанное пользователем число от 0 до 100 в числовой промежуток[0 - 14][15 - 35][36 - 50][51 - 100].
   Если да, то укажите, в какой именно промежуток.
   Если пользователь указывает число, не входящее ни в один из имеющихся числовых промежутков, то выводится соответствующее сообщение.*/
            Console.WriteLine("Task 2 Please input number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 1 && number <= 14)
            {
                Console.WriteLine("[1 - 14]");
            }
            else if (number >= 15 && number <= 35)
            {
                Console.WriteLine("[15 - 35]");
            }
            else if (number >= 36 && number <= 50)
            {
                Console.WriteLine("[36 - 50]");
            }
            else if (number >= 51 && number <= 100)
                Console.WriteLine("[51 - 100]");
            else
            {
                Console.WriteLine("Number is outside the range");
            }






        }
        public static void Task3()
        {
            /*            
            Напишите программу русско - английский переводчик.
            Программа знает 10 слов о погоде.
            Требуется, чтобы пользователь вводил слово на русском языке, а программа давала ему перевод этого слова на английском языке.
            Если пользователь ввел слово, для которого отсутствует перевод, то следует вывести сообщение, что такого слова нет.*/
            Console.WriteLine("Task 3 Please input Word (for example Холодно, Жарко и тд.) ");
            string word;
            word = Console.ReadLine();
            word = word.ToLower();
            switch (word)
            {
                case "жарко":
                    Console.WriteLine("hot");
                    break;
                case "холодно":
                    Console.WriteLine("cold");
                    break;
                case "пасмурно":
                    Console.WriteLine("cloudy");
                    break;
                case "солнечно":
                    Console.WriteLine("sunny");
                    break;
                case "дождь":
                    Console.WriteLine("rain");
                    break;
                case "снег":
                    Console.WriteLine("snow");
                    break;
                case "гроза":
                    Console.WriteLine("thunderstorm");
                    break;
                case "туман":
                    Console.WriteLine("fog");
                    break;
                case "ветрено":
                    Console.WriteLine("windy");
                    break;
                case "ураган":
                    Console.WriteLine("hurricane");
                    break;
                default:
                    Console.WriteLine("Unfortunately, I'm not that smart yet.");
                    break;
            }

        }
        public static void Task4()
        {
            /*
Напишите программу, которая будет выполнять проверку чисел на четность.   */
            Console.WriteLine("Task 4 Please input number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0) { Console.WriteLine("Even"); }
            else { Console.WriteLine("Odd"); }
        }
    }
}
