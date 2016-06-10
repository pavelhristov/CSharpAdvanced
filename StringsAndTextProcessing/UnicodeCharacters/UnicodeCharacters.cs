namespace UnicodeCharacters
{
   using System;

   class UnicodeCharacters
   {
      static void Main()
      {
         //input
         string str = Console.ReadLine();

         //logic & output
         for (int i = 0; i < str.Length; i++)
         {
            Console.Write("\\u{0:X4}",(int)str[i]);
         }
      }
   }
}
