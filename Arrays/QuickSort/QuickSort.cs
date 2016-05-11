using System;

class QuickSort
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
      QuickSorting(numbers, 0,N);

      //output
      foreach (var item in numbers)
      {
         Console.WriteLine(item);
      }

   }
   public static int Partition(int[] array, int first, int last, int i)
   {
      i = first;
      int p = array[last-1];
      for (int j = first; j < last-1; j++)
      {
         if (array[j]<=p)
         {
            int k = array[i];
            array[i] = array[j];
            array[j] = k;
            i++;
         }
      }
      int m = array[i];
      array[i] = array[last-1];
      array[last-1] = m;

      return i;
   }
   public static void QuickSorting(int[] array,int first, int last)
   {
      int i=0;
      if (first<last)
      {
         i = Partition(array, first, last, i);
         QuickSorting(array, first, i);
         QuickSorting(array, i + 1, last);
      }
   }
}