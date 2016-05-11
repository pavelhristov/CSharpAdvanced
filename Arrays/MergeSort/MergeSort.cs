using System;

class MergeSort
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
      numbers = Sorting(numbers);

      //output
      foreach (var item in numbers)
      {
         Console.WriteLine(item);
      }
   }

   public static int[] Sorting(int[] array)
   {
      int length = array.Length;
      if (length == 1)
      {
         return array;
      }
      else
      {
         int[] arrayLeft = new int[length / 2];
         int[] arrayRight = new int[length / 2 + length % 2];
         int k = 0;
         int j = 0;
         for (int i = 0; i < length; i++)
         {
            if (i <length/2)
            {
               arrayLeft[k] = array[i];
               k++;
            }
            else
            {
               arrayRight[j] = array[i];
               j++;
            }
         }
         arrayLeft = Sorting(arrayLeft);
         arrayRight = Sorting(arrayRight);

         return Merge(arrayLeft, arrayRight);
      }
   }
   static int[] Merge(int[] arrayLeft, int[] arrayRight)
   {
      int size = arrayLeft.Length + arrayRight.Length;
      int[] merged = new int[size];

      int l = 0;
      int r = 0;

      for (int i = 0; i < size; i++)
      {
         if (arrayLeft[l] <= arrayRight[r])
         {
            merged[i] = arrayLeft[l];
            l++;
            if (l >= arrayLeft.Length)
            {
               for (int j = i + 1; j < size; j++)
               {
                  merged[j] = arrayRight[r];
                  r++;
               }
               break;
            }
         }
         else
         {
            merged[i] = arrayRight[r];
            r++;
            if (r >= arrayRight.Length)
            {
               for (int j = i + 1; j < size; j++)
               {
                  merged[j] = arrayLeft[l];
                  l++;
               }
               break;
            }
         }
      }
      return merged;
   }
}