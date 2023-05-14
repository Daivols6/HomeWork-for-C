using System.Drawing;
using System.Globalization;

namespace for_training
{
    public class Program
    {
        /*        enum Color
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
        */
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
        /*      Console.Write("Введите кол-во элементов в массиве:\t");
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
              }*/
        //Обратный перебор массива

        /*            int[] myArray = new int[] {2,43,3,243,1,3,53,6,25,73,22 };
                    for (int i = myArray.Length - 1; i >= 0  ; i--)
                    {
                        Console.WriteLine(myArray[i]);
                    }*/
        // Сумма всех четных чисел массива.

        /*            int[] myArray = new int[] { 2, 43, 3, 243, 1, 3, 53, 6, 25, 73, 22 };

                    int result = 0;
                    for (int i = 0; i < myArray.Length; i++)
                    {
                        if (myArray[i] % 2 == 0)
                        {
                            result += myArray[i];
                        }
                    }
                    Console.WriteLine(result);

                    Console.ReadLine();*/
        //Наименьшее число в массиве
        /*            int[] myArray = new int[] { 2, 43, 3, 243, 1, 3, 53, 6, 25, 73, 22 };
                    int minValue = myArray[0];
                    for (int i = 1; i < myArray.Length; i++)
                    {
                        if (myArray[i] < minValue)
                        {
                            minValue = myArray[i];
                        }

                    }
                    Console.WriteLine(minValue);*/
        //LINQ 
        /*            int[] myArray = new int[] { 2, 43, 3, 243, 1, 3, 53, 6, 25, 73, 22,3,43,25 };
                    int max = myArray.Max();
                    int min = myArray.Min();
                    double avg = myArray.Average();
                    //минимальное число в массиве
                    Console.WriteLine(min);
                    //максимальное число в массиве
                    Console.WriteLine(max);
                    //Среднее число в массиве
                    Console.WriteLine($"{avg:.##}");
                    //Посчитать сумму четных элементов в массиве
                    Console.WriteLine(myArray.Where(i => i % 2 == 0).Sum());
                    // Уникальные значение массива
                    int[] result = myArray.Distinct().ToArray();
                    // Отсортировать список в порядк возрастания
                    int[] result1 = myArray.OrderBy(i => i).ToArray();
                    // Отсортировать список в порядке убывания
                    int[] result2 = myArray.OrderByDescending(i => i).ToArray();
                    Array.Sort(myArray);

                    */
        /*            //Поиск по массиву, с условием в данном случае больше 70-ти c начала массива и с конца;
                    int[] myArray = new int[] { 2, 43, 3, 243, 1, 3, 53, 6, 25, 73, 22, 3, 43, 25 };
                    int result = Array.Find(myArray, i => i > 70);
                    int result1 = Array.FindLast(myArray, i => i > 70);
                    // найти все элементы в массиве, соответствующие текущей логике
                    int[] result2 = Array.FindAll(myArray, i => i > 70);
                    //поменять порядок массива 
                    Array.Reverse(myArray);
                    // сортировка
                    Array.Sort(myArray);
                    //очистить 
                   *//* Array.Clear(myArray);*//*
                   //число меньше 70
                    int result3 = myArray.Where(i=> i < 70).First();
                    //если нет в списке, возвращает дефолт. 
                    int result4 = myArray.Where(i=> i < 0).FirstOrDefault();

                    Console.WriteLine(result);
                    Console.WriteLine(result1);
                    Console.WriteLine(result3);
                    Console.WriteLine(result4);
        */
        //Индексы и диапазоны
        /*
                    int[] myArray = new int[] { 2, 43, 3, 243, 1, 3, 53, 6, 25, 73, 22, 3, 43, 25 };
                    //Извлечь массив с какого элемента по какой[4..5],[..5]
                    int[] myArray2 = myArray[5..];
                    Index myIndex = ^5;// new Index(5,true) вариант записи
                    Range myRange = 1..4;// new Range(1,4);
                    int[] myArray3 = myArray[myRange];
                    //Поиск элемента с конца

                    Console.WriteLine(myArray[myIndex]);
                    Console.WriteLine($"value {myIndex.Value} isFormEnd {myIndex.IsFromEnd}");*/
        //Выбрать из строки элементы с.. по..
        /*            string str = "Hello World !!! =)";
                    Console.WriteLine(str[6..11]);*/
        //двумерный массив 
        //Тип данных[,] имя массива
        //Вывод массива в строку
        /*  foreach (var i in integer) 
          {
              Console.Write(i + " ");
          }

          //вывод данных из массива
          Console.WriteLine(integer[2,3]);
        //сколько измерений содержит
          Console.WriteLine(integer.Rank);

         */
        /*//Вывод в массива на консоль с табуляцией
        int[,] integer;
        integer = new int[,]
        {
            {1, 2, 3, 4,5},
            {5, 6, 7, 8,9},
            {9, 10, 11, 12,13},
            {13,14, 15, 16,17}
        };
        int height = integer.GetLength(0);
        int width = integer.GetLength(1);
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                Console.Write(integer[y,x]+"\t");
            }
            Console.WriteLine();
        }*/

