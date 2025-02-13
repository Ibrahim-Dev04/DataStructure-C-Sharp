//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructure_C_
//{
//    internal class Arrays7_LINQ_aggregation_Filtering
//    {
//        static void Main(string[] args)
//        {

//            //Array of elements
//            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 ,8,9};

//            //filtering to get only even numbers

//            var evenNumbers = numbers.Where(n => n % 2 == 0);

//            // Aggregating - calculating the sum of even numbers


//            int EvenNumbersSum = evenNumbers.Sum();

//            // Displaying the results
//            Console.WriteLine("Even Numbers:");
//            foreach (var num in evenNumbers)
//            {
//                Console.Write(num + " ");
//            }
//            Console.WriteLine($"\nSum of Even Numbers: {EvenNumbersSum}");

//            Console.ReadKey();
//        }
//    }
//}
