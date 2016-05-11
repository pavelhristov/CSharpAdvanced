using System;

class IndexOfLetters
{
   static void Main()
   {
      //input
      string word = Console.ReadLine();

      //logic & output
      int length = 'z' - 'a' + 1;
      char[] alphabet = new char[length];
      for (int i = 0; i < length; i++)
      {
         alphabet[i] = (char)('a' + i);
      }

      foreach (var item in word)
      {
         for (int i = 0; i < length; i++)
         {
            if (item == alphabet[i])
            {
               Console.WriteLine(i);
               break;
            }
         }
      }
   }
}