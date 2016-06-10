namespace MessagesInABottle
{
   using System;
   using System.Linq;

   class MessagesInABottle
   {
      static void Main()
      {
         //input
         string message = Console.ReadLine();
         string cipher = Console.ReadLine();

         //logic
         string currentCodes = string.Empty;
         string currentChars = string.Empty;
         foreach (var item in cipher)
         {
            if (item - '0' >= 0 && item <= '9')
            {
               currentCodes += item;
               currentChars += ' ';
            }
            else
            {
               currentChars += item;
               currentCodes += ' ';
            }
         }
         string result = string.Empty;
         var codes = currentCodes.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
         string[] chars = currentChars.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

         int loop = 1;
         int count = 0;
         int range = loop;
         while (range<=message.Length)
         {
            string currentResult = string.Empty;
            while (range+count <= message.Length)
            {
               long current = long.Parse(message.Substring(count, range));
               if (codes.Contains(current))
               {
                  currentResult += chars[codes.IndexOf(current)];
                  count += range;
                  range = 1;
                  continue;
               }
               range++;
            }
            result += currentResult + " ";
            loop++;
            range = loop;
            count = 0;
         }

         //output
         var finalResult = result.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
         int length = finalResult.Length;
         Console.WriteLine(length);
         foreach (var item in finalResult)
         {
            Console.WriteLine(item);
         }
      }
   }
}
