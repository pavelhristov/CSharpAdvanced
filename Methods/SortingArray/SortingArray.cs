using System;
using System.Linq;

class SortingArray
{
   static void Main()
   {
      //input
      int size = int.Parse(Console.ReadLine());
      int[] numbers  = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

      //logic
      string sortedNumbers = string.Join(" ", ArraySorting(numbers));

      //output
      Console.WriteLine(sortedNumbers);
   }
   public static int MaxElement(int[] numbers, int index, ref int lastIndex)
   {
      int currentMax = numbers[index];
      for (int i = index+1; i < numbers.Length; i++)
      {
         if (currentMax<numbers[i])
         {
            currentMax = numbers[i];
            lastIndex = i;
         }
      }
      return currentMax;
   }
   public static int[] ArraySorting(int[] numbers)
   {
      for (int i =0 ; i < numbers.Length ; i++)
      {
         int k = numbers[i];
         int lastIndex = -1;
         numbers[i] = MaxElement(numbers, i, ref lastIndex);
         if (lastIndex>=0)
         {
         numbers[lastIndex] = k;
         }
      }
      Array.Reverse(numbers);
      return numbers;
   }
}