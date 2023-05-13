using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Составьте рацион питания для человека на неделю(Person - Содержит поля Name, MaxNumberOfCalories(Макс Количество - калорий потребляемых за день)).*/
/*Добавьте метод в классе Person, который проверит рацион на каждый день и если в какой-то день общее количество калорий превышает максимальное, будет удалять продукты из списка, пока сумма их калорий будет меньше либо равна
максимальному количеству калорий, потребляемых человеком за день.*/

namespace home_8
{
    public class Person
    {
        public string Name { get; set; }
        public double MaxNumberOfCalories { get; set; }

        public Ration Rations { get; set; }

        public Person(string name, double maxNumberOfCalories, Ration rations)
        {
            Name = name;
            MaxNumberOfCalories = maxNumberOfCalories;
            Rations = rations;
        }
        public static Person[] PersonCreator(int count)
        {
            Person[] people = new Person[count];
            string[] names = { "Vasya", "Petya", "Masha", "Stas", "Anna", "Ivan" };
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                double maxNumberOfCalories = random.Next(1500, 3000);
                string name = names[random.Next(0, 5)];
                people[i] = new Person(name, maxNumberOfCalories, RationCreator.RationCreate());

            }
            return people;
        }
        public static List<Person> PersonCreatorList(int count)
        {
            List<Person> people = new List<Person>(count);
            List<string> names = new List<string> { "Vasya", "Petya", "Masha", "Stas", "Anna", "Ivan" };

            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                double maxNumberOfCalories = random.Next(1500, 3000);
                string name = names[random.Next(0, 5)];
                Person person = new Person(name, maxNumberOfCalories, RationCreator.RationCreate());
                people.Add(person);
            }
            return people;

        }

        public void DeletedProduct()
        {
            foreach (var item in Rations.RationOfWeek)
            {
                int sum = Rations.SumCalories(item.Key);

                while(sum>= MaxNumberOfCalories)
                {
                    item.Value.RemoveAt(item.Value.Count-1);
                    sum = Rations.SumCalories(item.Key);
                }
            }
            
            
            
        } 

        public static void PrintData(List<Person> people)
        {
            foreach (Person person in people)
            {
                Console.WriteLine($"Name: {person.Name}, MaxCalories: {person.MaxNumberOfCalories}");
                foreach (var item in person.Rations.RationOfWeek)
                {
                    Console.WriteLine($"{item.Key}");
                    foreach (var product in item.Value)
                    {
                        Console.WriteLine($"NameOfProduct: {product.Name}, Calories: {product.Calories}");
                    }
                }

            }
        }
        public static void PrintData(Person[] people)
        {
            PrintData(people.ToList());

        }
    }
}