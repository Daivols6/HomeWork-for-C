using System.Text;
using System.Text.RegularExpressions;

namespace home_4
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();*/
            Task6();
        }
        public static void Task1()
        //Summary
        //Задать строку содержащую внутри цифры и несколько повторений слова test,
        //Заменить в строке все вхождения 'test' на 'testing'.
        //Summary
        {
            string line = "test 141 123 test 14124";
            string newline = line.Replace("test", "testing");
            Console.WriteLine(newline);

        }
        public static void Task2()
        /*Summary
        Создайте переменные, которые будут хранить следующие слова: (Welcome, to, the, TMS, lessons)выполните конкатенацию слов
        и выведите на экран следующую фразу: Welcome to the TMS lessons. 
        Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome". Не забывайте о пробелах после каждого слова
        Summary*/
        {
            string word1 = "Welcome";
            string word2 = "to";
            string word3 = "the";
            string word4 = "TMS";
            string word5 = "lessons";

            string newstring = ($"\"{word1}\" \"{word2}\" \"{word3}\" \"{word4}\" \"{word5}\"");

            Console.WriteLine(newstring);
        }
        public static void Task3()
        /*Summary
        Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter.
        Необходимо найти в данной строке "abc", записав всё что до этих символов в переменную firstPart,
        а также всё, что после них во вторую secondPart. 
        Результат вывести в консоль. 
        Summary*/
        {

            string inputString = "teamwithsomeofexcersicesabcwanttomakeitbetter.";
            string searchStr = "abc";
            string firstPart = inputString.Substring(0, inputString.IndexOf(searchStr));
            string secondPart = inputString.Substring(inputString.IndexOf(searchStr) + searchStr.Length);
            Console.WriteLine("First Part: " + firstPart);
            Console.WriteLine("Second Part: " + secondPart);
        }
        public static void Task4()
        /*Summary
        Дана строка: Good day 
        Необходимо с помощью метода substring удалить слово "Good".
        После чего необходимо используя команду insert создать строку со значением: The best day!!!!!!!!!.
        Заменить последний "!" на "?" и вывести результат на консоль. 
        Summary*/
        {
            string inputString = "Good day";
            string searchStr = "day";
            string value = "The best";
            string value2 = "!!!!!!!!!";

            string newstring = inputString.Substring(4);

            string newstring2 = newstring.Insert(0, value);

            string newstring3 = newstring2.Insert(newstring2.Length, value2);

            string newstring4 = newstring3.Insert(newstring3.Length, "?");

            Console.WriteLine(newstring4);
        }
        public static void Task5()
        /*Summary
        Введите с консоли строку, которая будет содержать буквы и цифры.
        Удалите из исходной строки все цифры и выведите их на экран.
        (Использовать метод Char.IsDigit(), его не разбирали на уроке, посмотрите,
        пожалуйста, документацию этого метода самостоятельно)
        Summary*/
        {
            string inputString = Console.ReadLine();
            string resultout = "";
            string deletchar = "";
            foreach (char i in inputString)
            {
                if (Char.IsDigit(i))
                {
                    resultout += i;
                }
                else
                {
                    deletchar += i;
                }
            }
            Console.WriteLine(deletchar);
            Console.WriteLine(resultout);
            {

            }
        }
        public static void Task6()
        /*Summary
        Задайте 2 предложения из консоли.
        Для каждого слова первого предложения
        определите количество его вхождений во второе предложение.
        Summary*/
        {
            string inputString = Console.ReadLine();
            string inputStringTwo = Console.ReadLine();
            string[] word = inputString.Split(new char[] { ' ' });
            foreach (string i in word)
            {
                int count = Regex.Matches(inputStringTwo, i).Count;
                Console.WriteLine($"Слово '{i}' входит в строку '{inputStringTwo}' {count} раз)");
            }
        }
    } 
}