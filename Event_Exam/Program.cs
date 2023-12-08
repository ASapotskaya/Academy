using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Exam
{
    
    class Student
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BD { get; set; }
        public int bal { get; set; }
        public override string ToString()
        {
            return $"{FirstName,15} {LastName,15} {BD.ToShortDateString(),17} ";
        }
        public void Exam(string exam_work)
        {
            
            Console.WriteLine($" студент {LastName} выполняет {exam_work}. Балл за первое задание: {bal}");
        }


    }
    

    class Teacher
    {
        Random rn = new Random();
        public event Delegate_Exam event_exam
        {
            add 
            {
                for(int key; ;)
                {
                    key = rn.Next();
                    if(!sort_ev.ContainsKey(key))
                    {
                        sort_ev.Add(key, value);
                        break;
                    }
                }
            }
            remove 
            {
                sort_ev.RemoveAt(sort_ev.IndexOfValue(value));           
            }
        }
        SortedList<int, Delegate_Exam> sort_ev = new SortedList<int, Delegate_Exam>();

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void Exam(string st)
        {
            foreach  (int  item in sort_ev.Keys)
            {
                if(sort_ev[item]!=null)
                {
                    sort_ev[item](st);
                }
            }
        }
    }
    public delegate void Delegate_Exam(string str);
    class Program
    {
        
        static void Main(string[] args)
        {
            
            List<Student> students = new List<Student>
            {
                    new Student{FirstName="Ivan", LastName="Ivanov", BD=new DateTime(2000,1,1)},
                    new Student{FirstName="Petr", LastName="Petrov", BD=new DateTime(2014,3,10)},
                    new Student{FirstName="Sergey", LastName="Surikov", BD=new DateTime(1999,4,23)},
                    new Student{FirstName="Nicole", LastName="Kirova", BD=new DateTime(2010,8,13)},
                    new Student{FirstName="Andre", LastName="Simonov", BD=new DateTime(2003,7,19) }
            };
            Teacher t = new Teacher();
            Random rn = new Random();
            foreach (Student item in students)
            {
                t.event_exam += item.Exam; // отписка t.event_exam -= item.Exam;
            }
            t.Exam("Задание 1");
            Console.WriteLine("****************************************");
            foreach (Student item in students)
            {
                item.bal = rn.Next(1, 12);
            }
            foreach (Student item in students)
            {
                if (item.bal<=7)
                t.event_exam -= item.Exam;
            }
            t.Exam("Задание 2");

            Student st_tmp = new Student
            {
                FirstName = "Andre_new",
                LastName = "Simonov_new",
                BD = new DateTime(2013, 7, 13)

            };
            Console.WriteLine("***********************************");
            t.event_exam += st_tmp.Exam;
            t.Exam("Задание 2");



        }
    }
}
