namespace SpecialValue
{
   using System;
   using System.Collections.Generic;
   using System.Linq;


   class SpecialValue
   {
      static void Main()
      {
         //input
         int n = int.Parse(Console.ReadLine());
         int[][] array = new int[n][];
         for (int i = 0; i < array.Length; i++)
         {
            array[i] = Console.ReadLine().Split(new[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
         }

         //logic
         int maxSpecialNumber = int.MinValue;
         //for (int i = 0; i < n; i++)  // Problem is missing information, its said nowhere that it can only start from first row ........
         //{                            // for example on first and second zero test if you start from other rows there are a lot higher special values.....
         for (int j = 0; j < array[0].Length; j++)
         {
            List<string> visited = new List<string>();
            var current = array[0][j];
            var row = 0;
            var visiting = row + " " + current;
            visited.Add(visiting);
            int currentSpecialNumber = 1;
            bool flag = false;
            if (current >= 0)
            {
               do
               {
                  if (row + 1 >= n)
                  {
                     row = 0;
                  }
                  else
                  {
                     row++;
                  }
                  visiting = row + " " + current;
                  if (visited.Contains(visiting))
                  {
                     flag = true;
                     break;
                  }
                  else
                  {
                     visited.Add(visiting);
                  }
                  current = Next(array[row], current);
                  currentSpecialNumber += 1;
               } while (current >= 0);
            }
            if (flag)
            {
               visited.Clear();
            }
            else
            {
               currentSpecialNumber += Math.Abs(current);
               maxSpecialNumber = Math.Max(currentSpecialNumber, maxSpecialNumber);
               visited.Clear();
            }
         }
         // }
         //output
         Console.WriteLine(maxSpecialNumber);
      }

      public static int Next(int[] array, int j)
      {
         return array[j];
      }
   }
}
