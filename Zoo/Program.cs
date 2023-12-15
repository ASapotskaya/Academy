using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
   


    class Program
    {
        static void Main(string[] args)
        {
            List<Zoopark> ZOO = new List<Zoopark>();
            ZOO.Add(new Lion { Name = "Лёва", Age = 2, Gender = "Мужской" });
            ZOO.Add(new Tiger { Name = "Игорь", Age = 1, Gender = "Мужской" });
            ZOO.Add(new Snake { Name = "Гадюка", Age = 3, Gender = "Женский" });
            ZOO.Add(new Parrot { Name = "Кеша", Age = 3, Gender = "Мужской" });

            Console.SetCursorPosition(2, 2);
            Console.WriteLine("ДОБРО ПОЖАЛОВАТЬ В ЗООПАРК!");
            Camera camera = new Camera();
            camera.ShowAnimals(ZOO);
        }
    }
}
