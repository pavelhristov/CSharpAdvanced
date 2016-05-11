using System;

class ReverseNumber
{
   static void Main()
   {
      //input
      string number = Console.ReadLine();
      //output
      Console.WriteLine(ReversedNumber(number));
   }
   public static string ReversedNumber(string number)
   {
      string reversedNumber = "";
      for (int i = number.Length - 1; i >= 0; i--)
      {
         reversedNumber += number[i];
      }
      return reversedNumber;
   }
}