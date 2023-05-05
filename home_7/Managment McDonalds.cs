using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace home_7
{
    public class Managment_McDonalds: IEmployees
    {
        public void WorkRestoran(Client[] clients)
        {
            foreach (var personal in clients)
            {
                switch (personal.Action)
                {
                    case Client.ActionType.Swear:
                    Manager manager = new Manager("Alexei",34);
                    Console.Write($"Client\n Name: {personal.Name} Age: {personal.Age}\n Action  - {manager.ToString()}\n Manager: - ");
                        manager.SolvingConflicts();
                        Console.WriteLine();
                        break;
                    case Client.ActionType.Order_food:
                        Cook cook = new Cook("Nikolai", 24);
                        Console.Write($"Client\n Name: {personal.Name} Age: {personal.Age}\n Action  - {cook.ToString()}\n Cook: - ");
                        cook.Cooking();
                        Console.WriteLine();
                        break;
                    case Client.ActionType.Litter:
                        Cleaner cleaner = new Cleaner("Sten", 27);
                        Console.Write($"Client\n Name: {personal.Name} Age: {personal.Age}\n Action  - {cleaner.ToString()}\n Cleaner: - ");
                        cleaner.Cleaning();
                        Console.WriteLine();
                        break;
                    case Client.ActionType.Just_looking:
                        Manager manager1 = new Manager("Alexei", 34);
                        Cook cook1 = new Cook("Nikolai", 24);
                        Cleaner cleaner1 = new Cleaner("Sten", 27);
                        Console.Write($"Client\n Name: {personal.Name} Age: {personal.Age}\n Action  - Just looking\n\n");
                        Console.Write("Cleaner: ");
                        cleaner1.Cleaning();
                        Console.Write("Manager: ");
                        manager1.ManageStaff();
                        Console.Write("Cook: ");
                        cook1.Cleaning();
                        Console.WriteLine();
                        break;
                    default: 
                        Console.WriteLine("All relaxation\n");
                        Console.WriteLine();
                        break;

                }
            }
        }
    }
}
