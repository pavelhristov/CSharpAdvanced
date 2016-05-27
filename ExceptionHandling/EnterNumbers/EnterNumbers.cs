namespace EnterNumbers
{
   using System;
   using System.Text;

   class EnterNumbers
   {
      static void Main()
      {
         const int start = 1;
         const int end = 100;

         //output
         Console.WriteLine(ReadNumber(start, end));
      }

      public static string ReadNumber(int start, int end)
      {
         //input
         int[] numbers = new int[10];
         for (int i = 0; i < 10; i++)
         {
            numbers[i] = int.Parse(Console.ReadLine());
         }
         //logic
         StringBuilder builder = new StringBuilder();
         builder.Append(start);
         int last = start;
         try
         {
            for (int i = 0; i < 10; i++)
            {
               builder.Append(" < ");
               if (numbers[i] > last)
               {
                  builder.Append(numbers[i]);
                  last = numbers[i];
               }
               else
               {
                  throw new Exception("Exception");
               }
            }

         }
         catch (Exception e)
         {
            return e.Message;
         }
         builder.Append(" < ");
         builder.Append(end);

         return builder.ToString();
      }
   }
}
