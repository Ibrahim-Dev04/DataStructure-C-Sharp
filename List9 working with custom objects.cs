using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_C_harp
{
    public class clsPerson
    {
        public string Name { get; set; }
        public byte  Age { get; set; }

        public clsPerson(string name, byte age)
        {
            Name = name;
            Age = age;
        }
    }

    internal class List9_working_with_custom_objects
    {
        
        //static void Main(string[] args)
        //{

        //    List<clsPerson> list = new List<clsPerson>
        //    {
        //     new clsPerson("Ibrahim",25),
        //     new clsPerson("Salma", 15),
        //     new clsPerson("Mohammed", 45),
        //     new clsPerson("Said", 15),
        //     new clsPerson("Ali", 23),
        //     new clsPerson("Ismail", 67)
        //    };

        //    Console.WriteLine($"Current state of the list:");
        //    foreach (clsPerson Person in list) 
        //    {
        //        Console.WriteLine($"name : {Person.Name} ,age : {Person.Age}");
        //    }

        //    //using find;

        //    clsPerson person = list.Find(P => P.Age == 25);

        //    if (person != null)
        //    {
        //        Console.WriteLine($"\nPerson with age 25 found ,  Name : {person.Name} , age : {person.Age}");
        //    }

        //    //finding and updating the age of the person named "Salma"

        //    clsPerson SearchResult = list.Find(P => P.Name == "Salma");

        //    if(SearchResult != null)
        //    {
        //        SearchResult.Age = 90;
        //        Console.WriteLine("salma's age updated to :  " + SearchResult.Age);
        //    }

        //    //finding using linq  FirstOrDefault()  and updating the age of the person named "Salma" 

        //    clsPerson Result = list.FirstOrDefault(P => P.Name == "Salma");

        //    if (Result != null)
        //    {
        //        Result.Age = 81;
        //        Console.WriteLine("salma's age updated to  :  " + Result.Age);
        //    }

        //    //findAll() persons with name starts with S and copy them into another list then print them

        //    List<clsPerson> NamesStartWithS = new List<clsPerson>();

        //    NamesStartWithS.InsertRange(0, list.FindAll(P => P.Name.StartsWith("S")));

        //    Console.WriteLine("All Names start with S :");

        //    NamesStartWithS.ForEach(P => Console.WriteLine($"Name : {P.Name} , Age {P.Age}"));

        //    //using Any

        //    bool containsAlis = list.Any(P => P.Name == "Ibrahim");
        //    Console.WriteLine("\n\nis there any Ibrahim name in the list : " + containsAlis);

        //    //remove all people under the age 30
        //    list.RemoveAll(P => P.Age < 30);
        //    Console.WriteLine("\n people under age 30 removed");
        //    //using Exist

        //    bool ExistsOver40 = list.Exists(P => P.Age > 40);
        //    Console.WriteLine("\n\n does any person in list over 40 exist ? : " + ExistsOver40);

        //    Console.WriteLine("\n\nthe final list with all updates: ");
        //    foreach (clsPerson Person in list)
        //    {
        //        Console.WriteLine($"name : {Person.Name} ,age : {Person.Age}");
        //    }
        //    Console.ReadKey();
        //}
    }
}
