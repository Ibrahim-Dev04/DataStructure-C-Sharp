//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructure_C_
//{
//    internal class Tuples2_LINQ
//    {
//        static void Main(string[] args)
//        {
//            //Find all students who scored more than 80.

//            var students = new List<(string Name, int Score)>
//            {
//                ("Alice", 85),
//                ("Bob", 90),
//                ("Charlie", 78),
//                ("David", 95),
//                ("Eve", 70)
//            };


//            var ScoredMoreThan80 = students.Select(Student => Student).Where(Student => Student.Score > 80);

//            foreach (var student in ScoredMoreThan80)
//            {
//                Console.WriteLine($"name : {student.Name}  -  Scored : {student.Score}" );

//            }

//            //Problem 2
           
//            var products = new List<(string Name, double Price)>
//            {
//                ("Laptop", 1200.99),
//                ("Phone", 699.99),
//                ("Tablet", 399.99),
//                ("Monitor", 199.99)
//            };

//            //Sort a list of products by price.

//            var SortedByPrice = products.OrderBy(Product => Product.Price);

//            Console.WriteLine("\nSorted Products list by Ascending :");

//            foreach (var Product in SortedByPrice)
//            {
//                Console.WriteLine($"{Product.Name}   -  {Product.Price}");
//            }


      
//            //problem 3:
//            var employees = new List<(string Name, string Department, int Salary)>
//            {
//                ("Alice", "IT", 5000),
//                ("Bob", "HR", 4500),
//                ("Charlie", "Finance", 6000)
//            };

//            //Extract only the names of employees from a list of tuples.

//            var EmployeesNames = employees.Select(Employee => Employee.Name);

//            Console.WriteLine("\n\nEmployees Names : ");
//            foreach (var Name in EmployeesNames)
//            {
//                Console.WriteLine($"Name : {Name}");
//            }

//            Console.ReadKey();
//        }
//    }
//}
