using System;

class TriangleSurfaceByThreeSides
{
   static void Main()
   {
      //input
      double sideA = double.Parse(Console.ReadLine());
      double sideB = double.Parse(Console.ReadLine());
      double sideC = double.Parse(Console.ReadLine());
      //logic
      Triangle triangle = new Triangle(sideA, sideB, sideC);
      //output
      Console.WriteLine("{0:F2}", triangle.Area());
   }

   public class Triangle
   {
      double sideA;
      double sideB;
      double sideC;

      public Triangle(double sideA, double sideB, double sideC)
      {
         this.sideA = sideA;
         this.sideB = sideB;
         this.sideC = sideC;
      }

      public double Area()
      {
         double p = (sideA + sideB + sideC) / 2;
         double result = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
         return result;
      }
   }
}