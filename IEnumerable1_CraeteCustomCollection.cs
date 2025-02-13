//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Security.Permissions;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructure_C_
//{

//    public class CustomeCollection<T> : IEnumerable<T>
//    {
//        private List<T> _Items = new List<T>();

//        public IEnumerator<T> GetEnumerator()
//        {
//            for(int i = 0; i < _Items.Count; i++)
//            {
//                yield return _Items[i]; 
//            }
//        }

//         IEnumerator IEnumerable.GetEnumerator()
//        {
//            return GetEnumerator();
//        }

//        public void Add(T item)
//        {
//            _Items.Add(item);
//        }
//    }

//    internal class IEnumerable1_CraeteCustomCollection
//    {
//        static void Main(string[] args)
//        {
            
//            CustomeCollection<string> Strings  = new CustomeCollection<string>();

//            Strings.Add("Hamza");
//            Strings.Add("Ibrahim");
//            Strings.Add("Khalid");

//            //Iterate over the CustomCollection 

//            foreach(string item in Strings)
//            {
//                Console.WriteLine(item);
//            }

//            Console.ReadKey();
            
//        }

//    }
//}
