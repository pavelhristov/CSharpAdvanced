using System;
using System.Numerics;

class NFactorial
{
   static void Main()
   {
      //input
      int N = int.Parse(Console.ReadLine());

      //logic
      int[] numbers = new int[N];
      for (int i = 0; i < N; i++)
      {
         numbers[i] = i+1;
      }

      //output
      Console.WriteLine(Factorial(numbers));
   }
   public static BigInteger Factorial(int[] numbers)
   {
      BigInteger result = 1;
      foreach (var item in numbers)
      {
         result *= item;
      }
      return result;
   }
}