using System;

class SayHello
{
   static void Main()
   {
      Hello();
   }
   public static void Hello()
   {
      //input
      string name = Console.ReadLine();
      //output
      Console.WriteLine("Hello, {0}!",name);
   }
}