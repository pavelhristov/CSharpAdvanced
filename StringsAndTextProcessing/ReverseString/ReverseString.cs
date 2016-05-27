namespace ReverseString
{
   using System;
   using System.Text;
   class ReverseString
   {
      static void Main()
      {
         //input
         string str = Console.ReadLine();
         //output
         Console.WriteLine(ReversingString(str));
      }

      public static string ReversingString(string str)
      {
         //magic
         var array = str.ToCharArray();
         StringBuilder builder = new StringBuilder();

         for (int i = array.Length - 1; i >= 0; i--)
         {
            builder.Append(array[i]);
         }
         return builder.ToString();
      }
   }
}
