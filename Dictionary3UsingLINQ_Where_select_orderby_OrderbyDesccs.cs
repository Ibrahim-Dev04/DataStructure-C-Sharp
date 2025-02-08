using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_C_harp
{
    internal class Dictionary3UsingLINQ_Where_select_orderby_OrderbyDesccs
    {
    //    static void Main(string[] args)
    //    {
    //        Dictionary<string, int> fruitbasket = new Dictionary<string, int>
    //        {
    //            { "Apple",5},
    //            { "Banana",4},
    //            { "Orange",7},
    //            { "Lemon",9},
    //            { "Lime",8}

    //        };

    //        //using LINQ to transform items

    //        var Fruitinfo = fruitbasket.Select(kpv => new { kpv.Key, kpv.Value });

    //        //displaying the result
    //        Console.WriteLine("\nTransformed items : ");

    //        foreach (var item in Fruitinfo)
    //        {
    //            Console.WriteLine($"fruit : {item.Key}  , Quantity : {item.Value}");
    //        }

    //        //using linq to filter dictionary
    //        //get only fruit with quantity over 4

    //        var filteredFruit = fruitbasket.Where(kvp => kvp.Value > 4);
    //        var FruitKeyStartsWithL = fruitbasket.Where(kvp => kvp.Key.StartsWith("L"));

    //        Console.WriteLine("\n fruits quantity over 4 : ");

    //        foreach (var item in filteredFruit)
    //        {
    //            Console.WriteLine($"fruit : {item.Key}  , Quantity : {item.Value}");
    //        }

    //        Console.WriteLine("\n fruits Start with L: ");

    //        foreach (var item in FruitKeyStartsWithL)
    //        {
    //            Console.WriteLine($"fruit : {item.Key}  , Quantity : {item.Value}");
    //        }
    //        //sort dictionary using Orderby()
    //        fruitbasket.Add( "PineApple", 1 ) ;
    //        fruitbasket.Add("Strawbery", 15);
        
    //    var sorterDictionay = fruitbasket.OrderBy(kvp => kvp.Value);

    //        Console.WriteLine("\n sorter fruitbasket : ");

    //        foreach (var item in sorterDictionay)
    //        {
    //            Console.WriteLine($"fruit : {item.Key}  , Quantity : {item.Value}");
    //        }

    //        //order by desc

    //        var sortedDictionarybydesc = fruitbasket.OrderByDescending(kvp => kvp.Value);
    //        Console.WriteLine("\n sorter fruitbasket by desc: ");

    //        foreach (var item in sortedDictionarybydesc)
    //        {
    //            Console.WriteLine($"fruit : {item.Key}  , Quantity : {item.Value}");
    //        }

    //        //using linq to aggregate data

    //        int TotalQuantity = fruitbasket.Sum(kvp => kvp.Value);
    //        double AvrQuantity = fruitbasket.Average(kvp=> kvp.Value) ;
    //        int MinQuantity   = fruitbasket.Min(kvp => kvp.Value) ;
    //        int MaxQua = fruitbasket.Max(kvp => kvp.Value);

    //        Console.WriteLine($"\n\nFruitbasket count {fruitbasket.Count()}");
    //        Console.WriteLine($"fruits total quantity : {TotalQuantity}" );

    //        Console.WriteLine($"fruits avg            : {AvrQuantity}");

    //        Console.WriteLine($"Min quantity          : {MinQuantity}");

    //        Console.WriteLine($"max quantity           : {MaxQua}");
    //        Console.ReadKey();

    //    }
    }
}
