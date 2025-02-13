//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.Serialization.Formatters;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructure_C_
//{
//    internal class Arrays6_AdvancedLINQ
//    {
//        static void Main(string[] args)
//        {

//            var People = new[]
//            {
//                new {Name = "Alice"   ,Age = 30,Salary = 1000},
//                new {Name = "Bob"     ,Age = 20,Salary = 1500},
//                new {Name = "Charlie" ,Age = 20,Salary = 1000},
//                new {Name = "Diana"   ,Age = 30,Salary = 1500},
//                new {Name = "Ethan"   ,Age = 30,Salary = 1000},
//                new {Name = "Ibrhaim" ,Age = 25,Salary = 1500},
//                new {Name = "Ayoub"   ,Age = 25,Salary = 1000},
//            };

//            // Grouping people by Age, then ordering within each group

//            var GroupedPeopleByAge = People
//                              .GroupBy(p => p.Age)
//                              .Select(group => new { Age = group.Key, People = group.OrderBy(p => p.Name) });

//            foreach (var group in GroupedPeopleByAge)
//            {
//                Console.WriteLine("People with Age :" + group.Age);
//                foreach(var Person in group.People)
//                {
//                    Console.WriteLine($" - {Person.Name}");
//                }
//            }


//            // Grouping people by salary, then ordering within each group

//            var GroupedPeopleBySalary = People
//                                        .GroupBy(P =>P.Salary)
//                                        .Select(group => new {Salary = group.Key, People = group.OrderByDescending(p => p.Name) });


//            foreach (var group in GroupedPeopleBySalary)
//            {
//                Console.WriteLine("\n\nPeople with Salary :" + group.Salary);
//                foreach (var Person in group.People)
//                {
//                    Console.WriteLine($" - {Person.Name}");
//                }
//            }
//            Console.ReadKey();
//        }
//    }
//}
