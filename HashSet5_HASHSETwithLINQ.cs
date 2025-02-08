//using System;
//using System.Collections.Generic;
//using System.ComponentModel.Design;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructure_C_
//{
//    internal class HashSet5_HASHSETwithLINQ
//    {
//        static void Main(string[] args)
//        {

//            HashSet<string> Cars = new HashSet<string>
//             {
//                 "Mazeraty",
//                 "BMW",
//                 "Mercedes",
//                 "Range-Rover",
//                 "Mercedes-Benz",
//                 "Renault",
//                 "Peugeot",
//                 "Dacia",
//                 "Audi"
//             };

//            Console.WriteLine("Cars : " + string.Join(",", Cars));

//            //combined linq query on Hashset

//            //select Cars Over Five Letters and Start with R or M 
//            var CarsOverFiveLetters =
//                from cars in Cars
//                where (cars.Length > 5 && (cars.StartsWith("M") || cars.StartsWith("R")))
//                orderby(cars)
//                select cars;
//            //using another syntax
//            var CarsOverFiveLetters2 = Cars.Where(caritem => caritem.Length > 5 && (caritem.StartsWith("M") || caritem.StartsWith("R")))
//                                         .OrderByDescending(Item => Item)
//                                         .Select(item => item);
//            //print result

//            Console.WriteLine("\n\nfiltred Cars 1 with the first linq syntx : " + string.Join(",", CarsOverFiveLetters));
//            Console.WriteLine("\n\nfiltred Cars 2 with the second linq syntx : " + string.Join(",", CarsOverFiveLetters2));


//            Console.ReadKey(); 
//        }

//    }
//}