        //Автозаполнение массива
        /*int[,] integer;
        integer = new int[10, 6];

        Random random = new Random();

        for (int y = 0; y < integer.GetLength(0); y++)
        {
            for (int x = 0; x < integer.GetLength(1); x++)
            {
                integer[y, x] = random.Next(0,255);
            }
        }


        for (int y = 0; y < integer.GetLength(0); y++)
        {
            for (int x = 0; x < integer.GetLength(1); x++)
            {
                Console.Write(integer[y, x] + "\t");
            }
            Console.WriteLine();
        }

        */
        /*            Ввод данных для массива с консоли.
         *            int[,] integer;
                    integer = new int[2, 3];



                   for (int y = 0; y < integer.GetLength(0); y++)
                    {
                        for (int x = 0; x < integer.GetLength(1); x++)
                        {
                            Console.WriteLine($"Y: {y} X: {x}");
                            integer[y, x] = int.Parse(Console.ReadLine());
                        }
                    }


                    for (int y = 0; y < integer.GetLength(0); y++)
                    {
                        for (int x = 0; x < integer.GetLength(1); x++)
                        {
                            Console.Write(integer[y, x] + "\t");
                        }
                        Console.WriteLine();
                    }*/
        /*            int[][] myArray = new int[3][];
                    int[,] myArray2 = new int[3, 5];

                    int myArrayRank = myArray.Rank;
                    int myArrayRank2 = myArray2.Rank;

                    int myArrayLenth = myArray.Length;
                    int myArrayLenth2 = myArray2.Length;
                    Console.WriteLine(myArrayLenth);
                    Console.WriteLine(myArrayRank);
                    Console.WriteLine(myArrayRank2);
                    Console.WriteLine(myArrayLenth2);

        */

        /*
                    int a, b, c;
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    c = Class1.Sum(a,b);
                    Class1.PrintData(c);*/
        /*            Class1.PrintChar();*/

        /*            Class1.PrintLine();*/
        /*            int[] myArray = Class2.GetRandomArray(10, 33, 39);
                    foreach (int i in myArray) { Console.Write($"{i}\n"); }
                   int x =  Class2.IndexOf(myArray, 34);
                    Console.WriteLine(x);*/
        /*Console.WriteLine();
        Class2.IndexOf()*/

        //Области видимости, конфликты областей видимости открывающиеся и закрывающиеся фигурные скобки это область видимости.{}
        /*            int a = 2;
                    for (int i = 0; i < 10; i++)
                    {
                        i++;
                        a++;
                    }
                    a++;*/
        //Конфликт областей видимости не можем создать 2 одинаковые переменные с одним и тем же названием, 

