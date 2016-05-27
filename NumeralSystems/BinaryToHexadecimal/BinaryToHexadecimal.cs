using System;
using System.Numerics;

class BinaryToHexadecimal
{
   static void Main()
   {
      //input
      BigInteger N = BigInteger.Parse(Console.ReadLine());

      //logic
      string result = "";
      while (N > 0)
      {
         int M = (int)(N % 10000);
         N = N / 10000;
         int current = 0;
         int length = M.ToString().Length;
         for (int i = 0; i <= length; i++)
         {
            current += (M % 10) * (int)Math.Pow(2, i);
            M = M / 10;
         }

         switch (current)
         {
            case 10: result = "A" + result; continue;
            case 11: result = "B" + result; continue;
            case 12: result = "C" + result; continue;
            case 13: result = "D" + result; continue;
            case 14: result = "E" + result; continue;
            case 15: result = "F" + result; continue;
            default:
               result = current.ToString() + result;
               continue;
         }
      }
      //output
      Console.WriteLine(result);
   }
}