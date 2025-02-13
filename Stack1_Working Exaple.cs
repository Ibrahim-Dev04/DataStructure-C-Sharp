//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Mail;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace DataStructure_C_
//{
//    internal class Stack1_Working_Exaple
//    {

//        static void Main(string[] args)
//        {

//            Stack<string> names = new Stack<string>();

//            names.Push("Ibrahim");
//            names.Push("Khadija");
//            names.Push("Zakaria");
//            names.Push("Joe");
               
//            foreach(string name in names)
//            {
//                Console.WriteLine(name);
//            }

//            names.Pop();
//            Console.WriteLine("after removing the top elemenet form stack : ");

//            foreach (string name in names)
//            {
//                Console.WriteLine(name);
//            }

//            Console.WriteLine("Top element : " + names.Peek()); 
  
//            //clearing stack
//           names.Clear();


//            //checking stack is empty

//            if(names.Count == 0)
//            {
//                Console.WriteLine("names stack is empty");
//            }
//            else
//            {
//                Console.WriteLine("stack is not empty");
//            }

//            Console.ReadKey();
//        }
//    }
//}
