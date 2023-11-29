using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Abstract_class
{
    interface I1
    {
        string F1(int n);

    }

    interface I2
    {
        int F2(int n);
        void F3();
        string F1(int n);
    }
    //interface I3 :I1,I2
    //{
    //    void F4(int n);
    //}

    class MyClass : I1, I2
    {
         string I1.F1(int n)
        {
            return $"function_1 {n}";
        }

         string I2.F1(int n)
        {
            return $"function_2 {n}";
        }
        public int F2(int n)
        {
            throw new NotImplementedException();
        }

        public void F3()
        {
            throw new NotImplementedException();
        }
    }



    public interface IWorker
    {
        bool IsWorker { get; }
        string Work();
    }
     interface IManager // не обязательно писать паблик, интерфейс сразу доступный
    {
        List<IWorker> List_wor { get; set; }
        void Organize();
        void MakeBudget();
        void Control();

    }
    public abstract class Human
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

         
        public override string ToString()
        {
            return $"ID: {id} Фамилия: {lastName} Имя:{firstName}\n";
        }
       
        
    }
    public abstract class Employee : Human
    {
        public  double Salary { get; set; }
        public  string Position { get; set; }

        public override string ToString()
        {
            return base.ToString() + $" Должность: {Position}, Заработная плата: {Salary} $";
        }
    }

    
class Director : Employee, IManager

    
    {
        public List<IWorker> List_wor { get; set; }

        public void Control()
        {
            Console.WriteLine("Контролирую работу");
        }

        public void MakeBudget()
        {
            Console.WriteLine("Формирую бюджет");
        }

        public void Organize()
        {
            Console.WriteLine("Организую работу");
        }

       
    }

    class Cashier : Employee, IWorker

    {
        bool isWorker = true;
        public bool IsWorker { get { return isWorker; } }

        
        public string Work()
        {
            return $"Принимаю оплату за товар";
        }
    }

    class Storekeeper : Employee, IWorker

    {
        bool isWorker = true;
        public bool IsWorker { get { return isWorker; } }


        public string Work()
        {
            return $"Учет и прием товара";
        }
    }

    class Seller : Employee, IWorker

    {
        bool isWorker = true;
        public bool IsWorker { get { return isWorker; } }


        public string Work()
        {
            return $"Продает товар";
        }
    }
    class Program
    {
        static void Main(string[] args)

        {
            Director boss = new Director { id = 1, lastName = "LD", firstName = "FD", Position = "Director", Salary = 12000 };
            IWorker seller = new Seller { id = 2, lastName = "Ls", firstName = "Fs", Position = "Seller", Salary = 6000 };
            boss.List_wor = new List<IWorker>
            {
                seller, new Cashier{id = 3, lastName = "Lc", firstName = "Fc", Position = "Cashier", Salary = 8000},
                new Storekeeper{id = 4, lastName = "Lst", firstName = "Fst", Position = "Storekeeper", Salary = 10000}
            };

            //is as

            if (seller is Employee) Console.WriteLine($"Заработная плата : {(seller as Employee).Salary}");
            Console.WriteLine(boss);
            if (boss is IManager) boss.MakeBudget();
            foreach (IWorker item in boss.List_wor)
            {
                Console.WriteLine(item);
                if (item.IsWorker) Console.WriteLine(item.Work());
                Console.WriteLine();
            }

            MyClass obj = new MyClass();
            Console.WriteLine(((I1)obj).F1(10));

            
            I2 i2 = new MyClass();
            Console.WriteLine(i2.F1(6)); 
        }

    }
}
