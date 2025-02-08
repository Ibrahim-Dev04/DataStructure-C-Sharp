//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Web;

//namespace DataStructure_C_
//{
//    public class Employee
//    {
//        public string Name { get; set; }
//        public decimal Salary { get; set; }

//        public string Department { get; set; }
//        public Employee(string Name,decimal salary, string department)
//        {
//            Salary = salary;
//            Department = department;
//            this.Name = Name;
//        }
//    }

//    internal class SortedList4_ComplexObjOperationsUsingLINQ
//    {
//        static void Main(string[] args)
//        {
//            SortedList<int, Employee> SLEmployees = new SortedList<int, Employee>
//            {
//                {1,new Employee("Ibrahim",2000,"Back-end")},
//                {2,new Employee("Fadwa",1000,"Testing")},
//                {3,new Employee("Ammar",2000,"System analyses")},
//                {4,new Employee("Jack",1200,"IT")},
//                {5,new Employee("Khadija",2000,"IT")}
//            };

//            //combined querie : filter list where Department is IT and sort elements by desc

//            var Filteredlist = SLEmployees
//                                .Where(kvp => kvp.Value.Department == "IT")
//                                .OrderByDescending(kvp => kvp.Value.Salary)
//                                .Select(kvp => kvp.Value.Name);

//            Console.WriteLine("\n IT department employees sorted by salary (descensing)");

//            foreach(var name in Filteredlist)
//            {
//                Console.WriteLine(name);
//            }


//            //get sum of salary in the same department

//            var sumSalary = SLEmployees
//                                .Where(kvp => kvp.Value.Department == "IT")
//                                .Sum(kvp => kvp.Value.Salary);
//            Console.WriteLine("salary = " +  sumSalary);


//            //get avr of salary in the same department

//            var avrITsalarty = SLEmployees
//                                .Where(kvp => kvp.Value.Department == "IT")
//                                .Average(kvp => kvp.Value.Salary);

//            Console.WriteLine("avg = " + avrITsalarty);

//            Console.ReadKey();
//        }
//    }
//}
