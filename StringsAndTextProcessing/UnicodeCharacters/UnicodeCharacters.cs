namespace UnicodeCharacters
{
   using System;

   class UnicodeCharacters
   {
      static void Main()
      {
         //input
         string str = Console.ReadLine().Replace(@"\", string.Empty);

         //logic & output
         for (int i = 0; i < str.Length; i++)
         {
            Console.Write("\\u" + ((int)str[i]).ToString("X4"));
         }
      }
   }
}
