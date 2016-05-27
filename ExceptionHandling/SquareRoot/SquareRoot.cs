namespace SquareRoot
{
   using System;

   class SquareRoot
   {
      static void Main()
      {
         //input & logic & output
         try
         {
            double number = double.Parse(Console.ReadLine());
            if (number<0)
            {
               throw new Exception("Invalid number");
            }
            Console.WriteLine("{0:F3}", Math.Sqrt(number));
         }
         catch (Exception)
         {
            Console.WriteLine("Invalid number");
         }
         finally
         {
            Console.WriteLine("Good bye");
         }
      }
   }
}
