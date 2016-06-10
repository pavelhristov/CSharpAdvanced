namespace Problem3_Porcupines
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;


   class Porcupines
   {
      static void Main()
      {
         //input
         int col = int.Parse(Console.ReadLine());
         int row = int.Parse(Console.ReadLine());

         var porc = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
         var rabbit = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

         int[][] field = new int[row][];
         for (int i = 0; i < row / 2; i++)
         {
            var currentCol = col * (i + 1);
            int[] currentRow = new int[currentCol];
            int[] currentRow2 = new int[currentCol];
            for (int j = 0; j < currentCol; j++)
            {
               currentRow[j] = (i + 1) * (j + 1);
               currentRow2[j] = (row - i) * (j + 1);
            }
            field[i] = currentRow;
            field[row - i - 1] = currentRow2;
         }


         // TODO handle with directions and movement

         for (string[] current = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            current[0] != "END";
            current = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray())
         {
            var move = int.Parse(current[2]);
            if (current[0] == "R")
            {
               switch (current[1])
               {
                  case "T":
                     for (int i = 0; i < move; i++)
                     {
                        if (field[porc[0] - 1].Length > porc[1])
                        {
                           if (porc[0] - 1 != rabbit[0])
                           {
                              porc[0]--;
                           }
                        }
                        else
                        {
                           porc[0] = field[row - porc[0] - 1][porc[1]];
                        }
                     }
                     break;
                  case "B":
                     for (int i = 0; i < move; i++)
                     {
                        if (field[row - porc[0] + 1].Length > porc[1])
                        {
                           if (porc[0] + 1 != rabbit[0])
                           {
                              porc[0]++;
                           }
                        }
                        else
                        {
                           porc[0] = field[row - porc[0] + 1][porc[1]];
                        }
                     }
                     break;
                  case "R":  //TODO
                     for (int i = 0; i < move; i++)
                     {
                        if (field[porc[0] - 1].Length > porc[1])
                        {
                           if (porc[0] - 1 != rabbit[0])
                           {
                              porc[0]--;
                           }
                        }
                        else
                        {
                           porc[0] = field[row - porc[0] - 1][porc[1]];
                        }
                     }
                     break;
                  case "L":
                     for (int i = 0; i < move; i++)
                     {
                        if ((row + 1) * col > porc[1])
                        {
                           if (porc[1] - 1 != rabbit[1])
                           {
                              porc[1]--;
                           }
                        }
                        else
                        {
                           porc[1] = field[(row+1)*col - porc[1] - 1][porc[0]];
                        }
                     }
                     break;
                  default: break;
               }
            }
            else
            {

            }
         }


         //for (int i = 0; i < row; i++)
         //{
         //   for (int j = 0; j < field[i].Length; j++)
         //   {
         //      Console.Write(field[i][j] + " ");
         //   }
         //   Console.WriteLine();
         //}
      }
      public static int PositionCheck(int position, int length)
      {
         if (position >= length)
         {
            while (position >= length)
            {
               position -= length;
            }
         }
         else
         {
            while (position < 0)
            {
               position += length;
            }
         }

         return position;
      }
   }
}
//for participation