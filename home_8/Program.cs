﻿using System.Collections.Generic;
using System.Xml.Linq;
using System;

namespace home_8
{
/*    Составьте рацион питания для человека на неделю(Person - Содержит поля Name, MaxNumberOfCalories(Макс Количество-калорий 
 *    потребляемых за день)).
Cам рацион представляет пару ключ(День недели(Enum) - значение (список продуктов) - List.Продукт содержит поля: название продукта,
Количество калорий (1 class Product)
Составьте рацион произвольным образом(пример: создайте класс RationCreator и добавьте в него метод по созданию рациона) 
на каждый день и назначьте его Person.
Добавьте метод в классе Person, который проверит рацион на каждый день и если в какой-то день общее количество калорий 
превышает максимальное, будет удалять продукты из списка, пока сумма их калорий будет меньше либо равна
максимальному количеству калорий, потребляемых человеком за день.*/
    public class Program
    {
        static void Main(string[] args)
        {
            Person[] people = Person.PersonCreator(1);
            Person.PrintData(people);
            people[0].DeletedProduct();
            Console.WriteLine();
            Person.PrintData(people);

            /*List<Person> people2 = Person.PersonCreatorList();
            Person.PrintData(people2); */

        }
    }
}