        //Сылочные(reference types) значимые типы(value types) стек(stack) потока и управляемая куча(heap)
        //области оперативной памяти стек маленький обьем, куча большой обьем оперативной памяти. дефолтное значение для стека 1МБ.
        //Используется для выполнения логики нашей программы. мало но быстро
        //Heap - склад оперативной памяти. много но медленно

        // что такое Null- объединения ??
        //возможность установки дефолтного значения для классов
        /*            string str = "Test";
                    string result = str ?? string.Empty;
                    Console.WriteLine("Количество символов в строке "+result.Length);

                    Console.WriteLine(str ?? "нет данных");*/



        //Оператор присваивания со значением NULL??=
        /*string str = null;
        str ??= "default string";
        Console.WriteLine("количество символов в строке " + str.Length) ; */
        /*static int[] GetArray()
        {
            int[] myArray =null;
            return myArray;
        }

        int[] myArray = GetArray();
        myArray ??= new int[0];
        Console.WriteLine("количество элементов в массиве " + myArray.Length) ;*/

        /*            static int[] GetArray()
                    {
                        int[] myArray = {1,2,3};
                        return myArray;
                    }

                    int[] myArray = GetArray();
                    myArray ??= new int[0];
                    Console.WriteLine("сумма элементов в массиве " + myArray.Sum()) ; */
        /*            static int[] GetArray()
                    {
                        int[] myArray = null;
                        return myArray;
                    }

                    int[] myArray = GetArray();

                    Console.WriteLine("сумма элементов в массиве " + (myArray?.Sum()??0)) ;*/
        /*static int[] GetArray()
        {
            int[] myArray = null;
            return myArray;
        }

        int[] myArray = GetArray();

        Console.WriteLine("сумма элементов в массиве " + (myArray?.Sum()??0)) ;*/
        // Ref ссылочные типы ключевое слово ref

        /*            static void Foo(ref int a)
                    {
                        a = -5;
                    }

                    int a = 2;
                    Foo(ref a);
                    Console.WriteLine(a); */
        // Метод Resize изменяющий кол-во элементов массива(метод должен иметь возможность увеличить или уменьшить кол-во элементов массива.)
        /*            static void Resize<T>(ref T[] arr, int count)
                    {
                        T[] newArr = new T[count];
                        for (int i = 0; i < arr.Length && i<newArr.Length; i++)
                        {
                            newArr[i] = arr[i];
                        }
                        arr = newArr;

                    }
                    int[] arr2 = new int[2];
                    Resize(ref arr2, 7);*/
        //Метод для добавления элемента в начало массива, в конец массива, и по указанному индексу
        /*
                    static void Add<T>(ref T[] arr, T value)
                    {
                        arr[0] = value;
                    }
                    static void AddEnd<T>(ref T[] arr, T value)
                    {
                        arr.Append(value);
                    }
                    //Написать метод для удаления первого элемента массива, последнего элемента массива и элемента по указанному индексу
                    static void RemoveElement(ref int[] arr)
                    {

                    }
                    *//*            string[] MyArray = { "test","null"};
                                Resize(ref MyArray, 10);*//*
                    static void Insert<T>(ref T[] arr, T value, int index)
                    {
                        T[] newArray = new T[arr.Length + 1];
                        newArray[index] = value;
                        for (int i = 0; i < index && i < arr.Length; i++)
                        {
                            newArray[i] = arr[i];
                        }
                        for (int i = index; i < arr.Length; i++)
                        {
                            newArray[i + 1] = arr[i];
                        }
                        arr = newArray;
                   }
                    static void AddFirst<T>(ref T[] arr, T value)
                    {
                        Insert<T>(ref arr, value, 0);
                    }
                    static void AddLast<T>(ref T[] arr, T value)
                    {
                        Insert<T>(ref arr, value, arr.Length);
                    }

                    int[] MyArray = { 3, 4, 5, 6 };
                    Insert(ref MyArray, 9, 2);
                    AddFirst(ref MyArray, 33);
                    AddLast(ref MyArray, 234);*/
        /*
        static void RemoveIndex<T>(ref T[] array, int index)
        {
            T[]newArray = new T[array.Length-1];
            for (int i = 0; i < index; i++)
                newArray[i] = array[i];
            for (int i = index+1;i < array.Length; i++)
                newArray[i-1] = array[i];
            array=newArray;
        }
        static void RemoveFirstElement<T>(ref T[] array)
        {
            RemoveIndex(ref array, 0);
        }            
        static void RemoveLastElement<T>(ref T[] array)
        {
            RemoveIndex(ref array, array.Length-1);
        }

        int[] MyArray = { 3, 4, 5, 6 };
        RemoveIndex(ref MyArray, 0);
        RemoveFirstElement(ref MyArray);
        RemoveLastElement(ref MyArray);*/

