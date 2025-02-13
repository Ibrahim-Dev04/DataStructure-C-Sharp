//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructure_C_
//{
//    internal class Arrays2_Sorting_Searching
//    {
//        static void Main(string[] args)
//        {
//            string[] Names = { "Alice", "Ibrahim", "Khadija", "Morad", "Badr" };

//            Console.WriteLine("\n Array :");
//            Array.ForEach(Names, x => Console.WriteLine($"{x}"));

//            //Sorting

//            Array.Sort(Names);

//            Console.WriteLine("\n After sorting array by Asc:");
//            Array.ForEach(Names, x => Console.WriteLine($"{x}"));


//            //Searching for an element ,this will return the index for element you searched for

//            int index = Array.IndexOf(Names, "Ibrahim");

//            Console.WriteLine("\nIndex of Ibrahim : " + index);

//            Console.ReadKey();
//        }

//    }
//}
