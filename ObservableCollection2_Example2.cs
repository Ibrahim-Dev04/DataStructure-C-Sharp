//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructure_C_
//{
//    internal class ObservableCollection2_Example2
//    {

//        static void Main(string[] args)
//        {
//            ObservableCollection<string> Fruits = new ObservableCollection<string>();

//            Fruits.CollectionChanged += (sender, e) =>
//            {
//                if (e.NewItems == null)
//                    return;

//                foreach (var item in e.NewItems)
//                {
//                    Console.WriteLine($"\n{e.Action}  ==> {item}");
//                }
//            };
         

            
           
//            Fruits.Add("Apple");
//            Fruits.Add("Orange");
//            Fruits.Add("Lemon");
//            Fruits.Add("Grape");

//            Fruits.RemoveAt(0);

//            Console.WriteLine($"\nafter removing item in index 0 ,item in index 0 became : {Fruits[0]}");

//            Fruits[0] = "Pineapple";

//            Fruits.Move(0, 2);



//            Console.ReadKey();
//        }
//    }
//}
