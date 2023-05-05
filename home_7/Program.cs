using System.Net;

namespace home_7
{
    internal class Program
    {
/*        Реализовать систему работы ресторана Макдональдс.В системе должны быть следующие участники
Cleaner - уборщик, умеет убираться.
Cook - повар, умеет готовить и убираться
Менеджер - Умеет решать конфликты, готовить, управлять персоналом
Создать метод, который будет имитировать работу ресторана c выводом информации на консоль.
Ex(Manager is managing people
    Cook is cooking
    Cleaner is cleaning
    Manager is solving conflicts
    Manager is cooking.
    Cook is cleaning.)
Переопределить метод ToString() в каждом классе сотрудников ресторана.*/
        static void Main(string[] args)
        {
            Client[] client = new Client().BuildClient(5);
            Client.PrintData(client);
            Managment_McDonalds managment_McDonalds = new Managment_McDonalds();
            managment_McDonalds.WorkRestoran(client);

        }
    }
}