namespace NineGagNumbers
{
   using System;
   using System.Numerics;

   class NineGagNumbers
   {
      public static string[] NineGag =
         {
            "-!",
            "**",
            "!!!",
            "&&",
            "&-",
            "!-",
            "*!!!",
            "&*!",
            "!!**!-",
         };

      static void Main()
      {
         //input
         string nineGagNumber = Console.ReadLine();

         //logic
         int count = 0;
         int oldIndex = 0;
         BigInteger result = 0;
         BigInteger[] toDigits = new BigInteger[nineGagNumber.Length];
         for (int i = 0; i <= nineGagNumber.Length; i++)
         {
            var chars = nineGagNumber.Substring(oldIndex, i - oldIndex);
            for (int j = 0; j < 9; j++)
            {
               if (NineGag[j] == chars)
               {
                  toDigits[count] = j;
                  count++;
                  oldIndex = i;
                  break;
               }
            }
         }
         for (int i = count - 1; i >= 0; i--)
         {
            result += toDigits[i] * Power(9, count - i - 1);

         }
         //output
         Console.WriteLine(result);
      }

      public static BigInteger Power(int number,int k)
      {
         BigInteger result = 1;
         for (int i = 0; i < k; i++)
         {
            result *= number;
         }
         return result;
      }
   }
}
