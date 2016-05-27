namespace ExtractSentences
{
   using System;
   using System.Collections.Generic;
   using System.Linq;

   class ExtractSentences
   {
      static void Main()
      {
         //input
         string word = Console.ReadLine();
         var sentences = Console.ReadLine().Split('.').ToArray();

         //logic
         List<string> sentencesWithWord = new List<string>();

         foreach (var item in sentences)
         {
            var current = item.PadLeft(item.Length+1).PadRight(item.Length+2);
            if (current.Contains(word))
            {
               int indexCount = -1;
               do
               {
                  indexCount = current.IndexOf(word, indexCount + 1);
                  if (indexCount > 0 && indexCount + word.Length < current.Length)
                  {
                     if ((current[indexCount - 1] - 'a' < 0 || current[indexCount - 1] - 'z' > 0) &&
                        (current[indexCount + word.Length] - 'a' < 0 || current[indexCount + word.Length] - 'z' > 0))
                     {
                        sentencesWithWord.Add(item.Trim());
                     }
                  }
                  else if (indexCount==0)
                  {
                     if ((current[indexCount + word.Length] - 'a' < 0 || current[indexCount + word.Length] - 'z' > 0))
                     {
                        sentencesWithWord.Add(item.Trim());
                     }
                  }
                  else if (indexCount+word.Length==current.Length)
                  {
                     if ((current[indexCount - 1] - 'a' < 0 || current[indexCount - 1] - 'z' > 0))
                     {
                        sentencesWithWord.Add(item.Trim());
                     }
                  }
               }
               while (indexCount >= 0);
            }
         }

         //output
         Console.WriteLine(string.Join(". ", sentencesWithWord) + '.');
      }
   }
}
