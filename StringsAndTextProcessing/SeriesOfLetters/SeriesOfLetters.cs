namespace SeriesOfLetters
{
   using System;
   using System.Text;

   class SeriesOfLetters
   {
      static void Main()
      {
         //input
         string str = Console.ReadLine();

         //logic
         char lastChar = str[0];
         StringBuilder builder = new StringBuilder();

         for (int i = 1; i < str.Length; i++)
         {
            if (lastChar!= str[i])
            {
               builder.Append(lastChar);
            }
            lastChar = str[i];
         }
         builder.Append(lastChar);
         //output
         Console.WriteLine(builder.ToString());
      }
   }
}
