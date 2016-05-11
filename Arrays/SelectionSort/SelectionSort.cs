using System;

class SelectionSort
{
   static void Main()
   {
      //input
      int N = int.Parse(Console.ReadLine());
      int[] numbers = new int[N];
      for (int i = 0; i < N; i++)
      {
         numbers[i] = int.Parse(Console.ReadLine());
      }
      //logic
      int lastIndex = 0;
      for (int j = 1; j < N; j++)
      {
         for (int i = lastIndex + 1; i < N; i++)
         {
            if (numbers[i] < numbers[lastIndex])
            {
               int k = numbers[i];
               numbers[i] = numbers[lastIndex];
               numbers[lastIndex] = k;
            }
         }
         lastIndex++;
      }
      //output
      foreach (var item in numbers)
      {
         Console.WriteLine(item);
      }
   }
}