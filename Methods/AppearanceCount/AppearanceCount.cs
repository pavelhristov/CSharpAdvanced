using System;
using System.Linq;

class AppearanceCount
{
   static void Main()
   {
      //input
      int size = int.Parse(Console.ReadLine());
      int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
      int element = int.Parse(Console.ReadLine());
      //output
      Console.WriteLine(ElementCounter(numbers,element));
   }
   public static int ElementCounter(int[] numbers, int element)
   {
      int counter = 0;
      foreach (var item in numbers)
      {
         if (item==element)
         {
            counter++;
         }
      }
      return counter;
   }
}