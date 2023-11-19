using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class Graduate:Student
    {
        public string Topic { get; set; }
        public Graduate(
            string last_name, string first_name, int age,
            string speciality, string group, double rating, double attendance,
            string topic
            ):base(last_name, first_name, age,speciality, group,rating,attendance)
        {
            Topic = topic;
            Console.WriteLine("GConstructor:\t" + GetHashCode());
        }
        public Graduate(Student student, string topic) : base(student)
        {
            Topic = topic;
            Console.WriteLine("GConstructor:\t" + GetHashCode());
        }
        ~Graduate()
        {
            Console.WriteLine("GDestructor:\t" + GetHashCode());
        }
        public override string ToString()
        {
            return base.ToString() + $"Тема диплома: {Topic}";
        }
    }
}
