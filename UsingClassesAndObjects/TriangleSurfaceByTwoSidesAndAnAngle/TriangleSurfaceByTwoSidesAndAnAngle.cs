using System;

class TriangleSurfaceByTwoSidesAndAnAngle
{
   static void Main()
   {
      //input
      double sideA = double.Parse(Console.ReadLine());
      double sideB = double.Parse(Console.ReadLine());
      double angleAB = double.Parse(Console.ReadLine());
      //logic
      Triangle triangle = new Triangle(sideA, sideB, angleAB);
      //output
      Console.WriteLine("{0:F2}", triangle.Area());
   }

   public class Triangle
   {
      double sideA;
      double sideB;
      double angleAB;

      public Triangle(double sideA, double sideB, double angleAB)
      {
         this.sideA = sideA;
         this.sideB = sideB;
         this.angleAB = angleAB;
      }

      public double Area()
      {
         double result = sideA * sideB * Math.Sin(angleAB * Math.PI / 180) / 2;
         return result;
      }
   }
}