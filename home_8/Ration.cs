using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_8
{
    public class Ration
    {
        public Dictionary<DayOfWeek,List<Product>> RationOfWeek { get; set; }
        
        public Ration(Dictionary<DayOfWeek, List<Product>> rationOfWeek)
        {
            RationOfWeek = rationOfWeek;
        }
        public int SumCalories(DayOfWeek day) 
        {
            List<Product> Rationonday = RationOfWeek[day];
            return Rationonday.Sum(x => x.Calories);
        }
        

    }
}
