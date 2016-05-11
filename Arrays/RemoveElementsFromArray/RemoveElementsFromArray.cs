using System;

class RemoveElementsFromArray
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
      int[] predecessors = new int[N];
      int[] smallestElementIdex = new int[N + 1];

      int length = 0;
      for (int i = 0; i < N; i++)
      {
         int current = numbers[i];
         int start = 1;
         int end = length;
         while (start <= end)
         {
            int mid = (start + end) / 2;
            if (numbers[smallestElementIdex[mid]] <= numbers[i])
            {
               start = mid + 1;
            }
            else
            {
               end = mid - 1;
            }
         }
         
         int newLength = start;
         
         predecessors[i] = smallestElementIdex[newLength - 1];
         smallestElementIdex[newLength] = i;

         if (newLength > length)
         {
            length = newLength;

         }

      }
      //output
      Console.WriteLine(N - length);
   }
}