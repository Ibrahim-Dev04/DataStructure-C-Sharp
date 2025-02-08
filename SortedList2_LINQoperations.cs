//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructure_C_
//{
//    internal class SortedList2_LINQoperations
//    {
//        static void Main(string[] args)
//        {
//            SortedList<string, int> SlFruitBasket = new SortedList<string, int>();

//            SlFruitBasket.Add("Apple", 3);
//            SlFruitBasket.Add("Banana", 5);
//            SlFruitBasket.Add("Orange", 7);
//            SlFruitBasket.Add("Grape", 12);
//            SlFruitBasket.Add("Watermelon", 1);

//            //filter sorted list using combined queries of LINQ : get all items where quantity is greater than 5
//            var FilteredSList = SlFruitBasket
//                            .Where(Item => Item.Value > 5)
//                            .Select(Item => new {Item.Key, Item.Value });

//            Console.WriteLine("\nFiltered Slist : all items where quantity > 5 : ");
//            foreach (var item in FilteredSList)
//            {
//                Console.WriteLine($"Key = {item.Key}  ,  Value = {item.Value}");
//            }


//            //using query expression to filter this sortedlist : get all items where quantity under 7
//            var queryExpressionSyntax = from kvp in SlFruitBasket
//                                        where kvp.Value < 7
//                                        select kvp;
//            Console.WriteLine("\nFiltered Slist : all items where quantity < 7 : ");
//            foreach (var item in queryExpressionSyntax)
//            {
//                Console.WriteLine($"Key = {item.Key}  ,  Value = {item.Value}");
//            }

//            //filter sorted list by key : get list except element with Banana Key

//            string SpecificValue = "Banana";

//            var FilteredByKey = SlFruitBasket.Where(kvp => kvp.Key != SpecificValue);

//            Console.WriteLine("\nAll list without Banana element");

//            foreach (var item in FilteredByKey)
//            {
//                Console.WriteLine($"Key = {item.Key}  ,  Value = {item.Value}");
//            }
//            Console.ReadKey();
//        }
//    }
//}
