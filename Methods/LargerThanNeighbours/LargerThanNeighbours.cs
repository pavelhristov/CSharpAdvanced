using System;
using System.Linq;

class LargerThanNeighbours
{
   static void Main()
   {
      //input
      int size = int.Parse(Console.ReadLine());
      int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
      //logic
      int counter = 0;
      for (int i = 1; i < size-1; i++)
      {
         if (HigherThanNeighbours(numbers,i))
         {
            counter++;
         }
      }
      //output
      Console.WriteLine(counter);
   }
   public static bool HigherThanNeighbours(int[] array, int index)
   {
      if (array[index]>array[index-1] && array[index]>array[index+1])
      {
         return true;
      }
      else
      {
         return false;
      }
   }
}