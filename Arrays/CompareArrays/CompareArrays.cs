using System;

class CompareArrays
{
   static void Main()
   {
      //input
      int N = int.Parse(Console.ReadLine());
      int[] firstArray = new int[N];
      int[] secondArray = new int[N];

      for (int i = 0; i < 2 * N; i++)
      {
         if (i < N)
         {
            firstArray[i] = int.Parse(Console.ReadLine());
         }
         else if (i >= N)
         {
            secondArray[i - N] = int.Parse(Console.ReadLine());
         }
      }

      //logic
      bool flag = true;

      for (int i = 0; i < N; i++)
      {
         if (firstArray[i] != secondArray[i])
         {
            flag = false;
         }
      }
      //output
      if (flag)
      {
         Console.WriteLine("Equal");
      }
      else
      {
         Console.WriteLine("Not equal");
      }
   }
}