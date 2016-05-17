using System;
using System.Linq;

class SequenceInMatrix
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
      int counter = 1;
      int maxSequence = 1;
      for (int i = 1; i < matrix.GetLength(0); i++)
      {
         for (int j = 0; j < matrix.GetLength(1); j++)
         {
            if (matrix[i - 1, j] == matrix[i, j])
            {
               counter++;
            }
            else
            {
               maxSequence = Math.Max(counter, maxSequence);
               counter = 1;
            }
         }
      }
      maxSequence = Math.Max(counter, maxSequence);
      counter = 1;
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         for (int i = 1; i < matrix.GetLength(0); i++)
         {
            if (matrix[i - 1, j] == matrix[i, j])
            {
               counter++;
            }
            else
            {
               maxSequence = Math.Max(counter, maxSequence);
               counter = 1;
            }
         }
      }
      maxSequence = Math.Max(counter, maxSequence);
      counter = 1;
      
      //output
      Console.WriteLine(maxSequence);
   }
}