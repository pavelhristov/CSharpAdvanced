namespace EvenDifferences
{
   using System;
   using System.Linq;


   class EvenDifferences
   {
      static void Main()
      {
         //input
         var numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

         //logic
         long sum = 0;

         for (int i = 1; i < numbers.Length; i++)
         {
            if (Math.Abs(numbers[i] - numbers[i - 1]) % 2 == 0)
            {
               sum += Math.Abs(numbers[i] - numbers[i - 1]);
               i++;
            }
         }

         //output
         Console.WriteLine(sum);
      }
   }
}
