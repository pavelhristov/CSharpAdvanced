namespace StringLength
{
   using System;
   using System.Text;

   class StringLength
   {
      static void Main()
      {
         //input
         string str = Console.ReadLine().Replace(@"\", string.Empty);

         //output
         Console.WriteLine(PaddingAsteriskRight(str));
      }

      public static string PaddingAsteriskRight(string str)
      {
         StringBuilder builder = new StringBuilder();
         builder.Append(str);

         //evil magic
         for (int i = str.Length; i < 20; i++)
         {
            builder.Append('*');
         }

         return builder.ToString();
      }
   }
}
