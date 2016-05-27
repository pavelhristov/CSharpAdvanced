using System;

class HexadecimalToBinary
{
   static void Main()
   {
      //input
      char[] hexNumber = Console.ReadLine().ToCharArray();

      //logic
      int length = hexNumber.Length;
      string result = "";

      foreach (var item in hexNumber)
      {
         length--;
         switch (item)
         {
            case 'A': result = result + Convert.ToString(10, 2).PadLeft(4, '0'); continue;
            case 'B': result = result + Convert.ToString(11, 2).PadLeft(4, '0'); continue;
            case 'C': result = result + Convert.ToString(12, 2).PadLeft(4, '0'); continue;
            case 'D': result = result + Convert.ToString(13, 2).PadLeft(4, '0'); continue;
            case 'E': result = result + Convert.ToString(14, 2).PadLeft(4, '0'); continue;
            case 'F': result = result + Convert.ToString(15, 2).PadLeft(4, '0'); continue;
            default:
               result = result + Convert.ToString((item - '0'), 2).PadLeft(4, '0');
               continue;
         }
      }

      //output
      Console.WriteLine(result.TrimStart(new Char[] { '0' }));
   }
}