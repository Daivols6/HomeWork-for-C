using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Cам рацион представляет пару ключ(День недели(Enum) -значение(список продуктов) - List.Продукт содержит поля: название продукта, Количество калорий (1 class Product)*/
namespace home_8
{
    public class Product
    {
        public string Name { get; set; }
        public int Calories { get; set; }
    

    public Product(string name,int calories)
    {
        Name = name;
        Calories = calories;
    }
    public enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

        public List<Product> products;





    public static void RationOnDay(Person[] persons)
    {
        Random rnd = new Random();
        foreach (Person person in persons)
        {

        }

    }

}
}
