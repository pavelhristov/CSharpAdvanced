namespace BasicLanguage
{
   using System;

   class BasicLanguage
   {
      static void Main()
      {
         //input
         string str = string.Empty;
         while (true)
         {
            str += Console.ReadLine().Replace(@"\t|\n|\r", "");
            if (str.Contains("EXIT"))
            {
               break;
            }
         }

         //logic
         var operations = str.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
         bool exitFlag = false;
         foreach (var item in operations)
         {
            if (exitFlag)
            {
               break;
            }
            var current = item.Split(new[] { "(", ")" }, StringSplitOptions.RemoveEmptyEntries);
            int toPrintIndex = -1;
            int loopCount = 0;

            for (int i = 0; i < current.Length; i++)
            {
               if (current[i].Trim() == "PRINT")
               {
                  toPrintIndex = i + 1;
               }
               if (current[i].Trim() == "FOR")
               {
                  var forCounts = current[i + 1].Split(new[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
                  if (forCounts.Length==1)
                  {
                     loopCount += int.Parse(forCounts[0]);
                  }
                  else
                  {
                     loopCount += int.Parse(forCounts[1]) - int.Parse(forCounts[0]) + 1;
                  }
               }
               if (current[i].Trim() == "EXIT")
               {
                  exitFlag = true;
                  break;
               }
            }
            if (toPrintIndex>=0)
            {
               if (loopCount>0)
               {
                  for (int i = 0; i < loopCount; i++)
                  {
                     Print(current[toPrintIndex]);
                  }
               }
               else
               {
                  Print(current[toPrintIndex]);
               }
            }
         }
         Console.WriteLine();
      }

      public static void Print(string str)
      {
         Console.Write(str);
      }
   }
}
