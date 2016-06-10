namespace ReplaceTags
{
   using System;
   using System.Text;

   class ReplaceTags
   {
      static void Main()
      {
         //input
         string str = Console.ReadLine();

         //most evil magic ever
         StringBuilder builder = new StringBuilder();
         bool isInA = false;
         bool isInURL = false;
         bool isInText = false;
         StringBuilder text = new StringBuilder();
         text.Append("[");
         StringBuilder url = new StringBuilder();
         url.Append("(");

         builder.Append(str[0]);

         for (int i = 1; i < str.Length; i++)
         {
            if (isInText)
            {
               text.Append(str[i]);
            }
            if (isInURL)
            {
               url.Append(str[i]);
            }

            if (!isInA)
            {
               builder.Append(str[i]);
            }

            if (str[i] == 'a' && str[i - 1] == '<')
            {
               builder.Remove(builder.Length - 2, 2);
               isInA = true;
            }
            else if (str[i] == '>' && str[i - 1] == 'a')
            {
               text.Append("]");
               builder.Append(text);
               text.Clear();
               text.Append("[");
               url.Append(")");
               builder.Append(url);
               url.Clear();
               url.Append("(");
               isInA = false;
            }

            if (isInA && str[i] == '\"' && str[i - 1] == '=')
            {
               isInURL = true;
            }
            else if (isInA && str[i + 1] == '\"' && str[i] != '=')
            {
               isInURL = false;
            }

            if (isInA && str[i] == '>' && str[i - 1] != 'a')
            {
               isInText = true;
            }
            else if (isInA && str[i + 1] == '<' && str[i] != '\\')
            {
               isInText = false;
            }
         }
         //output
         Console.WriteLine(builder.ToString());
      }
   }
}
