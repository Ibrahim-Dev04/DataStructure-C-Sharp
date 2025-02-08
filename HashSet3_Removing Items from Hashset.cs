//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructure_C_
//{
//    internal class HashSet3_Removing_Items_from_Hashset
//    {
//        static void Main(string[] args)
//        {


//            HashSet<string> Cars = new HashSet<string>
//            {
//                "Mazeraty",
//                "BMW",
//                "Mercedes",
//                "Range-Rover"
//            };

//            //Removing an item from the Hashset

//            Cars.Remove("Mercedes");

//            Console.WriteLine("HsCars :  " + string.Join(",", Cars));


//            //remove all Items in hashset
//             Cars.Clear();

//            if(Cars.Count == 0)
//                Console.WriteLine("HsCars is empty");
//            else
//            Console.WriteLine("HsCars :  " + string.Join(",", Cars));


//            Console.ReadKey();
//        }
//    }
//}
