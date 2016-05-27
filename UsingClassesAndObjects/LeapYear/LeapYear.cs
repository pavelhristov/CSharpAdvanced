using System;

class LeapYear
{
   static void Main()
   {
      //input
      DateTime date = new DateTime(int.Parse(Console.ReadLine()),1,1);

      //output
      if (DateTime.IsLeapYear(date.Year))
      {
      Console.WriteLine("Leap");
      }
      else
      {
         Console.WriteLine("Common");
      }
   }
}