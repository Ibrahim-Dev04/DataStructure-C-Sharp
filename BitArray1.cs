//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructure_C_
//{
//    internal class BitArray1
//    {

//        static string BitArrayToString(BitArray bitArray)
//        {
//            char[] chars = new char[bitArray.Length];

//            for (int i = 0; i < bitArray.Length; i++)
//            {
//                chars[i] = bitArray[i] ? '1' : '0';
//            }

//            return new string(chars);
//        }
//        static void Main(string[] args)
//        {

//            //create a bitarray with ten bits
//            BitArray bits1 = new BitArray(10);

//            Console.WriteLine("\nbits1 content : " + BitArrayToString(bits1));


//            for(int i = 0;i < bits1.Length;i++)
//            {
//                Console.WriteLine($" bit at index {i} : " + bits1[i]);
//            }

//            //create a bitarray from an array of booleans

//            bool[] InitialValues = {true,false,true,false,false,true};

//            BitArray bits2 = new BitArray(InitialValues);

//            Console.WriteLine("\nbits2 Content : " + BitArrayToString(bits2));

//            for (int i = 0; i < bits2.Length; i++)
//            {
//                Console.WriteLine($" bit at index {i} : " + bits2[i]);
//            }

//            //create a bitarray from a byte array

//            byte[] bytearray = { 0xAA, 0x55 };
            
//            BitArray bits3 = new BitArray(bytearray);

//            Console.WriteLine("\nbits3 Content : " + BitArrayToString(bits3));

//            for (int i = 0; i < bits3.Length; i++)
//            {
//                Console.WriteLine($" bit at index {i} : " + bits3[i]);
//            }

//            //basic operations

//            BitArray bits4 = new BitArray(8);
//            bits4.Set(2, true);//set the bit at index 2 to true
//            bits4.Set(5,true); //set the bit at index 5 to true
//            bits4[7] = true;   //set the bit at index 7 to true
//            bits4[3] = true;   //set the bit at index 3  to true

//            Console.WriteLine("\nbits4 Content : " + BitArrayToString(bits4));

//            for (int i = 0; i < bits4.Length; i++)
//            {
//                Console.WriteLine($" bit at index {i} : " + bits4[i]);
//            }

//            //set all bits to true
//            bits4.SetAll(true);
//           Console.WriteLine("\n\nbits4 Content after setting all to true : " + BitArrayToString(bits4));

//            for (int i = 0; i < bits4.Length; i++)
//            {
//                Console.WriteLine($" bit at index {i} : " + bits4[i]);
//            }

//            //set all bits to false
//            bits4.SetAll(false);
//            Console.WriteLine("\n\nbits4 Content after setting all to true : " + BitArrayToString(bits4));

//            for (int i = 0; i < bits4.Length; i++)
//            {
//                Console.WriteLine($" bit at index {i} : " + bits4[i]);
//            }

//            bool bitvalue = bits4[3];  //get the value of bit at index 3
//            int length = bits4.Length; //get the number of bits in the bitarray


//            Console.ReadKey();
//        }
//    }
//}
