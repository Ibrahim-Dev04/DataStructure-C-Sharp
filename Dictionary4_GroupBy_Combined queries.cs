using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_C_harp
{
    internal class Dictionary4_GroupBy_Combined_queries
    {
       //static void Main(string[] args)
       // {

       //     Dictionary<string, string> FruitsCategory = new Dictionary<string, string>
       //     {
       //         { "Apple","Tree"},
       //         { "Banana","Herb"},
       //         { "Cherry","Tree"},
       //         { "Strawbery","Bush"},
       //         { "Resbery","Bush"}
       //     };

       //     var GroupedFruits = FruitsCategory.GroupBy(kvp => kvp.Value);

       //     foreach (var group in GroupedFruits)
       //     {
       //         Console.WriteLine($"\nCatergory : {group.Key}");

       //         foreach (var fruit in group)
       //         {
       //             Console.WriteLine("- " + fruit.Key);
       //         }
       //     }

       //     //group by with Cars example

       //     Dictionary<string, string> Cars = new Dictionary<string, string>
       //     {
       //         { "Mercedes-Benz C-Class" ,"Mercedes-Benz"},
       //         { "Mercedes-Benz GLC"     ,"Mercedes-Benz"},
       //         { "Audi A4"               ,"Audi"},
       //         { "Audi Q7"               ,"Audi"},
       //         { "BMW 3 Series"          ,"BMW"},
       //         { "BMW X5"                ,"BMW"},
       //         { "Maserati Ghibli"       ,"Maserati"},
       //         { "Maserati Levante"      ,"Maserati"},
       //         { "Renault Clio"          ,"Renault"},
       //         { "Renault Captur"        ,"Renault"}

       //     };

       //     var GroupedCars = Cars.GroupBy(kvp => kvp.Value);

       //     foreach(var Group in GroupedCars)
       //     {
       //         Console.WriteLine($"\nCategory : {Group.Key}");

       //         foreach (var car in Group)
       //         {
       //             Console.WriteLine($"-> {car.Key}");
       //         }
       //     }

       //     //combined linq queries

       //     var sortedFilteredCars = Cars
               
       //         .Where(kvp => kvp.Key.StartsWith("M"))
       //         .OrderByDescending(kvp => kvp.Key)
       //         .Select(kvp => kvp)//here .select return the filtered and sorted result and assign it into sortedfilteredCars
       //         ;

       //     //print sortedFilteredCars
       //     Console.WriteLine("\n\nSortedFilered Cars : ");
       //     foreach (var car in sortedFilteredCars)
       //     {
       //         Console.WriteLine($"Module : {car.Key} , Category : {car.Value}" );
       //     }
    
       //     Console.ReadKey();
       // }
    }
}
