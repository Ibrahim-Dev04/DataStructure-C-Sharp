//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace DataStructure_C_
//{
////    Implementing Linked List in C#:
////         In C#, you can create your own linked list implementation or use the LinkedList<T> class
////         from the System.Collections.Generic namespace to implement a linked list.

////Basic Operations:

////Insertion   : Insert an element into the linked list.
////Deletion    : Remove an element from the linked list.
////Traversal   : Iterate through the elements of the linked list.
////Search      : Find a specific element in the linked list.
//    internal class LinkedList1
//    {
//        static void Main(string[] args)
//        {
//            LinkedList<int> LinkedList = new LinkedList<int>();

//            LinkedList.AddLast(1);
//            LinkedList.AddLast(2);
//            LinkedList.AddLast(3);
//            LinkedList.AddLast(4);
//            LinkedList.AddLast(5);
//            LinkedList.AddLast(6);

//            //traversal

//            foreach(int i in LinkedList)
//            {
//                Console.WriteLine(i);
//            }

//            //Deletion

//            LinkedList.Remove(2);


//            Console.WriteLine("\n\nAfter removing element 2 :");
//            foreach (int i in LinkedList)
//            {
//                Console.WriteLine(i);
//            }

//            //Search
//            if (LinkedList.Contains(2))
//            {
//                Console.WriteLine("Element 2 found.");
//            }
//            else
//            {
//                Console.WriteLine("Element  2 not found.");
//            }

//            Console.ReadKey();
//        }
//    }
//}
