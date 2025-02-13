//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructure_C_
//{
//    internal class JaggedArray2_workingWithLINQ
//    {
//        static void Main(string[] args)
//        {
//            string[][] ArraysOfNames = new string[5][];

//            ArraysOfNames[0] = new string[] { "Ibrahim", "khadija", "Said", "Saad" };
//            ArraysOfNames[1] = new string[] { "Samir", "Joe", "Richard" };
//            ArraysOfNames[2] = new string[] { "Michel" };
//            ArraysOfNames[3] = new string[] { "Sarah", "Kawtar" };
//            ArraysOfNames[4] = new string[] { "Rochdi", "Hamza", "Mohammed", "Mahmoud", "Safir" };

//            for (int i = 0; i < ArraysOfNames.Length; i++)
//            {
//                for (int j = 0; j < ArraysOfNames[i].Length; j++)
//                {
//                    Console.Write(" - " + ArraysOfNames[i][j]);
//                }
//                Console.WriteLine();
//            }

//            var FilteredArray = ArraysOfNames.SelectMany(SubArray => SubArray).Where(Name => Name.StartsWith("M"));

//            Console.WriteLine("\n\nNames started with M : " + string.Join(" - ", FilteredArray));

//            //flatten the jagged Array into a single list

//            var FlattenArray = ArraysOfNames.SelectMany(Array => Array);

//            Console.WriteLine("\n\nflatten array : " + String.Join(" - ",FlattenArray));


//            // Declare and initialize a jagged array
//            int[][] jaggedArray = {
//            new int[] { 1, 2, 3 },
//            new int[] { 4, 5, 6 },
//            new int[] { 7, 8, 9, 10 }
//        };

//            // Flatten the jagged array and sum all elements

//            int TotalSum = jaggedArray.SelectMany(Array => Array).Sum();

//            Console.WriteLine("Total sum of jagged array : " + TotalSum);

//            // Filter arrays having more than 3 elements and select their first element

//            var FirstElements = jaggedArray.Where(SubArray => SubArray.Length > 3)
//                                           .Select(SubArra => SubArra.First());

//            Console.WriteLine("\nfirst element of Array where length more that 3 : "  + string.Join(",",FirstElements)); 

//            Console.ReadKey();
//        }
//    }
//}
