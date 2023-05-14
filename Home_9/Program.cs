namespace Home_9
{
    public class Program
    {
    /*    Создайте коллекцию состояющую из объектов Person(поля Name, Age, Salary)
    Выведите всех Person, чье имя начинается на A
    Выведите всех Person, у кого зп больше 1000 и возраст меньше 30. 
    Выведите первого человека старше 50 
    Добавьте свои классы исключений - SalaryException, AgeException и добавьте в поля Age и Salary проверку, 
    если Age меньше 18 - сгенерируйте исключение, если salary меньше 100 - сгенерируйте исключение
    Обработайте исключения*/

        static void Main(string[] args)
        {
            try
            {
                List<Person> people = new()
            {
               new("Roman",29,500000),
               new("Alex",23,1000),
               new("Maks",25,15000),
               new("Nikolai",29,24000),
               new("Georgi",40,50000),
               new("Geo",51,55000),
               new("Vasya",54,55000)
            };
                Person.PrintData(people);
                Console.WriteLine();
                /*Person.PrintData(people.Where(x => x.Name.StartsWith("A")).ToList());*/
                Console.WriteLine();
                Person.PrintData(people.Where(x => x.Name.StartsWith("A")));
                Console.WriteLine();
                Person.PrintData(people.Where(x => x.Salary > 1000 && x.Age < 30));
                Console.WriteLine();
                Console.WriteLine((people.FirstOrDefault(x => x.Age > 50)));
            }
            catch (AgeException ex)
            {
                Console.WriteLine("Ошибка возраста\t"+ex.Message);
            } 
            catch (SalaryException ex)
            {
                Console.WriteLine("Ошибка Зарплаты\t" + ex.Message);
            }

            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}

