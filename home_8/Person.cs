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
    internal class Person
    {
        public string Name { get; set; }
        public double MaxNumberOfCalories { get; set; }
        
        public Person(string name,double maxNumberOfCalories)
        {
            Name = name;
            MaxNumberOfCalories = maxNumberOfCalories;
        }

    }
}
