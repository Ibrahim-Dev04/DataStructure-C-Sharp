//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructure_C_
//{
//    internal class HashSet8_ExceptWith
//    {
//        static void Main(string[] args)
//        {
//            //Exceptwith : it remove the common elements bwteen two sets from a set
//            //example 1
//            HashSet<string> hsNames = new HashSet<string> { "Fadwa", "Khadija", "Ibrahim" };
//            HashSet<string> hsNames2 = new HashSet<string> { "Ibrahim", "Fadwa", "Sara" };



//            hsNames2.ExceptWith(hsNames);

//            Console.WriteLine("hsNames : " + string.Join(",", hsNames2));

//            //example 2:
//            HashSet<int> NumSet1 = new HashSet<int> { 1, 2, 3 };
//            HashSet<int> NumSet2 = new HashSet<int> { 3, 4, 5 };

//            NumSet1.ExceptWith(NumSet2);

//            Console.WriteLine("NumSet 1 : " + string.Join(",", NumSet1));


//            Console.ReadKey();
//        }
//    }
//}
