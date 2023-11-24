using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Abstract_class
{
    public abstract class Human
    {
        protected int id;
        protected string firstName;
        protected string lastName;

         public Human (int _id, string fName, string lName)
        {
            id = _id;
            firstName = fName;
            lastName = lName;
        }
        public virtual void Print()
        {
            WriteLine($"ID: {id} Фамилия: {lastName}\nИмя:{firstName}\n");
        }
        //public abstract void Work();
        //public abstract void Think();
    }
    public abstract class Employee : Human
    {
        double Salary;
        public Employee(int _id, string fName, string lName, double salary): base(_id, fName,lName)
        {
            Salary = salary;
            
        }
        public override void Print()
        {
            base.Print();
            WriteLine($"Заработная плата: {Salary} $");
        }

       
        public override string ToString()
        {
            
            return $"ID: {id} Фамилия: {lastName}\nИмя:{firstName}\nЗаработная плата: {Salary} $";
        }

        public abstract void Work();
        public abstract void Think();
    }

    
class Manager : Employee

    {

        string _fieldActivity;

        public Manager(int _id,  string fName, string lName, double salary, string activity) : base(_id, fName, lName, salary)

        {

            _fieldActivity = activity;

        }

        public override void Print()

        {
            base.Print();
            WriteLine($"Менеджер. Сфера деятельности:{_fieldActivity}");

        }

        public override void Think()
        {

            Console.WriteLine("Манагер думает");
        }

        public override void Work()
        {

            Console.WriteLine("манагер работает");
        }
    }

    class Scientist : Employee

    {

        string _scientificDirection;

        public Scientist(int _id, string fName, string lName,  double salary, string direction) : base(_id, fName, lName,  salary)

        {

            _scientificDirection = direction;

        }

        public override void Print()

        {
            base.Print();
            WriteLine($"Ученый. Научное направление: {_scientificDirection}");
        }

        public override void Think()
        {
            Console.WriteLine("Науч работник думает");
        }

        public override void Work()
        {
            Console.WriteLine("Научный работник работает");
        }
    }

    class Specialist : Employee

    {

        string _qualification;

        public Specialist(int _id, string fName, string lName, double salary, string qualification) : base(_id, fName, lName, salary)

        {

            _qualification = qualification;

        }

        public override void Print()

        {
            base.Print();
            WriteLine($"Специалист. Квалификация: { _qualification}");

        }

        public override void Think()
        {
            Console.WriteLine("Специалист думает");
        }

        public override void Work()
        {
            Console.WriteLine("Специалист работает");
        }
    }

    class Program

    {

        static void Main(string[] args)

        {

            Employee manager = new Manager(3,"John", "Doe",  3500, "продукты питания");

            Employee[] employees = { manager,

                                           new Scientist(4,"Jim", "Beam", 4253, "история"),

                                           new Specialist(5,"Jack", "Smith", 2587.43,"физика")

    };

            foreach (Employee item in employees)

            {

                item.Print();
                item.Think();
                item.Work();
                //item.ShowScientist(); Error
                //try
                //{
                //    ((Specialist)item).
                //    ShowSpecialist(); // Способ №1
                //}
                //catch
                //{
                //}
                //Scientist scientist = item as Scientist; // Способ №2
                //if (scientist != null)
                //{
                //    scientist.ShowScientist();
                //}
                //if (item is Manager) // Способ №3
                //{
                //    (item as Manager).ShowManager();
                //}

            }

        }

    }
}
