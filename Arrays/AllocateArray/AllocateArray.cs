using System;

class AllocateArray
{
   static void Main()
   {
      //input
      int N = int.Parse(Console.ReadLine());

      //logic
      int[] numbers = new int[N];

      for (int i = 0; i < N; i++)
      {
         numbers[i] = 5 * i;
      }

      //output
      foreach (var item in numbers)
      {
         Console.WriteLine(item);
      }
   }
}