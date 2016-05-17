using System;
using System.Linq;

class IntegerCalculations
{
   static void Main()
   {
      //input
      int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

      //logic
      int length = 5;

      //output
      Console.WriteLine(Minimum(numbers,length));
      Console.WriteLine(Maximum(numbers, length));
      Console.WriteLine("{0:F2}",Avarage(numbers, length));
      Console.WriteLine(Sum(numbers, length));
      Console.WriteLine(Product(numbers, length));
   }
   public static int Minimum(int[] numbers,int length)
   {
      int min = int.MaxValue;
      for (int i = 0; i < length; i++)
      {
         if (numbers[i]<min)
         {
            min = numbers[i];
         }
      }
      return min;
   }
   public static int Maximum(int[] numbers, int length)
   {
      int max = int.MinValue;
      for (int i = 0; i < length; i++)
      {
         if (numbers[i] > max)
         {
            max = numbers[i];
         }
      }
      return max;
   }
   public static double Avarage(int[] numbers, int length)
   {
      double avarage = 0;
      foreach (var item in numbers)
      {
         avarage += item;
      }
      return avarage/length;
   }
   public static int Sum(int[] numbers, int length)
   {
      int sum =0;
      foreach (var item in numbers)
      {
         sum += item;
      }
      return sum;
   }
   public static long Product(int[] numbers, int length)
   {
      long product = 1;
      foreach (var item in numbers)
      {
         product *= item;
      }
      return product;
   }
}