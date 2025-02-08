//using System;
//using System.Collections.Generic;
//using System.Linq;
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

//            //SortedSet<Person> PeopleList = new SortedSet<Person>
//            //{
//            //    new Person(1,"Ibrahim chariai",25),
//            //    new Person(2,"Said Ibn-alkhattab",26),
//            //    new Person(3,"Khadija chariai",27),
//            //    new Person(4,"Fadwa",28),
//            //    new Person(5,"Khawla",29),
//            //    new Person(6,"Salim",30),
//            //    new Person(7,"Rachid",31)
//            //};

//            //foreach(var Person in  PeopleList) 
//            //{
//            //    Console.WriteLine($"{Person.ID}  -  {Person.FullName}  - {Person.Age}");
//            //}

//            //Example 2:
//            SortedSet<int> ints = new SortedSet<int>();

//            ints.Add(100);
//            ints.Add(13);
//            ints.Add(12);
//            ints.Add(11);
//            ints.Add(3009);

//            Console.WriteLine("Soted elements  : ");

//            foreach (int i in ints)
//            {
//                Console.WriteLine(i);
//            }

//            //check if an element exists using Contains()

//            int Target = 11;

//            if (ints.Contains(1))
//                Console.WriteLine($"\n Number {Target} exists in the sorted list");
//            else
//                Console.WriteLine($"\n Number {Target} is not exist in the sorted list");

//            //remove an element from the sorted list

//            ints.Remove(11);

         

//            Console.WriteLine("Soted elements  after remove element with value 11: ");

//            foreach (int i in ints)
//            {
//                Console.WriteLine(i);
//            }

//            Console.ReadKey();
//        }
//    }
//} 

