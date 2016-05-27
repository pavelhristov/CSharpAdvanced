using System;
using System.Numerics;

class BinaryToDecimal
{
   static void Main()
   {
      //input
      BigInteger N = BigInteger.Parse(Console.ReadLine());
      BigInteger M = N;

      //logic
      BigInteger result = 0;
      for (int i = 0; i < N.ToString().Length; i++)
      {
         result += (M % 10) * (BigInteger)Math.Pow(2, i);
         M = M / 10;
      }

      //output

      Console.WriteLine(result);
   }
}