//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructure_C_
//{
//    internal class Arrays9_Joining_Example2
//    {
//        static void Main(string[] args)
//        {

//            var Persons = new[]
//            {
//                new {Id = 1,Name = "Mohammed",Age = 23 },
//                new {Id = 2,Name = "Ibrahim" ,Age = 25 },
//                new {Id = 3,Name = "Reda",Age = 26 },
//                new {Id = 4,Name = "Kamal",Age = 27 },
//                new {Id = 5,Name = "Said",Age = 22 }
//            };


//            var Employees = new[]
//            {
//                new {Id = 1,Salary = 1000,PersonID = 1 },
//                new {Id = 2,Salary = 1200,PersonID = 2 },
//                new {Id = 3,Salary = 1300,PersonID = 3 },
//                new {Id = 4,Salary = 1400,PersonID = 4 },

//            };

//            //joining Persons with Employees and projecting result

//            var EmployeeDetails = Employees.Join(Persons,
//                                                E => E.PersonID,
//                                                P => P.Id,
//                                            (E, P) => new { E.Id, E.Salary, EmployeeName = P.Name, EmployeeAge = P.Age }

//                );


//            //displaying results
//            Console.WriteLine($"\nEmployees details : ");

//            foreach (var employee in EmployeeDetails)
//            {
//                Console.WriteLine($"\n\nID: {employee.Id} - Name : {employee.EmployeeName} - " +
//                    $"Age : {employee.EmployeeAge} - Salary : {employee.Salary}");
//            }

//            Console.ReadKey();  
//        }
//    }
//}
