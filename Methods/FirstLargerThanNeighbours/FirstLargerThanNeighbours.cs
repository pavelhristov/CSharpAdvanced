using System;
using System.Linq;

class FirstLargerThanNeighbours
{
   static void Main()
   {
      //input
      int size = int.Parse(Console.ReadLine());
      int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
      //output
      Console.WriteLine(FirstHigherThanNeighbours(numbers));
   }
   public static int FirstHigherThanNeighbours(int[] array)
   {
      for (int i = 1; i < array.Length - 1; i++)
      {
         if (array[i] > array[i - 1] && array[i] > array[i + 1])
         {
            return i;
         }
      }
      return -1;
   }
}