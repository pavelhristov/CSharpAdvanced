namespace LoverOfThree
{
   using System;
   using System.Linq;

   class LoverOfThree
   {
      static void Main()
      {
         //input
         var fieldSizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
         int r = fieldSizes[0];
         int c = fieldSizes[1];
         int n = int.Parse(Console.ReadLine());

         //logic
         bool[,] field = new bool[r, c];
         long result = 0;
         //magic
         int row = r - 1;
         int col = 0;

         for (int i = 0; i < n; i++)
         {
            var move = Console.ReadLine().Split(' ');

            var directions = move[0];
            var repeats = int.Parse(move[1]);

            var deltaRow = directions.Contains("U") ? -1 : 1;
            var deltaCol = directions.Contains("L") ? -1 : 1;

            for (int j = 1; j < repeats; j++)
            {
               if ((deltaCol + col < c) && (deltaRow + row < r) && (deltaCol + col >= 0) && (deltaRow + row >= 0))
               {
                  col += deltaCol;
                  row += deltaRow;
                  if (!field[row,col])
                  {
                     result += (r - row - 1) * 3 + col * 3;
                     field[row, col] = true;
                  }
               }
               else
               {
                  break;
               }
            }
         }

         //output
         Console.WriteLine(result);
      }
   }
}
