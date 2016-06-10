namespace BadCat
{
   using System;
   using System.Collections.Generic;

   class BadCat
   {
      static void Main()
      {
         //input
         int n = int.Parse(Console.ReadLine());
         string[,] input = new string[n, 4];
         for (int i = 0; i < n; i++)
         {
            var line = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < 4; j++)
            {
               input[i, j] = line[j];
            }
         }

         //logic
         LinkedList<int> result = new LinkedList<int>();
         result.AddFirst(int.Parse(input[0, 0]));
         int k = 0;
         int count = 0;
         bool flag = true;

         while (flag)
         {
            if (input[k, 1] == "is")
            {
               if (result.Contains(int.Parse(input[k, 0])) && !(result.Contains(int.Parse(input[k, 3]))))
               {
                  if (input[k, 2] == "before")
                  {
                     input[k, 1] = "true";
                     result.AddAfter(result.Find(int.Parse(input[k, 0])), int.Parse(input[k, 3]));
                  }
                  else
                  {
                     input[k, 1] = "true";
                     result.AddBefore(result.Find(int.Parse(input[k, 0])), int.Parse(input[k, 3]));
                  }
               }
               else if (result.Contains(int.Parse(input[k, 3])) && !(result.Contains(int.Parse(input[k, 0]))))
               {
                  if (input[k, 2] == "before")
                  {
                     input[k, 1] = "true";
                     result.AddBefore(result.Find(int.Parse(input[k, 3])), int.Parse(input[k, 0]));
                  }
                  else
                  {
                     input[k, 1] = "true";
                     result.AddAfter(result.Find(int.Parse(input[k, 3])), int.Parse(input[k, 0]));
                  }
               }
               else
               {
                  if (count > 0 && !(result.Contains(int.Parse(input[k, 0]))))
                  {
                     var flag1 = true;
                     if (int.Parse(input[k, 0]) > result.First.Value && flag1)
                     {
                        for (int i = 0; i < 10; i++)
                        {
                           if (result.Contains(int.Parse(input[k, 0]) - i))
                           {
                              result.AddAfter(result.Find(int.Parse(input[k, 0]) - i), int.Parse(input[k, 0]));
                              flag1 = false;
                              break;
                           }
                        }
                     }
                     else if(flag1)
                     {
                        result.AddFirst(int.Parse(input[k, 0]));
                        flag1 = false;
                     }
                     if (int.Parse(input[k, 0]) < result.Last.Value && flag1)
                     {
                        for (int i = 0; i < 10; i++)
                        {
                           if (result.Contains(int.Parse(input[k, 0]) + i))
                           {
                              result.AddBefore(result.Find(int.Parse(input[k, 0]) + i), int.Parse(input[k, 0]));
                              flag1 = false;
                              break;
                           }
                        }
                     }
                     else if (flag1)
                     {
                        result.AddLast(int.Parse(input[k, 0]));
                        flag1 = false;
                     }
                  }
               }
            }
            if (k < n - 1)
            {
               k++;
            }
            else
            {
               k = 0;
               count++;
            }
            flag = false;
            for (int i = 0; i < n; i++)
            {
               if (result.Contains(int.Parse(input[i, 0])) && result.Contains(int.Parse(input[i, 3])))
               {
                  input[i, 1] = "true";
               }
               else
               {
                  input[i, 1] = "is";
               }
               if (input[i, 1] == "is")
               {
                  flag = true;
               }
            }
         }

         //output
         Console.WriteLine(string.Join("", result));
      }
   }
}