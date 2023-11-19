using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class Student:Human 
    {
        public string Speciality { get; set; }
        public string Group { get; set; }
        public double Rating { get; set; }
        public double Attendance { get; set; } //посещаемость
        
        public Student
            (
            string last_name, string first_name, int age,
            string speciality, string group, double rating, double attendance
            ):base(last_name,first_name,age)
        {
            Speciality = speciality;
            Group = group;
            Rating = rating;
            Attendance = attendance;
            Console.WriteLine("SConstructor:\t"+GetHashCode());
        }
        public Student(Human human, string speciality, string group, double rating, double attendance):base(human)
        {
            Speciality = speciality;
            Group = group;
            Rating = rating;
            Attendance = attendance;
            Console.WriteLine("SConstructor:\t" + GetHashCode());
        }
        public Student(Student other):base(other) //upcast -преобразование объекта дочернего класса в объект базового класса
        {                                           // благодаря upcast можно выполнять Generalisation (обобщение)
            this.Speciality = other.Speciality;
            this.Group = other.Group;
            this.Rating = other.Rating;
            this.Attendance = other.Attendance;
            Console.WriteLine("SCopyConstructor:\t" + GetHashCode());
        }
        ~Student()
        {
            Console.WriteLine("SDestructor:\t" + GetHashCode());
        }
        public override string ToString()
        {
            return base.ToString() + $"Специальность: {Speciality}. Группа: {Group}. Рейтинг: {Rating}. Посещаемость: {Attendance}.";
        }
    }
}
