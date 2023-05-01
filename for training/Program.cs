namespace for_training
{
    internal class Program
    {
        enum Color
        {
            Red,
            Orange,
            Green
        }
        class Point

        {
            public Color color;
            public int x;
            public int y;
            public Guid id;



            public void PrintData(Point data)
            {
                Console.WriteLine($"Color:{data.color}, X: {data.x}, Y: {data.y}, Id: {id}");
            }
        }
        static void Main(string[] args)
        {
            /*            Point  p = new Point();
                        p.y = 10;
                        p.x = 12;
                        p.color = Color.Red;
            *//*            p.id = Guid.NewGuid();*//*

                        p.PrintData(p);

                        Point p2 = new Point();
                        p2.y = 20;
                        p2.x = 30;

                        int num = Convert.ToInt32(Console.ReadLine());  
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        double num3 = Convert.ToDouble(Console.ReadLine());
                        double num4 = Convert.ToDouble(Console.ReadLine());
                        double num5 = Convert.ToDouble(Console.ReadLine());
                        double num6 = Convert.ToDouble(Console.ReadLine());*/

            /*string num7 = Console.ReadLine();
            int numer;
            int.TryParse(num7, out numer);
            Console.WriteLine(numer*2);*/
            /*            try { 
                        double num  = double.Parse(Console.ReadLine());
                        Console.WriteLine(num + 25);
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine($"error uncorrect input");
                        }*/
            /*            int a = 0;
                        a--;
                        Console.WriteLine(a);*/

            /*            num7 = Console.ReadLine();
                        int num8 = Console.ReadLine();*/



            /*            Console.WriteLine(num+num2);
                        Console.WriteLine(num3+num4);
                        string str = "2";
                        string str2 = "5";
                        Console.WriteLine(str+str2);

                        */
            /*            int a = int.Parse(Console.ReadLine());
                        switch (a)
                        {
                            case 0:
                                Console.WriteLine($"You input: {a}");
                                break;                
                            case 1:
                                Console.WriteLine($"You input: {a}");
                                break;                
                            case 2:
                                Console.WriteLine($"You input: {a}");
                                break;                
                            case 3:
                                Console.WriteLine($"You input: {a}");
                                break;                
                            case 4:
                                Console.WriteLine($"You input: {a}");
                                break;                
                            case 5:
                                Console.WriteLine($"You input: {a}");
                                break;*/

            /*            int i = 0;

                        while (i < 5)
                        {
                            i++;
                            Console.WriteLine("Выполняем действия");
                            Console.WriteLine(i);
                        }
                        do
                        {
                            Console.WriteLine("Something");
                            i++;
                        } while (i < 7);

                    }
            */
            /*            int limit = int.Parse(Console.ReadLine());
                        for (int i = 0; i < limit+1; i++)
                        {
                            Console.WriteLine(i);
                        }*/
            /*            int i = 0;
                        for (; i<3; i++)
                        {
                            Console.WriteLine("for1 is working");

                        }            
                        for (; i<5; i++)
                        {
                            Console.WriteLine("for2 is working");

                        }*/
            /*            for (int i = int.Parse(Console.ReadLine()); i<100 ; i++)
                        {
                            if (i == 6)
                            {
                                break;
                            }
                            Console.WriteLine("for2 is working");
                            Console.WriteLine(i);*/
            /*            try
                        {
                            Console.WriteLine("Введите сумму для расчета: ");
                            double i = double.Parse(Console.ReadLine());
                            Console.WriteLine("Введите процентную ставку от 1 до 100");
                            double percent = double.Parse(Console.ReadLine());
                            percent = percent / 100;
                            double resultTax = i * percent;
                            double result = resultTax - (resultTax * 0.13);
                            double resultMonth = (resultTax - (resultTax * 0.13)) / 12;
                            Console.WriteLine($"Net за год: {result:#.00}");
                            Console.WriteLine($"Net за месяц: {resultMonth:#.00}");
                            Console.WriteLine($"Gross за год: {resultTax:#.00}");

                        }
                        catch
                        {
                            Console.WriteLine("Вы ввели фигню");
                        }
                    }*/
            /*            while (true)
                        {
                            for (int i = 1; i <= 3; i++)
                            {
                                Console.WriteLine("цикл 1 итерация:" + i);
                                for (int j = 1; j <= 5; j++)
                                {
                                    Console.WriteLine("\tЦикл 2 итерация " + j);
                                    for (int k = 1; k <=2; k++)
                                    {
                                        Console.WriteLine("\t\tЦикл 3 итерация" + k);
                                    }
                                }
                            }
                            Console.ReadLine();
                        }*/
            /*            Console.WriteLine("Введите высоту прямоугольника: ");
                        int height = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите ширину прямоугольника: ");
                        int width = int.Parse(Console.ReadLine()); 

                        for (int j = 0; j < height; j++)
                        {
                            for (int i = 0; i < width; i++)
                            {
                                Console.Write("#");

                            }
                            Console.WriteLine();
                        }
                        Console.ReadLine();*/
            // Треугольники в консоли
            /*            Console.WriteLine("Введите высоту треугольника: ");
                        int height = int.Parse(Console.ReadLine());
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j <= i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();*/
            /*            Console.WriteLine("Введите высоту треугольника: ");
                        int height = int.Parse(Console.ReadLine());
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = height; j > i; j--)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();*/
            // треугольник с отступом.  
            /*            Console.WriteLine("Введите высоту треугольника: ");
                        int height = int.Parse(Console.ReadLine());
                        for (int i = 0; i < height; i++)
                        {
                                for (int j = height; j > i; j--)
                            {
                                Console.Write(" ");
                            }
                            for (int j = 0; j <= i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
            */
            // треугольник с отступом v2  
            /*            int height = int.Parse(Console.ReadLine());
                        for (int i = 0; i < height; i++)
                        {
                            Console.SetCursorPosition(height - i, i + 1);
                            for (int j = 0; j <= i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }*/
            //Тернарный оператор
            //[первый операнд- условие]?[второй операнд if_true]:[третий операнд if_false]
            /*bool accessAllowed;

            string storePassword = "qwerty";
            string enteredPassword = Console.ReadLine();
            accessAllowed=enteredPassword==storePassword? true: false;
            Console.WriteLine(accessAllowed);
*/
            /*int inputData = int.Parse(Console.ReadLine());
            int outputData = (inputData < 0) ? 0:inputData;
            Console.WriteLine(outputData);*/
            //Массивы Одномерные массивы Тип_элементов_Массива[] имя массива;

            /*            int[] myArray;
                        myArray = new int[5];//инициализация массива. если указали такое кол-во, или не указывать в скобках.если указываем массив
                        int[] myArray2 = Enumerable.Repeat(5, 10).ToArray();
                        int[] myArray3 = Enumerable.Range(4, 5).ToArray();

                        for (int i = 0; i < myArray.Length; i++) 
                        {
                            myArray[i]= 
                        }

                        Console.ReadLine();*/
            Console.Write("Введите кол-во элементов в массиве:\t");
            int elementCount = int.Parse(Console.ReadLine()); 
            int[] myArray = new int[elementCount];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("\nВведите элемент массива: "+ i);
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Вывод массива:");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }



        }
    }
}