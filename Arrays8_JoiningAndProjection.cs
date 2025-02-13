//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructure_C_
//{
//    internal class Arrays8_JoiningAndProjection
//    {
//        static void Main(string[] args)
//        {
//            // Array of employees
//            var employees = new[]
//            {
//            new { Id = 1, Name = "Alice", DepartmentId = 2 },
//            new { Id = 2, Name = "Bob", DepartmentId = 1 }
//        };


//            // Array of departments
//            var departments = new[]
//            {
//            new { Id = 1, Name = "Human Resources" },
//            new { Id = 2, Name = "Development" }
//        };

//            var EmployeeDetails = employees.Join(departments,
//                                                  e => e.DepartmentId,
//                                                  d => d.Id,
//                                                  (e, d) => new { e.Name, Departement = d.Name }
//                                                  );

//            //displayin results
//            Console.WriteLine("\n Employee details:");
//            foreach (var E in EmployeeDetails)
//            {
//                Console.WriteLine($"{E.Name}  - {E.Departement}");
//            }
//            Console.ReadKey();
//        }
//    }
//}
