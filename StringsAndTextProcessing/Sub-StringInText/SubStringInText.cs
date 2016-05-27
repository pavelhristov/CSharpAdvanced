namespace Sub_StringInText
{
   using System;

   class SubStringInText
   {
      static void Main()
      {
         //input
         string subStr = Console.ReadLine().ToLower();
         string str = Console.ReadLine().ToLower();

         //logic
         int indexCount = -1;
         int counter = 0;
         do
         {
            indexCount = str.IndexOf(subStr, indexCount + 1);
            if (indexCount >=0)
            {
               counter++;
            }
         }
         while (indexCount >= 0);

         //output
         Console.WriteLine(counter);
      }
   }
}
