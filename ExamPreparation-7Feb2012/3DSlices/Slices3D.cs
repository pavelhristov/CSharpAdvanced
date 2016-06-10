namespace _3DSlices
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   class Slices3D
   {
      static void Main()
      {
         //input
         var sizes = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
         int[,,] cube = new int[sizes[1], sizes[2], sizes[0]];

         for (int i = 0; i < sizes[1]; i++)
         {
            var currentLine = Console.ReadLine().Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int j = 0; j < sizes[2]; j++)
            {
               int[] currentElements = currentLine[j].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
               for (int k = 0; k < sizes[0]; k++)
               {
                  cube[i, j, k] = currentElements[k];
               }
            }
         }

         int result = CubeSlicerX(cube, sizes[1], sizes[2], sizes[0]) + CubeSlicerY(cube, sizes[1], sizes[2], sizes[0]) + CubeSlicerZ(cube, sizes[1], sizes[2], sizes[0]);


         Console.WriteLine(result);
      }

      public static int CubeSlicerY(int[,,] cube, int x, int y, int z)
      {
         int possibleSlices = 0;

         int slicerY = 1;
         int currentSlice = 0;
         int currentLeft = 0;
         for (int height = slicerY; height < y; height++)
         {
            for (int k = 0; k < z; k++)
            {
               for (int i = 0; i < x; i++)
               {
                  for (int j = 0; j < y; j++)
                  {
                     if (j < slicerY)
                     {
                        currentSlice += cube[i, j, k];
                     }
                     else
                     {
                        currentLeft += cube[i, j, k];
                     }
                  }
               }
               if (currentLeft == currentSlice)
               {
                  possibleSlices++;
               }
               currentSlice = 0;
               currentLeft = 0;
            }
            slicerY++;
         }


         return possibleSlices;
      }
      public static int CubeSlicerX(int[,,] cube, int x, int y, int z)
      {
         int possibleSlices = 0;

         int slicerX = 1;
         int currentSlice = 0;
         int currentLeft = 0;
         for (int width = slicerX; width < x; width++)
         {
            for (int j = 0; j < y; j++)
            {
               for (int k = 0; k < z; k++)
               {
                  for (int i = 0; i < x; i++)
                  {
                     if (i < slicerX)
                     {
                        currentSlice += cube[i, j, k];
                     }
                     else
                     {
                        currentLeft += cube[i, j, k];
                     }
                  }
               }
               if (currentLeft == currentSlice)
               {
                  possibleSlices++;
               }
               currentSlice = 0;
               currentLeft = 0;
            }
            slicerX++;
         }


         return possibleSlices;
      }
      public static int CubeSlicerZ(int[,,] cube, int x, int y, int z)
      {
         int possibleSlices = 0;

         int slicerZ = 1;
         int currentSlice = 0;
         int currentLeft = 0;
         for (int depth = slicerZ; depth < z; depth++)
         {
            for (int j = 0; j < y; j++)
            {
               for (int i = 0; i < x; i++)
               {
                  for (int k = 0; k < z; k++)
                  {
                     if (k < slicerZ)
                     {
                        currentSlice += cube[i, j, k];
                     }
                     else
                     {
                        currentLeft += cube[i, j, k];
                     }
                  }
               }
               if (currentLeft == currentSlice)
               {
                  possibleSlices++;
               }
               currentSlice = 0;
               currentLeft = 0;
            }
            slicerZ++;
         }


         return possibleSlices;
      }
   }
}
