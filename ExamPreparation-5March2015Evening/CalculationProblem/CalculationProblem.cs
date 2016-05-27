namespace CalculationProblem
{
   using System;
   using System.Linq;

   class CalculationProblem
   {
      static void Main()
      {
         //input
         var sum = Console.ReadLine().Split(' ').Select(MeowToDec).Sum();

         //output
         Console.WriteLine("{0} = {1}", DecToMeow(sum), sum);
      }

      static int MeowToDec(string meow)
      {
         int result = 0;

         //magic
         foreach (char digit in meow)
         {
            result = (digit - 'a') + result * 23;
         }

         return result;
      }

      static string DecToMeow(int dec)
      {
         var result = string.Empty;

         //extra magic
         do
         {
            char digit = (char)('a' + dec % 23);
            result = digit + result;
            dec /= 23;
         } while (dec > 0);

         return result;
      }
   }
}
