namespace Konspiration
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   class Konspiration
   {
      static void Main()
      {
         //input
         int n = int.Parse(Console.ReadLine());
         var lines = new string[n];

         for (int i = 0; i < n; i++)
         {
            lines[i] = Console.ReadLine();
         }

         for (int i = 0; i < n; i++)
         {
            if (lines.Contains(" static "))
            {
               var name = lines[i].Split(new[] { ' ', '(' }, StringSplitOptions.RemoveEmptyEntries)[2];

               i += 1;

               var openBrackets = 0;
               var methodCalls = new List<string>();

               while (openBrackets > 0)
               {
                  var splitByRoundBracket = lines[i].Split('(');

                  if (splitByRoundBracket.Length > 1)
                  {
                     for (int k = 0; k < splitByRoundBracket.Length - 1; k++)
                     {
                        var methodName = ExtraxtMethodName(splitByRoundBracket[k]);

                        if (methodName!=null)
                        {
                           methodCalls.Add(methodName);
                        }
                     }
                  }

                  foreach (var symbol in lines[i])
                  {
                     if (symbol == '{')
                     {
                        openBrackets++;
                     }
                     else if (symbol == '}')
                     {
                        openBrackets--;
                     }
                  }
                  i++;
               }
               Console.WriteLine(name + " -> " + methodCalls.Count + " -> " + string.Join(" ", methodCalls.ToString()));
            }
         }
      }
      static string ExtraxtMethodName(string codePeace)
      {
         var beforeBracket = codePeace.Split(new[] { ' ', '.' }, StringSplitOptions.None);

         var methodName = beforeBracket[beforeBracket.Count() - 1];

         if (char.IsUpper(methodName[0]))
         {
            return methodName;
         }
         return string.Empty;
      }
   }
}
