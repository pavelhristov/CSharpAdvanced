namespace CorrectBrackets
{
   using System;

   class CorrectBrackets
   {
      static void Main()
      {
         //input
         string expression = Console.ReadLine();

         //logic
         int BracketsCount = 0;
         string result = "Correct";

         foreach (var symbol in expression)
         {
            if (symbol == '(')
            {
               BracketsCount++;
            }
            else if (symbol == ')' && BracketsCount > 0)
            {
               BracketsCount--;
            }
            else if (symbol == ')' && BracketsCount <= 0)
            {
               result = "Incorrect";
               break;
            }
         }
         if (BracketsCount != 0)
         {
            result = "Incorrect";
         }

         //output
         Console.WriteLine(result);
      }
   }
}
