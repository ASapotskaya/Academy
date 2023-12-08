//3 System.Collections.SortedList

using System;
using System.Collections;
using static System.Console;
using System.Collections.Generic;
namespace SortedListt
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1
            //SortedList sortedList = new SortedList();
            //WriteLine(sortedList.Capacity);
            //sortedList.Add("one", "two");
            //WriteLine(sortedList.Capacity);


            //2
            //SortedList List = new SortedList();
            //List.Add(2, 20);
            //List.Add(1, 100);
            //List.Add(3, 3);

            //foreach (int i in List.GetKeyList())
            //{
            //    WriteLine(i);
            //}

            //foreach (int i in List.GetValueList())
            //{
            //    WriteLine(i);
            //}

            ////3
            //for (int i = 0; i < List.Count; i++)
            //{
            //    WriteLine("Кey - " + List.GetKey(i) + " Value - " + List.GetByIndex(i));
            //}

            //4

            //List.RemoveAt(1);
            //foreach (int i in List.GetKeyList())
            //{
            //    WriteLine(i);
            //}
            //List.Remove(3);
            //foreach (int i in List.GetKeyList())
            //{
            //    WriteLine(i);
            //}

            //5.1

            //SortedList List = new SortedList();
            //List.Add(1, "one");
            //List.Add(2, "two");
            //foreach (int i in List.GetKeyList())
            //{
            //    WriteLine(i);
            //}

            //5.2

            //SortedList List1 = new SortedList();
            //List1.Add("one",1 );
            //List1.Add("two",2);
            //foreach (string i in List1.GetKeyList())
            //{
            //    WriteLine(i);
            //}

            //ArrayList ar1 = new ArrayList();
            //ar1.Add(10);
            //ar1.Add(12);
            //ar1.Add(45);
            //ar1.Add(3.8);

            //int num = (int)ar1[0];
            //double num3 = (double)ar1[3];

            //List<int> l1 = new List<int> { 5, 7, 9, 4 };

            //Dictionary<string, int> group = new Dictionary<string, int>();
            //group["G1"] = 12;
            //group["G2"] = 23;
            //group["G3"] = 45;
            //group["G1"] = 120;

            //Console.WriteLine("Our dictionary ");
            //foreach (KeyValuePair<string, int> item in group)
            //{
            //    Console.WriteLine($"{item.Key, -10}  {item.Value,5}");
            //}
            //group.Remove("G2");
            //Console.WriteLine("*****************************************************");
            //foreach (KeyValuePair<string, int> item in group)
            //{
            //    Console.WriteLine($"{item.Key,-10}  {item.Value,5}");
            //}
            //Console.WriteLine("*******************************************************");
            //try
            //{
            //    group.Add("G3", 450);
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine(e.Message);
            //}
            //foreach (KeyValuePair<string, int> item in group)
            //{
            //    Console.WriteLine($"{item.Key,-10}  {item.Value,5}");
            //}
            //Console.WriteLine("*******************************************");
            //int key;
            //if (group.TryGetValue("G5", out key)) Console.WriteLine(key);
            //else Console.WriteLine("Ключ не существует");

            Dictionary<string, int> group1 = new Dictionary<string, int>()
            {
                ["G1"] = 12,
                ["G2"] = 23,
                ["G3"] = 45,
                ["G1"] = 120
            };
            Console.WriteLine("Our dictionary ");
            foreach (KeyValuePair<string, int> item in group1)
            {
                Console.WriteLine($"{item.Key,-10}  {item.Value,5}");
            }
        }
    }
}



