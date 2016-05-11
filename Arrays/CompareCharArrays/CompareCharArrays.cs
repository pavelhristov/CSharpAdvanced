using System;

class CompareCharArrays
{
   static void Main()
   {
      //input
      char[] firstArray = Console.ReadLine().ToCharArray();
      char[] secondArray = Console.ReadLine().ToCharArray();

      //logic & output
      int firstSize = firstArray.Length;
      int secondSize = secondArray.Length;
      bool flag = true;

      for (int i = 0; i < Math.Min(firstSize, secondSize); i++)
      {
         if (firstArray[i] > secondArray[i])
         {
            flag = false;
            Console.WriteLine(">");
            break;
         }
         else if (firstArray[i] < secondArray[i])
         {
            flag = false;
            Console.WriteLine("<");
            break;
         }
      }
      if (flag)
      {
         if (firstSize > secondSize)
         {
            Console.WriteLine(">");
         }
         else if (secondSize > firstSize)
         {
            Console.WriteLine("<");
         }
         else
         {
            Console.WriteLine("=");
         }
      }
   }
}