//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructure_C_
//{
//    public class Person : IComparable<Person>
//    {
//        public int ID { get; }
//        public string FullName { get; set; }
//        public byte Age { get; set; }

//        public Person(int ID, string fullname, byte age)
//        {
//            this.ID = ID;
//            FullName = fullname;
//            Age = age;
//        }
//        public int CompareTo(Person other)
//        {
//            if (other == null) return 1;  // Handle null case

//            // Define sorting logic (e.g., sort by FullName alphabetically)
//            return ID.CompareTo(other.ID);
//        }
//    }

//    internal class SortedSet1_WorkingWithSortedSet
//    {

//        static void Main(string[] avgs)
//        {
//            //Example 1:
//            /*SortedSet<Person> PeopleList = new SortedSet<Person>
//              {
//                  new Person(1,"Ibrahim chariai",25),
//                  new Person(2,"Said Ibn-alkhattab",26),
//                  new Person(3,"Khadija chariai",27),
//                  new Person(4,"Fadwa",28),
//                  new Person(5,"Khawla",29),
//                  new Person(6,"Salim",30),
//                  new Person(7,"Rachid",31)
//              };

//              foreach(var Person in  PeopleList) 
//              {
//                  Console.WriteLine($"{Person.ID}  -  {Person.FullName}  - {Person.Age}");
//              }*/

//            //Example 2:
//            SortedSet<int> ints = new SortedSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 12, 23, 23, 235, 23, 25, 27, 34 };


//            Console.WriteLine("Set  : " + string.Join(",", ints));



//            //problem1 : filter a list only keep Even numbers 

//            var FilteredList = ints.Where(i => i % 2 == 0);

//            Console.WriteLine("\n\nFiltered set with only even numbers: " + string.Join(",", FilteredList));


//            //problem2 : filter a list only keep numbers greater than 10 and odd numbers

//            var ODDNumbersOverTen = ints.Where(n => n % 2 != 0 && n > 10);
//            Console.WriteLine("\n\nFiltered set of ODD numbers greater than ten: " + string.Join(",", ODDNumbersOverTen));

//            //problem 3: sum all elemnts in the set

//            int SetSum = ints.Sum();
//            Console.WriteLine("set sum Of all elements = "  + SetSum);

//            //problem 4: sum only even numbers

//            int SetSumEvenNumbers = ints.Where(i => i % 2 == 0).Sum();
//            Console.WriteLine("set sum Of even numberes= " + SetSumEvenNumbers);

//            //problem 5 : sum only ODD numbers
//            int SetSumODDNumbers = ints.Where(i => i % 2 != 0).Sum();
//            Console.WriteLine("set sum Of even numberes= " + SetSumODDNumbers);

//            //problem  6 : get max of the sortedset

//            int MaxNum = ints.Max();
//            int MinNum = ints.Min();

//            Console.WriteLine("set Max = " + MaxNum);
//            Console.WriteLine("set Min = " + MinNum);

//            //problem 7 : Order sortedset by desc

//            var Orderedsetbydesc = ints.OrderByDescending(n => n);
//            Console.WriteLine("\n\n Ordered set by desc: " + string.Join(",", Orderedsetbydesc));
            
//            //problem 8 : find even numbers and project them on theire square

//            var evenNumbersSquared = ints.Where(n=> n % 2 == 0).Select(n => n*n);
//            Console.WriteLine("\n\n squares of even numbers in set: " + string.Join(",", evenNumbersSquared));

//            Console.ReadKey();
//        }
//    }
//}

