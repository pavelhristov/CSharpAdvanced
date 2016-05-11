using System;
using System.Linq;

class NumberAsArray
{
   static void Main()
   {
      //input
      int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
      int[] firstNumber = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
      int[] secondNumber = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
      //output
      Console.WriteLine(String.Join(" ",Sum(firstNumber,secondNumber,Math.Max(size[0],size[1]))));
   }
   public static int[] Sum(int[] firstNumber, int[] secondNumber,int size)
   {
      int[] sum = new int[size];
      int[] a = new int[1];
      for (int i = 0; i < size; i++)
      {
         sum[i] += a[0];
         a[0] = 0;
         if (firstNumber.Length>i)
         {
            sum[i] += firstNumber[i];
         }
         if (secondNumber.Length>i)
         {
            sum[i] += secondNumber[i];
         }
         if (sum[i]>9)
         {
            a[0] = sum[i] / 10;
            sum[i] %= 10;
         }
      }
      if (a[0] != 0)
      {
         return sum.Concat(a).ToArray();
      }
      return sum;
   }
}