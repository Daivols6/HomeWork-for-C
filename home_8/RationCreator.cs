using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_8
{
    public class RationCreator
    {

        static List<Product> products = new() 
        {
            new("Tomato",332), 
            new("Apple", 324),
            new("Pizza",500),
            new("Tea", 100),
            new("Beer", 600),
            new("Meat", 456)
        }; 


        public static List<Product> ProductCreator()
        {   Random rn = new Random();
            int countProduct = rn.Next(5,9);
            List<Product> tempproduct = new();
            for (int i = 0; i <countProduct; i++)
            {   
                int randindex = rn.Next(products.Count);
                tempproduct.Add(products[randindex]);
            }
            return tempproduct;
        }

        public static Ration RationCreate()
        {
            Dictionary<DayOfWeek, List<Product>> eat = new();
            Random rnd = new Random();
            foreach (var day in Enum.GetValues<DayOfWeek>())
            {
                eat.Add(day, ProductCreator()); 
            }
            Ration ration = new Ration(eat);
            return ration;
        }

    }
}

