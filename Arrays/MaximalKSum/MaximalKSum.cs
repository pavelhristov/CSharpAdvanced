using System;

class MaximalKSum
{
   static void Main()
   {
      //input
      int N = int.Parse(Console.ReadLine());
      int K = int.Parse(Console.ReadLine());
      int[] numbers = new int[N];
      for (int i = 0; i < N; i++)
      {
         numbers[i] = int.Parse(Console.ReadLine());
      }

      //logic

      long result = 0;
      int lastMaxElement = int.MaxValue;

      for (int i = 0; i < K; i++)
      {
         int currentMaxIndex = 0;
         int maxElement = numbers[0];
         for (int j = 1; j < N; j++)
         {
            if (numbers[j] >= maxElement)
            {
               maxElement = numbers[j];
               currentMaxIndex = j;
            }
         }
         result += maxElement;
         lastMaxElement = maxElement;
         numbers[currentMaxIndex] = int.MinValue;
      }

      //output
      Console.WriteLine(result);
   }
}