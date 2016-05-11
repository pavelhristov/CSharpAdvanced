using System;
using System.Linq;

class GetLargestNumber
{
   static void Main()
   {
      //input
      int size = 3;
      int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
      //logic
      int maxNumber = numbers[0];
      for (int i = 1; i < size; i++)
      {
         maxNumber = GetMax(maxNumber, numbers[i]);
      }
      //output
      Console.WriteLine(maxNumber);
   }
   public static int GetMax(int a,int b)
   {
      if (a>=b)
      {
         return a;
      }
      else
      {
         return b;
      }
   }
}