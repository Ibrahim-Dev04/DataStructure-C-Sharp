//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructure_C_
//{
//    internal class SortedSet3_Union_Intersection_Difference_Subset_SuperSet__equality
//    {
//        static void Main(string[] args)
//        {

//            SortedSet<int> S1 = new SortedSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 12, 23, 23, 235, 23, 25, 27, 34 };
//            SortedSet<int> S2 = new SortedSet<int>() { 1, 2, 3, 4, 5, 6, 7 };
//            SortedSet<int> S3 = new SortedSet<int>() { 7, 9, 10, 11, 5, 6, 7 };
//            SortedSet<int> S4 = new SortedSet<int>() { 7, 9, 10, 11, 5, 6, 7 };

//            Console.WriteLine("\ns1  : " + string.Join(",", S1));
//            Console.WriteLine("\ns2  : " + string.Join(",", S2));
//            Console.WriteLine("\ns3  : " + string.Join(",", S3));

//            //isSubset , isSuperSet
//            Console.WriteLine("\nis s2 a subset of s1    :   " + S2.IsSubsetOf(S1));
//            Console.WriteLine("\nis s1 a superset of s2  :   " + S1.IsSupersetOf(S2));

//            //UnionWith
//            S2.UnionWith(S3);
//            Console.WriteLine("\ns2 union s3             :   " + string.Join(",", S2));

//            //intersection
//            S2.IntersectWith(S3);
//            Console.WriteLine("\ns2 intersect with s3             :   " + string.Join(",", S2));

//            //Difference
//            //Except with
//            S1.ExceptWith(S3);
//            Console.WriteLine("\n S1 except with s3             :   " + string.Join(",", S1));

//            S1.SymmetricExceptWith(S3);
//            Console.WriteLine("\n S1 SymmetricExceptWith  s3             :   " + string.Join(",", S1));

//            //Equality

//            Console.WriteLine("\n\ns3             :   " + string.Join(",", S3));

//            bool areSetsEqual = S3.SetEquals(S4);

//            if (areSetsEqual)
//            {
//                Console.WriteLine("\n\ns3 and s4 are equal.");
//            }
//            else
//            {
//                Console.WriteLine("\n\ns3 and s4 are not equal.");

//            }

//            Console.ReadKey();
//        }
//    }
//}
