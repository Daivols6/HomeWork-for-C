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
            int operand1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите второе число");
            int operand2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите действие: *, /, +, -");
            string sign = Console.ReadLine();
            switch (sign)
            {

                case "+": Console.WriteLine(operand1 + operand2); break;
                case "-": Console.WriteLine(operand1 - operand2); break;
                case "*": Console.WriteLine(operand1 * operand2); break;
                case "/":

                    if (operand2 == 0)
                    {
                        Console.WriteLine("Ошибка: деление на ноль невозможно.");
                    }
                    else
                    {
                        Console.WriteLine(operand1 / operand2);
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка ввода");
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
            switch (word)
            {
                case "Жарко":
                    Console.WriteLine("hot");
                    break;
                case "Холодно":
                    Console.WriteLine("cold");
                    break;
                case "Пасмурно":
                    Console.WriteLine("cloudy");
                    break;
                case "Солнечно":
                    Console.WriteLine("sunny");
                    break;
                case "Дождь":
                    Console.WriteLine("rain");
                    break;
                case "Снег":
                    Console.WriteLine("snow");
                    break;
                case "Гроза":
                    Console.WriteLine("thunderstorm");
                    break;
                case "Туман":
                    Console.WriteLine("fog");
                    break;
                case "Ветрено":
                    Console.WriteLine("windy");
                    break;
                case "Ураган":
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
