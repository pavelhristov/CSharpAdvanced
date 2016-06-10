namespace SecretLanguage
{
   using System;
   using System.Linq;

   class SecretLanguage
   {
      static void Main()
      {
         //input
         string sentance = ' ' + Console.ReadLine();
         string[] words = Console.ReadLine().Split(new[] { " ", ",", "\"" }, StringSplitOptions.RemoveEmptyEntries).ToArray();

         //logic
         int[] result = new int[sentance.Length];
         result = result.Select(x => int.MaxValue- 1000).ToArray();
         result[0] = 0;
         for (int i = 1; i < sentance.Length; i++)
         {
            foreach (var item in words)
            {
               if (item.Length <= i)
               {
                  int currentMoves = 0;
                  var currentWord = item.ToCharArray();
                  Array.Sort(currentWord);
                  var currentSentancePart = sentance.Substring(i - item.Length+1, item.Length).ToCharArray();
                  var currentCheck = sentance.Substring(i - item.Length+1, item.Length);
                  Array.Sort(currentSentancePart);
                  if (currentSentancePart.SequenceEqual(currentWord))
                  {
                     for (int j = 0; j < item.Length; j++)
                     {
                        if (item[j] != currentCheck[j])
                        {
                           currentMoves++;
                        }
                     }
                     result[i] = Math.Min(currentMoves + result[i - item.Length], result[i]);
                  }
               }
            }
         }


         //output
         if (result[sentance.Length-1] == int.MaxValue-1000)
         {
            Console.WriteLine(-1);
         }
         else
         {
            Console.WriteLine(result[sentance.Length-1]);
         }
      }
   }
}