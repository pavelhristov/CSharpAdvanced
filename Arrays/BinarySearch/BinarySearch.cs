using System;

class BinarySearch
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
      int X = int.Parse(Console.ReadLine());

      //logic
      int start = 0;
      int end = N - 1;
      int index = -1;
      while (start<=end)
      {
         int middle = (end + start) / 2;
         int currentItem = numbers[middle];
         if (currentItem == X)
         {
            index = middle;
            break;
         }
         else if (currentItem < X)
         {
            start = middle + 1;
         }
         else if (currentItem > X)
         {
            end = middle - 1;
         }
      }
      //output
      Console.WriteLine(index);
   }
}