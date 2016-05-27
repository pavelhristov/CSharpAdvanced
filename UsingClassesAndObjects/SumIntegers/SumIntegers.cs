using System;
using System.Linq;

class SumIntegers
{
   static void Main()
   {
      //input
      string integers = Console.ReadLine();
      //output
      Console.WriteLine(Sum(integers));
   }

   public static int Sum(string integers)
   {
      int[] ints = integers.Split(' ').Select(int.Parse).ToArray();
      int sum = 0;

      foreach (var item in ints)
      {
         sum += item;
      }
      return sum;
   }
}