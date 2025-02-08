using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_C_harp
{
    internal class list3_Looping_through_a_list
    {
       /* static void Main(string[] args)
        {
            //looping using for loop

            List<int> list = new List<int> { 1,2,3,4,5,6,7,8,9,10};

            Console.WriteLine("print list elements usnig for loop\n");

            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            //looping using foreach loop
            Console.WriteLine("print list elements usnig foreach\n");
            foreach (int number in list)
            {
                Console.WriteLine(number);
            }

            //looping using list.foreach method (lambda expression)
            Console.WriteLine("print list elements usnig lambda expression foreach\n");
            list.ForEach(Number => Console.WriteLine(Number));


            //using lambda expression foreach : insert all list in a list2

            List<int> list2 = new List<int>();

            list.ForEach(Number => list2.Add(Number));

            Console.WriteLine("After copying all items from list to list 2 : \n");

            list2.ForEach(Number => Console.WriteLine(Number));

            //using lambda expression foreach : insert only even Numbers in list 3

            Console.WriteLine("aftet copying only even numbers into list 3 : \n\n");
            List<int> List3 = new List<int>();

            list2.ForEach(Number =>
            { if (Number % 2 == 0)
                    List3.Add(Number);
            });

            List3.ForEach(Number => Console.WriteLine(Number));

            Console.ReadKey();

        }*/
    }
}
