//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructure_C_
//{
//    internal class SortedDictionary1_Example
//    {
//        static void Main(string[] args)
//        {
//            SortedDictionary<string, int> Fruits = new SortedDictionary<string, int>();

//            Fruits.Add("Apple", 5);
//            Fruits.Add("Orange", 3);
//            Fruits.Add("Lemon", 2);
//            Fruits.Add("Banana", 9);

//            Console.WriteLine("Contents of the Sorted dictionary");

//            foreach (var Items in Fruits)
//            {
//                Console.WriteLine($"{Items.Key} --> Quantity :{Items.Value}");
//            }

//            //accessing values by key

//            Console.WriteLine("\n\nvalue of Apple : " + Fruits["Apple"]);
//            Console.WriteLine("value of Lemon : " + Fruits["Lemon"]);

//            //check if an element exists by key

//            Console.WriteLine("Contains banana ? : " + Fruits.ContainsKey("Banana"));
//            Console.WriteLine("Contains banana ? : " + Fruits.ContainsKey("grape"));

//            //removing an element 

//            Fruits.Remove("Banana");

//            //displaying elements after removing the element Banana 
//            Console.WriteLine("\n\nContents of the Sorted dictionary after removal : ");

//            foreach (var Items in Fruits)
//            {
//                Console.WriteLine($"{Items.Key} --> Quantity :{Items.Value}");
//            }



//            Console.ReadKey();
//        }

//    }
//}
