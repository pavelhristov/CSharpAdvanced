using System;

class MaximalSum
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
      long maxSum = numbers[0];
      long currentMaxSum = numbers[0];
      long currentSum = numbers[0];

      for (int i = 1; i < N; i++)
      {
         if (numbers[i] + currentSum > 0 && currentSum > 0)
         {
            currentSum += numbers[i];
            currentMaxSum = currentSum;
            maxSum = Math.Max(currentMaxSum, maxSum);
         }
         else
         {
            maxSum = Math.Max(currentMaxSum, maxSum);
            currentMaxSum = numbers[i];
            currentSum = numbers[i];
         }
      }
      //output
      Console.WriteLine(maxSum);
   }
}