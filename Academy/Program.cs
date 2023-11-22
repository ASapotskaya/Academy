using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


//is-a


namespace Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Human tommy = new Human("Vercetty", "Tommy", 25);
            Human diaz = new Human("Diaz", "Ricardo", 50);
            Human ken = new Human("Rosenberg", "Ken", 30);

            Student student = new Student("Pinkman", "Jessie", 25, "Chemistry", "WW_220", 95, 98);
            //Console.WriteLine(student);

            Teacher teacher = new Teacher("White","Walter",52, "Chemistry", 25);
            //Console.WriteLine(teacher);
            
            Graduate grad = new Graduate("Schrader", "Hank", 40, "Criminalistic", "OBN", 70, 40, "How to catch WW");
            //Console.WriteLine(grad);

            Student tommy_stud = new Student(tommy, "Theft", "Vice", 95, 98);
            //Console.WriteLine(tommy_stud);

            Teacher diaz_teacher = new Teacher(diaz, "Weapons distribution", 25);
            //Console.WriteLine(diaz_teacher);

            Graduate graduate = new Graduate(tommy_stud, "How to make money.");
            //Console.WriteLine(graduate);


            //upcast -преобразование объекта дочернего класса в объект базового класса
            // благодаря upcast можно выполнять Generalisation (обобщение)
                Human[] group = new Human[] 
            {
                student, teacher, grad, tommy_stud, diaz_teacher, graduate ,
                new Student ("Rosenberg", "ken", 30, "Lower","vice",32,22)
            };
            Console.WriteLine(delimiter);
            //specialization - уточнение,возможно благодаря Downcast.
            //Downcast - это преобразование базового объекта в дочерний тип.
            //Downcast возможен благодаря виртуальный методам
            //виртуакльным называется метод который может быть переопределен в дочернем классе, с учетом его полей.

            string current_directory = Directory.GetCurrentDirectory();
            string filename = "Group.txt";
            Console.WriteLine(current_directory);
            StreamWriter sw = new StreamWriter(filename);
            
            for ( int i = 0; i<group.Length;i++)
            {
                //Console.WriteLine(group[i]);
                sw.WriteLine(group[i]);
            }
            sw.Close();
            Console.WriteLine(delimiter);

            string cmd = $"{current_directory}\\{filename}";
            System.Diagnostics.Process.Start("notepad", cmd);



            try
            {
                //throw new Exception("Нет такого файла"); ключевое слово throw  бросает исключение
                StreamReader sr = new StreamReader("Group.txt");
                while (!sr.EndOfStream)
                {
                    string buffer = sr.ReadLine();
                    Console.WriteLine(buffer);
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }
        }
        
        const string delimiter = "\n----------------------------------------------\n";
    }
}
