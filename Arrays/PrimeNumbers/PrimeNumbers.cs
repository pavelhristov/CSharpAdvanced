using System;
using System.Numerics;

class PrimeNumbers
{
   static void Main()
   {
      //input
      uint N = uint.Parse(Console.ReadLine());

      //logic
      bool[] numbers = new bool[N+1];
      for (int i = 0; i <= N; i++)
      {
         numbers[i] = true;
      }

      for (uint i = 2; i <= N; i++)
      {
         if (numbers[i])
         {
            for (ulong j = i*i; j <= N; j+= i)
            {
               numbers[j] = false;
            }
         }
      }
      //output
      for (uint i = N; i >= 0; i--)
      {
         if (numbers[i])
         {
            Console.WriteLine(i);
            return;
         }
      }
   }
}