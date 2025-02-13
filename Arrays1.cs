//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructure_C_
//{
//    internal class Arrays1
//    {
//        static void Main(string[] args)
//        {

//            //Declaring an integer array
//            int[] Numbers = new int[5];

//            //Intitializing an array with values
//            string[] Names = { "Alice", "Ibrahim", "Khadija", "Morad","Badr" };

//            //display array elements
//            var NamesOrderByAsc = Names.OrderBy(item => item);
//            foreach(var name in Names)
//            {
//                Console.WriteLine(name);
//            }


//            Console.WriteLine("before modifiying element in index 0 : " + Names[0]);

//            //Accessing and modifiying elements
//            Names[0] = "Samiha";

//            Console.WriteLine("\nAfter modifiying element in index 0 : " + Names[0]);

//            for(int i =0;i < Names.Length; i++)
//            {
//                Console.WriteLine("\nElement at index " + i + ": " + Names[i]);
//            }

            
//            Console.ReadKey();
//        }

//    }
//}
