using System;

class FillTheMatrix
{
   static void Main()
   {
      //input
      int N = int.Parse(Console.ReadLine());
      int[,] matrix = new int[N, N];
      string way = Console.ReadLine();
      //logic
      int counter = 0;
      switch (way)
      {
         case "a":
            for (int i = 0; i < N; i++)
            {
               for (int j = 0; j < N; j++)
               {
                  counter++;
                  matrix[j, i] = counter;
               }
            }
            break;
         case "b":
            for (int i = 0; i < N; i++)
            {
               if (i % 2 == 0)
               {
                  for (int j = 0; j < N; j++)
                  {
                     counter++;
                     matrix[j, i] = counter;
                  }
               }
               else
               {
                  for (int j = N - 1; j >= 0; j--)
                  {
                     counter++;
                     matrix[j, i] = counter;
                  }
               }
            }
            break;
         case "c":
            int Position = matrix.GetLength(1) - 1;
            while (Position >= 0)
            {
               for (int i = 0; i < matrix.GetLength(1); i++)
               {
                  for (int j = 0; j < matrix.GetLength(0) - Position; j++)
                  {
                     if (i - j == Position)
                     {
                        counter++;
                        matrix[i, j] = counter;
                     }
                  }
               }

               Position--;
            }
            while (Position >= -(matrix.GetLength(1) - 1))
            {
               for (int i = 0; i < matrix.GetLength(1); i++)
               {
                  for (int j = 0 - Position; j < matrix.GetLength(0); j++)
                  {
                     if (i - j == Position)
                     {
                        counter++;
                        matrix[i, j] = counter;
                     }
                  }
               }

               Position--;
            }
            break;
         case "d":
            int col = 0;
            int row = 0;
            int end = N - 1;
            int start = 0;
            while (start <= end + 10)
            {
               if (col > end)
               {
                  col = end;
               }
               else if (col < start)
               {
                  col = start;
               }
               if (row > end)
               {
                  row = end;
               }
               else if (row < start)
               {
                  row = start;
               }
               if (counter >= N * N)
               {
                  break;
               }

               if (col == start && row == start)
               {
                  for (int i = start; i <= end; i++)
                  {
                     counter++;
                     matrix[col, row] = counter;
                     col++;
                  }
                  row++;
               }
               else if (col == end && row == start + 1)
               {
                  for (int i = start; i <= end - 1; i++)
                  {
                     counter++;
                     matrix[col, row] = counter;
                     row++;
                  }
                  col--;
               }
               else if (col == end - 1 && row == end)
               {
                  for (int i = start; i <= end - 1; i++)
                  {
                     counter++;
                     matrix[col, row] = counter;
                     col--;
                  }
                  row--;
               }
               else if (col == start && row == end - 1)
               {
                  for (int i = start; i < end - 1; i++)
                  {
                     counter++;
                     matrix[col, row] = counter;
                     row--;
                  }
               }
               if (col == row)
               {
                  start++;
                  end--;
               }
            }
            break;
         default:
            break;
      }
      //output
      for (int i = 0; i < N; i++)
      {
         for (int j = 0; j < N; j++)
         {
            if (j != N - 1)
            {
               Console.Write("{0} ", matrix[i, j]);
            }
            else
            {
               Console.Write(matrix[i, j]);
            }
         }
         Console.WriteLine();
      }
   }
}