        // какая разница между ключевым словом out и ref
        //разница между ref & out 

        /*            static void Foo(ref int value)
                    {

                        value++;
                        Console.WriteLine(value);
                    }
                    static void Bar(out int value)
                    {
                        value = 5;
                        Console.WriteLine(value);
                    }

                    int a = 10;
                    Foo(ref a);
                    Bar(out a);
                    string str = Console.ReadLine();
                    int.TryParse(str, out int result);
                    Console.WriteLine(result);*/

        //ключевое слово in
        /*struct Pint*/
        /*{
            public float x;
            public float y;
            public float z;
        }*/






        /*            static void Foo(in int value)
                    {
                        Console.WriteLine(value);
                        *//*value = 5;*//*
                    }
                    static void Foo1(Pint value)
                    {

                    }
                    static void Foo2(in Pint value)
                    {

                    }

                    Pint a = new Pint();
                    a.y = 1;
                    a.x = 2;
                    a.z = 3;
                    Foo1(a);
                    Foo2(a);*/
        // ключевое слово params
        /*            static int Sum(params int[] parameters)
                    {
                        int result = 0;
                        for (int i = 0; i < parameters.Length; i++)
                        {
                           result += parameters[i];
                        }
                        return result;
                    }

                    int result= Sum(5,10,15,20);
                    Console.WriteLine(result);
        */
        /* static void Foo(params object[] parameters) 
             {
                 string messege = "Тип данных{0}, значение {1}";
                 foreach (var item in parameters)
                 {
                     Console.WriteLine(messege, item.GetType(), item);
                 }
             }
             Foo("test", 5, 'q', 5.32, true);*/

        //Необязательные параметры методов Должны быть в конце списка.
        /*            static int Sum(int a,int b, bool enableLoggig = false, int c =55)
                    {
                        int result = a + b;
                        if (enableLoggig)
                        {
                            Console.WriteLine("Значение переменной a = "+a);
                            Console.WriteLine("Значение переменной b = "+b);
                            Console.WriteLine("Значение переменной result = "+result);
                        }
                        return result;
                    }
                    int result = Sum(1, 5,true);
                    Console.WriteLine(result);*/

        // именнованные параметры или аргументы
        /*            static int Sum(int a, int b, bool enableLogging = false, int c = 55)
                    {
                        int result = a + b;
                        if (enableLogging)
                        {
                            Console.WriteLine("Значение переменной a = " + a);
                            Console.WriteLine("Значение переменной b = " + b);
                            Console.WriteLine("Значение переменной result = " + result);
                        }
                        return result;
                    }
                    int result = Sum(b:4,a:354,enableLogging: true);
                    Console.WriteLine(result); */

        //Рекурсия вызов самого себя, с обязательным выходом из цикла.
        //Методы и стек
        //Переполнение стека
        // реализовать вывод масисва с помощью рекурсии
        /*            static void Foo(int i)
                    {
                        int[] = int.TryParse(i.Split());
                    }*/
        /*            static void PrintArray(int[] myArray, int i = 0)
                    {
                        if (i<myArray.Length)
                        {
                            Console.WriteLine(myArray[i]);
                            PrintArray(myArray, i+1);
                        }

                    }

                    int[] myArray = { 1, 4, 6, 84, 24 };
                    PrintArray(myArray);*/
        // сумма элементов массива
        /*            static int Sum(int[] myArray, int i = 0)
                    {
                        if (i >= myArray.Length)
                            return 0;

                       *//* int result = Sum(myArray, i + 1);*//*

                        return myArray[i] + Sum(myArray,i+1);*/

