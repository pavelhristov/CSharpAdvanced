using System;

class TriangleSurfaceBySideAndAltitude
{
   static void Main()
   {
      //input
      double side = double.Parse(Console.ReadLine());
      double altitude = double.Parse(Console.ReadLine());

      //logic
      Triangle triangle = new Triangle(side, altitude);

      //output
      Console.WriteLine("{0:F2}",triangle.Area());
   }

   public class Triangle
   {
      double side;
      double altitude;

      public Triangle(double side, double altitude)
      {
         this.side = side;
         this.altitude = altitude;
      }

      public double Area()
      {
         double result = this.side * this.altitude / 2;
         return result;
      }
   }
}