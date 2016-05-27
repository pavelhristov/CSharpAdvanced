using System;

class DecimalToHexadecimal
{
   static void Main()
   {
      //input
      long N = long.Parse(Console.ReadLine());

      //logic

      long current;
      string result = "";
      for (long i = 0; N > 0; i++, N = N / 16)
      {
         current = (N % 16);
         switch (current)
         {
            case 10: result = result + "A"; continue;
            case 11: result = result + "B"; continue;
            case 12: result = result + "C"; continue;
            case 13: result = result + "D"; continue;
            case 14: result = result + "E"; continue;
            case 15: result = result + "F"; continue;
            default:
               result = result + current.ToString();
               continue;
         }

         if (N < 16)
         {
            break;
         }
      }
      //output
      Console.WriteLine(ReverseString(result));
   }

   public static string ReverseString(string s)
   {
      char[] arr = s.ToCharArray();
      Array.Reverse(arr);
      return new string(arr);
   }
}