        //найти сумму цифр числа с помощью рекурсии
        // 561 = 12
        /*            static int Foo(int value)
                    {
                        if (value < 10)  
                            return value; 

                        int digit = value % 10;
                        int nextValue = value / 10;
                        return digit + Foo(nextValue);
                    }
                    int myValue = 5618;
                    Console.WriteLine(Foo(myValue));*/
        //Локаничный код.
        /*            static int Bar(int value)
                    {
                        if (value < 10)
                            return value;
                        return value % 10 + Bar(value / 10);
                    }
                    Console.WriteLine(Bar(535));*/
        /*            static int Foo(int value)
                    {
                        int result = 0;
                        while (value>0) 
                        {
                            result += value % 10;
                            value = value / 10;
                        }
                        return result;

                    }
                    Console.WriteLine(Foo(4546));*/
        // преобразование и приведение примитивных типов(Одно и тоже) процесс перевода одного типа данных в другой. в С#
        /*           static void Foo(float value)
                    {
                        Console.WriteLine(value);
                    }

                    double a = 5.5;
                    byte b = (byte)a;//явное приведение типов или преобразование

                    Foo(b);*/
        //nullable
        /*            DateTime? dateTime = null;
                    int? i = null;

                    i.Value*/
        /*            // Неявно типизированные локальные переменные
                    var t = (string)null;
                    t = null;
                    Console.WriteLine(t.GetType());*/
        /*            while (true)
                    {
                        ConsoleKey key = Console.ReadKey().Key;
                        int keyCode = (int)key;
                        Console.Write($"\tEnum{key}\tKey Code {keyCode}");
                        if (key==ConsoleKey.Enter)
                        {
                            Console.WriteLine("Вы нажали enter!");
                        }
                    }*/
        /*               public enum DayOfWeek
               {
                   Monday,
                   Tuesday,
                   Wednesday,
                   Thursday,
                   Friday,
                   Saturday,
                   Sunday
               }


                   Console.WriteLine((DayOfWeek)3);

                   while (true) 
                   {
                       ConsoleKey key = Console.ReadKey().Key;
                       int keyCode = (int)key;
                  *//*     Console.WriteLine($"\tEnum{key}\t KeyCode {keyCode}");*//*
                       if (true)
                       {
                           Console.WriteLine($"\nВы нажали {key}!");
                       }
                   }
       */
        //ООП Класс Обьект класса


        
        static void Main(string[] args)
        {
            /*
                        Point p = new();
                        p.x = 10;
                        p.y = 20;
                        p.color = Point.Color.Red;
                        Console.WriteLine($"{p.y},{p.x}");

                        var firstStudent = Student.GetStudent();
                        Student.PrintData(firstStudent);
                        Console.WriteLine(firstStudent.GetFullNameP());
                        //ООП
                        //Методы обьекта класса
                         var car = new Car();
                        car.PrintSpeed();
                        car.DriveForward();
                        car.PrintSpeed();
                        car.Stop();
                        car.PrintSpeed();
                        car.DriveBackward();
                        car.PrintSpeed();*/

            /*            Access point = new Access();


                        point.PrintX();
                       *//* point.PrintY();*//*
                        point.PrintPoint();*/
            /*            GUN gun = new GUN(true);
                        GUN gun2 = new GUN();
                        gun2.Shoot();
                       gun.Shoot();
                        Point point = new(5, 3);
                        point.Print();
            */
            Point point = new(5, 3);
            point.SetX(54);
            Console.WriteLine(point.GetX());
            point.Print();
            point.SetY(34);
            point.Print();
            point.Z = 10;
            int z = point.Z;
        }



    }
}
