//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructure_C_
//{
//    internal class HashSet6_WorkwithUnion
//    {
//        static void Main(string[] args)
//        {
//            //example 1:
//            //defining two hashsets 
//            HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5 };
//            HashSet<int> set2 = new HashSet<int> { 4, 5, 6, 7, 8 };

//            //Union set1 with 2

//            set1.UnionWith(set2);

//            Console.WriteLine("Set1 union set2 = " + string.Join(",", set1));


//            //example 2: merge two sets of Contacts Numbers 

//            HashSet<string> hsContactNums1 = new HashSet<string> { "+212628580521", "+212666413046", "+21213891020" };
//            HashSet<string> hsContactNums2 = new HashSet<string> { "+212728581919", "+212628580521", "+212610101010", "+21261111111", "+212628581232" };

//            hsContactNums1.UnionWith(hsContactNums2);

//            Console.WriteLine("hsContactNums1 union hsContactNums1 = " + string.Join(",", hsContactNums1));

//            Console.ReadKey();
//        }

//    }
//}
