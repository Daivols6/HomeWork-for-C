using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_training
{
    class GUN
    {
        public GUN(bool isLoaded)
        {
            IsLoaded = isLoaded;
        }
        public GUN()
        {
            
        }
        private bool IsLoaded;
        private void Reload()
        {
            Console.WriteLine("Заряжаю...");
            IsLoaded = true;
            Console.WriteLine("Заряжено!");
        }
        public void Shoot() 
        {
            if (!IsLoaded)
            {
                Console.WriteLine("Орудие не заряжено!");
                Reload();
            }
            Console.WriteLine("Выстрел!\n");
            IsLoaded= false;
        }
    }
}
