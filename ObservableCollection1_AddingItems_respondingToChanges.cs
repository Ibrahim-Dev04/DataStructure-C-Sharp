//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructure_C_
//{
//    internal class ObservableCollection1_AddingItems_respondingToChanges
//    {
//       static void  Items_collectionchanged(object sender , System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
//        {

//            switch (e.Action)
//            {
//                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
//                    {
//                        Console.WriteLine("\n Added: ");
//                        foreach (var item in e.NewItems)
//                        {
//                            Console.WriteLine(" + " + item);
//                        }
//                    }
//                    break;
//                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
//                    {
//                        Console.WriteLine("\nremoved");
//                        foreach (var item in e.OldItems)
//                        {
//                            Console.WriteLine(" + " + item);
//                        }
//                    }

//                    break;
//                case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
//                    {
//                        Console.WriteLine("\nreplaced");
//                        foreach (var item in e.OldItems)
//                        {
//                            Console.WriteLine(" + " + item);
//                        }
//                        Console.WriteLine("\nWith:");
//                        foreach (var newItem in e.NewItems)
//                        {
//                            Console.WriteLine("- " + newItem);
//                        }
//                        break;
//                    }

//                    break;
//                case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
//                    {
//                        Console.WriteLine("\nelement Moved");
//                        Console.WriteLine($"- from index {e.OldStartingIndex} to index {e.NewStartingIndex}");
//                    }
           
//                    break;
//            };

//        }
//        static void Main(string[] args)
//        {

//            ObservableCollection<string> items = new ObservableCollection<string>();


//            //subscribing to the collectionChanged event

//            items.CollectionChanged += Items_collectionchanged;
//            //modifying the ObservableCollection
//            items.Add("Item 1");
//            items.Add("Item 2");
//            items.Add("Item 3");
//            items.Add("Item 4");
//            items.Add("Item 5");

//            Console.WriteLine("\n\ndisplaying elements of ObservableCollection");
//            foreach (var name in items)
//            {
//                Console.WriteLine(name);
//            }


//            items[0] = "replaced item";

//           //items.RemoveAt(4);

//           // items.Insert(4, "New Inserted Item");

//            items.Move(0, 3);
//            Console.WriteLine("\n\ndisplaying elements of ObservableCollection");
//            foreach (var name in items)
//            {
//                Console.WriteLine(name);
//            }

//            Console.WriteLine("accsess moved item : " + items[3]);
//            Console.ReadKey();

//        }
//    }
//}
