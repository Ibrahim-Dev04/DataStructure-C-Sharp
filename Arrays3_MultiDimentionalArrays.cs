//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructure_C_
//{

//    /*
      
//       Introduction to Multidimensional Arrays
//             Multidimensional arrays in C# allow you to store data in a format similar to a matrix, 
//                useful for representing complex data structures.

//       Concepts

//       Definition: Multidimensional arrays have more than one dimension, 
//                   such as a 2D array representing a matrix.
//       Declaration and Initialization: They are declared with multiple sets of square brackets.
//    */
//    internal class Arrays3_MultiDimentionalArrays
//    {
//        static void Main(string[] args)
//        {
//            //declaring a 2D array

//            int[,] matrix = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };

//            for(int i = 0; i < matrix.GetLength(0); i++)//GetLength(0) : gets the number of rows - 
//            {                                                  
//                for (int j = 0; j < matrix.GetLength(1); j++)//GetLength(1) : gets the number of columns
//                {
//                    Console.Write(matrix[i,j] + " ");
//                }
//                Console.WriteLine();
//            }

//            Console.ReadKey();
//        }
//    }
//}
