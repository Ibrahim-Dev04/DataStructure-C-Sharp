//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructure_C_
//{
//    internal class Queue1
//    {

//        static void Main(string[] args)
//        {

//            Queue<string> Q1 = new Queue<string>();

//            Q1.Enqueue("Ibrahim");
//            Q1.Enqueue("Khadija");
//            Q1.Enqueue("Salim");
//            Q1.Enqueue("Said");

//            Console.WriteLine($"First element in the queue  : {Q1.Peek()}");

//            Console.WriteLine($"Served : {Q1.Dequeue()}");

//            Console.WriteLine("\n\nqueue elements after dequeue the first element:");
//            foreach(var element in  Q1)
//            {
//                Console.WriteLine(element);
//            }

//            //checking if the queue empty 

//            if (Q1.Count == 0)
//                Console.WriteLine("queue is empty");
//            else
//                Console.WriteLine($"first line : {Q1.Peek()}");

//            //Clearing the queue

//            Q1.Clear();

//            Console.ReadKey();
//        }

//    }
//}
