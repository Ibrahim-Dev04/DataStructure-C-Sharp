//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructure_C_
//{
//    internal class BitArray2_AdvancedOperations_And_Or_Not_XOr
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
//             BitArray  Bits1 = new BitArray(new bool[] { true, false ,true,true});
//             BitArray  Bits2 = new BitArray(new bool[] { false, true, false, true });

//            Console.WriteLine("bits1 : " + BitArrayToString(Bits1));
//            Console.WriteLine("bits2 : " + BitArrayToString(Bits2));

//            //Bitwise AND operation
//            BitArray resultAnd  = new BitArray(Bits1);

//            resultAnd.And(Bits2);
//            Console.WriteLine("\nBitwise AND result :");
//            Console.WriteLine(BitArrayToString(Bits1));
//            Console.WriteLine(BitArrayToString(Bits2));
//            Console.WriteLine("--------------------");
//            Console.WriteLine(BitArrayToString(resultAnd));

//            //Bitwise OR operation
//            BitArray resulOR = new BitArray(Bits1);

//            resulOR.Or(Bits2);
//            Console.WriteLine("\nBitwise OR result :");
//            Console.WriteLine(BitArrayToString(Bits1));
//            Console.WriteLine(BitArrayToString(Bits2));
//            Console.WriteLine("--------------------");
//            Console.WriteLine(BitArrayToString(resulOR));


//            //Bitwise NOT operation
//            BitArray resultNot = new BitArray(Bits1);
//            resultNot.Not();
//            Console.WriteLine("\nBitwise Not result :");
//            Console.WriteLine(BitArrayToString(Bits1));
//            Console.WriteLine("--------------------");
//            Console.WriteLine(BitArrayToString(resultNot));

//            // Bitwise Xor operation
//            /*
//             Explaining the XOR:
//             XOR Table: returns true of the two bits are diffrent, otherwise returns false.

//                | A | B | A XOR B |
//                |---|---|---------|
//                | 0 | 0 |    0    |
//                | 0 | 1 |    1    |
//                | 1 | 0 |    1    |
//                | 1 | 1 |    0    |
//             */
//            BitArray resultXOR = new BitArray(Bits1);
//            resultXOR.Xor(Bits2);
//            Console.WriteLine("\nBitwise Xor result :");
//            Console.WriteLine(BitArrayToString(Bits1));
//            Console.WriteLine(BitArrayToString(Bits2));
//            Console.WriteLine("--------------------");
//            Console.WriteLine(BitArrayToString(resultXOR));

//            Console.ReadKey();  
//        }
//    }
//}
