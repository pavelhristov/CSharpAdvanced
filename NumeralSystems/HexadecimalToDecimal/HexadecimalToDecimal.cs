using System;

class HexadecimalToDecimal
{
   static void Main()
   {
      //input
      char[] hexNumber = Console.ReadLine().ToCharArray();

      //logic
      int length = hexNumber.Length;
      long result = 0;

      foreach (var item in hexNumber)
      {
         length--;
         switch (item)
         {
            case 'A': result = result + 10 * (long)Math.Pow(16, length); continue;
            case 'B': result = result + 11 * (long)Math.Pow(16, length); continue;
            case 'C': result = result + 12 * (long)Math.Pow(16, length); continue;
            case 'D': result = result + 13 * (long)Math.Pow(16, length); continue;
            case 'E': result = result + 14 * (long)Math.Pow(16, length); continue;
            case 'F': result = result + 15 * (long)Math.Pow(16, length); continue;
            default:
               result = result + (item - '0') * (long)Math.Pow(16, length);
               continue;
         }
      }

      //output
      Console.WriteLine(result);
   }
}