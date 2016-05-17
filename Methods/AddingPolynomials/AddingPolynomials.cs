using System;
using System.Linq;

class AddingPolynomials
{
   static void Main()
   {
      //input
      int N = int.Parse(Console.ReadLine());
      int[] firstPolynomial = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
      int[] secondPolynomial = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

      //logic
      string sum = string.Join(" ", SumOfPolynomials(firstPolynomial, secondPolynomial, N));

      //output
      Console.WriteLine(sum);
   }
   public static int[] SumOfPolynomials(int[] firstPolynomial, int[] secondPolynomial, int length)
   {
      int[] sum = new int[length];
      for (int i = 0; i < length; i++)
      {
         sum[i] = firstPolynomial[i] + secondPolynomial[i];
      }
      return sum;
   }
}