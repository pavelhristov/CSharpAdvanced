using System;

class DecimalToBinary
{
   static void Main()
   {
      //input
      long N = long.Parse(Console.ReadLine());

      //logic
      int lenght = N.ToString().Length;
      long current;
      string result = "";
      for (long i = 0; N > 0; i++, N = N / 2)
      {
         current = (N % 2);
         result = result + current.ToString();

      }


      //output
      Console.WriteLine(DecimalToBinary.ReverseString(result));
   }

   public static string ReverseString(string s)
   {
      char[] arr = s.ToCharArray();
      Array.Reverse(arr);
      return new string(arr);
   }
}