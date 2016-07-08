namespace Problem1_CryptoCS
{
   using System;
   using System.Numerics;
   using System.Text;

   class CryptoCS
   {
      static void Main()
      {
         //input
         string firstNumber = Console.ReadLine();
         string operation = Console.ReadLine();
         BigInteger secondNumber = BigInteger.Parse(Console.ReadLine());

         //logic
         Console.WriteLine(DecToNine(LetterToDec(firstNumber, operation, secondNumber)));
      }

      public static BigInteger LetterToDec(string str, string sign, BigInteger num)
      {
         BigInteger result = 0;
         BigInteger result1 = 0;

         for (int i = 0; i < str.Length; i++)
         {
            result += (str[i] - 'a') * Power(26, str.Length - i - 1);
            if (num > 0)
            {
               var current = num % 10;
               num /= 10;
               result1 += current * Power(7, i);
            }
         }

         return Operation(result, sign, result1);
      }

      public static BigInteger Operation(BigInteger a, string sign, BigInteger b)
      {
         BigInteger result = 0;

         if (sign == "+")
         {
            result = a + b;
         }
         else if (sign == "-")
         {
            result = a - b;
         }
         
         return result;
      }

      public static string DecToNine(BigInteger num)
      {
         int current = 0;
            StringBuilder builder = new StringBuilder();
         for (int i = 0; num > 0; i++, num = num / 9)
         {
            current = (int)(num % 9);
            builder.Append(current);
         }
         
         return Reverse(builder.ToString());
      }

      public static BigInteger Power(int number, int k)
      {
         BigInteger result = 1;
         for (int i = 0; i < k; i++)
         {
            result *= number;
         }
         return result;
      }
      public static string Reverse(string s)
      {
         char[] charArray = s.ToCharArray();
         Array.Reverse(charArray);
         return new string(charArray);
      }
   }
}
