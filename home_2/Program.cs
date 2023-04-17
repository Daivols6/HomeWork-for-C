namespace home_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите первое число");
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
                default: Console.WriteLine("Ошибка ввода");
                break;

            }
        }
    }
}