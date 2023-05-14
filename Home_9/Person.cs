using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_9
{    /*    Создайте коллекцию состояющую из объектов Person(поля Name, Age, Salary)
    Выведите всех Person, чье имя начинается на A
    Выведите всех Person, у кого зп больше 1000 и возраст меньше 30. 
    Выведите первого человека старше 50 
    Добавьте свои классы исключений - SalaryException, AgeException и добавьте в поля Age и Salary проверку, 
    если Age меньше 18 - сгенерируйте исключение, если salary меньше 100 - сгенерируйте исключение
    Обработайте исключения*/
    public class Person
    {
        string name;
        int age;
        double salary;

        public Person(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public string Name { get; set; }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 18) throw new AgeException();
                age = value;
            }
        }
        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value < 100) throw new SalaryException();
                salary = value;
            }
        }
        public static void PrintData<T>(IEnumerable <T> people)
        {
            foreach (T person in people)
            {
                Console.WriteLine(person);
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Salary: {Salary}";
        }

    }
}

