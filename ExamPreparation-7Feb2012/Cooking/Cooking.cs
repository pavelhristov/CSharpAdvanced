namespace Cooking
{
   using System;
   using System.Collections.Generic;
   using System.Linq;

   class Cooking
   {

      public static string[,] transformTable = new[,]
      {
            { "1" , "tbsps"      , "3"    , "tsps" },
            { "1" , "gals"       , "4"    , "quarts" },
            { "1" , "ls"         , "1000" , "mls" },
            { "1" , "pts"        , "2"    , "cups" },
            { "8" , "fl ozs"     , "1"    , "cups" },
            { "1" , "qts"        , "2"    , "pts" },
            { "1" , "teaspoons"  , "5"    , "mls" },
            { "1" , "cups"       , "48"   , "tsps" }
      };
      public static List<string> alreadyChecked = new List<string>();
      static void Main()
      {
         //input
         int recipeCount = int.Parse(Console.ReadLine());
         string[,] recipe = ReadAll(recipeCount);
         int usedCount = int.Parse(Console.ReadLine());
         string[,] used = ReadAll(usedCount);

         //logic
         List<string> needed = new List<string>();

         for (int i = 0; i < recipeCount; i++)
         {
            bool flag = true;
            for (int j = 0; j < usedCount; j++)
            {
               if (recipe[i, 2] == used[j, 2]) //checking if it is already used
               {
                  var added = double.Parse(recipe[i, 0]) - double.Parse(used[j, 0]);
                  if (added > 0)
                  {
                     if (needed.Contains(recipe[i, 2]))
                     {
                        needed[needed.IndexOf(recipe[i, 2]) - 2] = (Convert.ToDouble(needed[needed.IndexOf(recipe[i, 2]) - 2]) + added).ToString();
                        flag = false;
                     }
                     else
                     {
                        needed.Add(added.ToString());
                        needed.Add(recipe[i, 1]);
                        needed.Add(recipe[i, 2]);
                        flag = false;
                     }
                  }
                  else
                  {
                     flag = false;
                  }
               }
            }
            if (needed.Contains(recipe[i, 2]) && flag)
            {
               needed[needed.IndexOf(recipe[i, 2]) - 2] = (Convert.ToDouble(needed[needed.IndexOf(recipe[i, 2]) - 2]) + Convert.ToDouble(recipe[i, 0])).ToString();
            }
            else if (flag)
            {
               needed.Add(recipe[i, 0]);
               needed.Add(recipe[i, 1]);
               needed.Add(recipe[i, 2]);
            }
         }

         //output
         int newLineCount = 0;
         Console.WriteLine();
         while (needed.Count > 0)
         {
            if (newLineCount == 0)
            {
               double value = double.Parse(needed[0]);
               Console.Write("{0:F2}:", value);
               newLineCount++;
               needed.RemoveAt(0);
            }
            else if (newLineCount == 1)
            {
               Console.Write("{0}:", needed[0]);
               newLineCount++;
               needed.RemoveAt(0);
            }
            else if (newLineCount == 2)
            {
               Console.WriteLine("{0}", needed[0]);
               newLineCount = 0;
               needed.RemoveAt(0);
            }
         }
      }

      public static string[,] ReadAll(int length)
      {
         //sorcery 
         string[,] result = new string[length, 3];
         for (int i = 0; i < length; i++)
         {
            var current = Console.ReadLine().Split(new[] { ":" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var index = alreadyChecked.FindIndex(x => x.Equals(current[2], StringComparison.OrdinalIgnoreCase)); //check if current product was already stated and convertion
            if (index == -1)
            {
               alreadyChecked.Add(current[0]);
               alreadyChecked.Add(current[1]);
               alreadyChecked.Add(current[2]);
            }
            else if (current[1] != alreadyChecked[index - 1])
            {
               for (int k = 0; k < transformTable.GetLength(0); k++)
               {
                  if (alreadyChecked[index - 1] == transformTable[k, 1] && current[1] == transformTable[k, 3])
                  {
                     current[0] = (double.Parse(current[0]) / double.Parse(transformTable[k, 2])).ToString();
                     current[1] = alreadyChecked[index - 1];
                  }
                  else if (alreadyChecked[index - 1] == transformTable[k, 3] && current[1] == transformTable[k, 3])
                  {
                     current[0] = (double.Parse(current[0]) * double.Parse(transformTable[k, 0])).ToString();
                     current[1] = alreadyChecked[index - 1];
                  }
               }
            }
            if (index >= 0)
            {
               current[2] = alreadyChecked[index];
            }
            result[i, 0] = current[0];
            result[i, 1] = current[1];
            result[i, 2] = current[2];
         }

         return result;
      }
   }
}