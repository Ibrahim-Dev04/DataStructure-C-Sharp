//using System;
//using System.Collections.Generic;
//using System.ComponentModel.Design;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructure_C_
//{
//    internal class SortedList3_AdvancedLINQusage
//    {
//        static void Main(string[] args)
//        {
//            SortedList<int, string> SlFruitBasket = new SortedList<int, string>();

//            SlFruitBasket.Add(1   , "Apple");
//            SlFruitBasket.Add(2   , "Banana");
//            SlFruitBasket.Add(7   , "Orange");
//            SlFruitBasket.Add(12  , "Grape");
//            SlFruitBasket.Add(3   , "Watermelon");
//            SlFruitBasket.Add(14  , "Cherry");
//            SlFruitBasket.Add(17  , "Date");
//            SlFruitBasket.Add(19  , "Fig");


//            // Problem 1 : grouping by the value's length 
//            var FruitsLength5 = SlFruitBasket.GroupBy(kvp => kvp.Value.Length );

//            foreach (var Group in FruitsLength5)
//            {
//                Console.WriteLine($"Length {Group.Key} : " +  string.Join("," ,Group.Select(kvp => kvp.Value)));
//            }


//            //Problem 2 : grouping by value ,for example groupe car models by Brand
//            SortedList<string, string> Cars = new SortedList<string, string>
//            {
//             { "Mercedes-Benz C-Class" ,"Mercedes-Benz"},
//             { "Mercedes-Benz GLC"     ,"Mercedes-Benz"},
//             { "Audi A4"               ,"Audi"},
//             { "Audi Q7"               ,"Audi"},
//             { "BMW 3 Series"          ,"BMW"},
//             { "BMW X5"                ,"BMW"},
//             { "Maserati Ghibli"       ,"Maserati"},
//             { "Maserati Levante"      ,"Maserati"},
//             { "Renault Clio"          ,"Renault"},
//             { "Renault Captur"        ,"Renault"}
//            };

//            var GoupedByBrand = Cars.GroupBy(kvp => kvp.Value);
//            Console.WriteLine("\n\nGrouped cars by brand : ");
//            foreach (var Group in GoupedByBrand) 
//            {
//                Console.WriteLine($" {Group.Key} : " + string.Join(" , ",Group.Select(kvp => kvp.Key)));
//            }


//            Console.ReadKey();
//        }
//    }
//}
