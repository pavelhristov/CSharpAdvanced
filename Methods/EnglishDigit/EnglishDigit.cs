using System;

class EnglishDigit
{
   static void Main()
   {
      //input
      long number = long.Parse(Console.ReadLine());

      //output
      Console.WriteLine(Digit(number));
   }
   public static string Digit(long number)
   {
      long digit = number % 10;
      switch (digit)
      {
         case 1: return "one"; 
         case 2: return "two"; 
         case 3: return "three"; 
         case 4: return "four"; 
         case 5: return "five"; 
         case 6: return "six"; 
         case 7: return "seven"; 
         case 8: return "eight";
         case 9: return "nine";
         default: return "zero";
      }
   }
}