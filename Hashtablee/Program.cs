
//3 System.Collections.Hashtable


using System.Collections;
using static System.Console;
namespace Hashtablee
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Hashtable hash = new Hashtable();

            hash.Add(1, "one");
            hash.Add(2, "two");
            hash.Add("three", 3);

            foreach (object o in hash.Keys)
            {
                Write(o.ToString() + " ");
            }
            WriteLine();
            foreach (object o in hash.Values)
            {
                Write(o.ToString() + " ");
            }
            WriteLine();

            //2
            //Hashtable hash = new Hashtable(17);

            //3
            //hash.Add("four", 4);
            //hash.Remove(1);
            //foreach (object o in hash.Keys)
            // Write(o.ToString() + " ");
            //WriteLine();

            //4
            //  WriteLine(hash.Contains("three"));


        }
    }
}


