using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static home_7.Client;

namespace home_7
{
    public class Client : Person

    {   
        public enum ActionType
        {
            Order_food,
            Swear,
            Litter,
            Just_looking
        }
        public ActionType Action { get; set; }
        public Client() : base("", 0)
        {
        }
        public Client(string name, int age, ActionType action) : base(name, age)
        {
             Action = action;
        }


        string[] names = { "Roman", "Dimon", "Alex", "Vasya", "Masha", "Anna", "Vadim" };

        public Client[] BuildClient(int count)
        {
            Client[] clients = new Client[count];

            for (int i = 0; i < count; i++)
            {
                Random random = new Random();
                int age = random.Next(18, 35);
                var name = names[random.Next(0, names.Length)];
                var action = (ActionType)random.Next(0,4);
                clients[i] = new Client(name, age, action);
                
            }
            return clients;
        }
        public static void PrintData(Client[] clients)
        {
            foreach (var client in clients)
            {
                Console.WriteLine($"\n Name: {client.Name}, Age: {client.Age}, Action: {client.Action}\n");
            }
        }
    }
}