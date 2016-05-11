using System;

class MaximalSequence
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
      int counter = 1;
      int maxCounter = 1;
      for (int i = 1; i < N; i++)
      {
         if (numbers[i] == numbers[i-1])
         {
            counter++;
         }
         else
         {
            maxCounter = Math.Max(maxCounter, counter);
            counter = 1;
         }
      }
      maxCounter = Math.Max(maxCounter, counter);
      //output
      Console.WriteLine(maxCounter);
   }
}