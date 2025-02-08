using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Probelm 1

            int[] Numbers = new int[11] { 0,1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            //print actual array elements
            Console.WriteLine("Filtred arra :  " + string.Join(", ", Numbers));


            //filtring array 
            var FiltredArr =
                from Num in Numbers
                where (Num % 2 == 0)
                select Num;

         

            //print filtered array

            Console.WriteLine("Filtred arra :  " + string.Join(", ", FiltredArr));

            Console.ReadKey();
        }
    }
}
