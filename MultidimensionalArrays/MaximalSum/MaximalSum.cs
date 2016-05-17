using System;
using System.Linq;

class MaximalSum
{
   static void Main()
   {
      //input
      int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
      int[,] matrix = new int[size[0], size[1]];
      for (int i = 0; i < size[0]; i++)
      {
         int[] row = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
         for (int j = 0; j < size[1]; j++)
         {
            matrix[i, j] = row[j];
         }
      }
      //logic
      int bestSum = int.MinValue;
      for (int i = 1; i < matrix.GetLength(0) - 1; i++)
      {
         for (int j = 1; j < matrix.GetLength(1) - 1; j++)
         {
            int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1] +
               matrix[i - 1, j] + matrix[i, j - 1] + matrix[i - 1, j - 1] + matrix[i-1,j+1] + matrix[i+1,j-1];
            if (sum > bestSum)
            {
               bestSum = sum;
            }
         }
      }
      //output
      Console.WriteLine(bestSum);
   }
}