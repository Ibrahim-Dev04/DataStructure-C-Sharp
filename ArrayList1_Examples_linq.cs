//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Collections.Specialized;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Runtime.Serialization.Formatters;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructure_C_
//{
//    internal class ArrayList1_Examples_linq
//    {
//        static void Main(string[] args)
//        {
//            //ArrayList list = new ArrayList();

//            //list.Add(8);
//            //list.Add("Ibrahim");
//            //list.Add(true);
//            //list.Add('a');
//            //list.Add(1.23);
//            //list.Add(1);

//            ////Iterate over all list elements 

//            //foreach (var item in list)
//            //{
//            //    Console.WriteLine(item);
//            //}
//            ////remove an item

//            //list.Remove(1);

//            //Console.WriteLine("\n\ndisplaying list after removing element with value 1");

//            //for (int i =0; i < list.Count;i++)
//            //{
//            //    Console.WriteLine(list[i]);
//            //}


//            //Working with LINQ 

//            ArrayList ArrList = new ArrayList{10,4,3,2,5,6,7,8,9,2,2,1};
            

//            Console.WriteLine("\n\narrList elements : ");

//            foreach (var item in ArrList)
//            {
//                Console.WriteLine(item);
//            }

//            var FilteredList = ArrList.Cast<int>().Where(n => n % 2 != 0);

//            Console.WriteLine("\n\nFiltered arrList elements : ");
//            foreach(var item in FilteredList)
//            {
//                Console.WriteLine(item);
//            }

//            //Aggregate functions with ArrList
//            var MaxVal = ArrList.Cast<int>().Max();
//            var MinVal = ArrList.Cast<int>().Min();
//            var sum    = ArrList.Cast<int>().Sum();
//            var Avg    = ArrList.Cast<int>().Average();
//            var count  = ArrList.Cast<int>().Count();

//            Console.WriteLine($"Max  :  {MaxVal}");
//            Console.WriteLine($"Min  :  {MinVal}");
//            Console.WriteLine($"Sum  :  {sum}");
//            Console.WriteLine($"avg  :  {Avg}");
//            Console.WriteLine($"count : {count}");

//            //sorting arrlist

//            ArrList.Sort();
//            Console.WriteLine("\n\n sorted arrlist");
//            foreach (var item in ArrList)
//            {
//                Console.WriteLine(item);
//            }

//            //count occurrences : count how many times an element repeated in arrlist

//            int TargetNumber = 2;

//            var Count = ArrList.Cast<int>().Count(num => num == TargetNumber);
//            var EvenNumberscount = ArrList.Cast<int>().Count(num => num % 2 == 0);

//            Console.WriteLine($"\nNumber of Occurrences  of {TargetNumber} =  {Count}");

//            Console.WriteLine($"\nNumber Even numbers in arrlist =  {EvenNumberscount}");
//            Console.ReadKey();      
//        }
//    }
//}
