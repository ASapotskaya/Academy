using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate double MyCalcDelegate(double n1, double n2);
    //public delegate double MyCalcDelegate1(int n1, int n2);
    //public delegate double MyCalcDelegate2(int n1, double n2);


    //Generic-delegate
    public delegate T MyCalcDelegate<T>(T n1, T n2);

    public class Class_1
    {
        public double Print(double x, double y)
        {
            double z = x * y;
            Console.WriteLine("мама мыла раму");
            return z;

        }
    }
    public class MyCalc
    {
        public double Add(double n1, double n2)
        {
            return n1 + n2;
        }
        public int Add(int n1, int n2)
        {
            return n1 + n2;
        }
        public double Add(double n1, int n2)
        {
            return n1 + n2;
        }
        public double Sub(double n1, double n2)
        {
            return n1 - n2;
        }
        public static double Mult(double n1, double n2)
        {
            return n1 * n2;
        }
        public double Div(double n1, double n2)
        {
            if (n2 != 0)
            {
                return n1 / n2;
            }
            throw new DivideByZeroException();

        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {

            //MyCalc c1 = new MyCalc();
            //MyCalcDelegate d1 = null;
            MyCalcDelegate d2 = null;


            //int n;
            //n = Int32.Parse(Console.ReadLine());//1-+
            //switch (n)
            //{
            //    case 1: d1 = new MyCalcDelegate(c1.Add);
            //        break;
            //    case 2:
            //        d1 = new MyCalcDelegate(c1.Sub);
            //        break;
            //    case 3:
            //        d1 = new MyCalcDelegate(c1.Div);
            //        break;
            //    case 4:
            //        d1 = new MyCalcDelegate(MyCalc.Mult);
            //        break;

            //    default: throw new InvalidOperationException();
            //}

            // Console.WriteLine($"{d1(2.5,8.5)}");
            //Console.WriteLine("multicasting");
            //MyCalc c1 = new MyCalc();
            //MyCalcDelegate d = null;


            //d += c1.Add;
            //d += c1.Sub;
            //d += MyCalc.Mult;
            //foreach  (MyCalcDelegate item in d.GetInvocationList())
            //{
            //    Console.WriteLine($"{item(2.5, 8.5)}");
            //}

            //MyCalc c1 = new MyCalc();

            //MyCalcDelegate<double> d_double = c1.Add;
            //Console.WriteLine($"{d_double(2.5,4)}");

            //MyCalcDelegate<int> d_int = c1.Add;
            //Console.WriteLine($"{d_int(2, 4)}");

            //Console.WriteLine($"{c1.Add(2,3)}");
            //Class_1 obj_1 = new Class_1();
            //d_double = obj_1.Print;
            //Console.WriteLine($"{d_double(2.7,5.9)}");

        }

    }
}
