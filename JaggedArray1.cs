//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructure_C_
//{
//    internal class JaggedArray1
//    {
//        static void Main(string[] args)
//        {
//            int[][] JaggedArray = new int[3][];
//            JaggedArray[0] = new int[] { 1,4,5,6,7};
//            JaggedArray[1] = new int[] { 0, 2, 4, 6 };
//            JaggedArray[2] = new int[] { 312, 234  };

//            //display the array elements

//            for (int i = 0; i < JaggedArray.Length; i++)
//            {
//                for (int j = 0; j < JaggedArray[i].Length; j++)
//                {
//                    Console.Write(JaggedArray[i][j] + " ");
//                }
//                Console.WriteLine();
//            }

//            string[][] ArraysOfNames = new string[5][];

//            ArraysOfNames[0] = new string[] { "Ibrahim", "khadija", "Said", "Saad" };
//            ArraysOfNames[1] = new string[] { "Samir", "Joe", "Richard"};
//            ArraysOfNames[2] = new string[] { "Michel"};
//            ArraysOfNames[3] = new string[] { "Sarah", "Kawtar"};
//            ArraysOfNames[4] = new string[] { "Rochdi", "Hamza", "Mohammed", "Mahmoud","Safir" };

//            for (int i = 0; i < ArraysOfNames.Length; i++)
//            {
//                for (int j = 0; j < ArraysOfNames[i].Length; j++)
//                {
//                    Console.Write(" - " + ArraysOfNames[i][j] );
//                }
//                Console.WriteLine();
//            }
//            Console.ReadKey();
//        }
//    }
//}
