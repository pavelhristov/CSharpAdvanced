namespace ParseTags
{
   using System;
   using System.Text;

   class ParseTags
   {
      static void Main()
      {
         //input
         string text = Console.ReadLine();

         //logic
         int lastIndex = 0;
         StringBuilder builder = new StringBuilder();
         while (true)
         {
            if (text.IndexOf("<upcase>", lastIndex) != -1)
            {
               builder.Append(text, lastIndex, text.IndexOf(@"<upcase>", lastIndex) - lastIndex);
               var upperCase = text.Substring(text.IndexOf(@"<upcase>", lastIndex) + 8, text.IndexOf(@"</upcase>", lastIndex) - text.IndexOf(@"<upcase>", lastIndex) - 8);
               lastIndex = text.IndexOf(@"</upcase>", lastIndex) + 9;
               builder.Append(upperCase.ToUpper());
            }
            else
            {
               builder.Append(text, lastIndex, text.Length - lastIndex);
               break;
            }
         }
         //output
         Console.WriteLine(builder.ToString());
      }
   }
}
