using System;

class OneSystemToAnyOther
{
   static void Main()
   {
      //input
      int s = int.Parse(Console.ReadLine());
      char[] hexNumber = Console.ReadLine().ToCharArray();
      int d = int.Parse(Console.ReadLine());

      //logic
      int length = hexNumber.Length;
      long decNumber = 0;

      foreach (var item in hexNumber)
      {
         length--;
         switch (item)
         {
            case 'A': decNumber = decNumber + 10 * (long)Math.Pow(s, length); continue;
            case 'B': decNumber = decNumber + 11 * (long)Math.Pow(s, length); continue;
            case 'C': decNumber = decNumber + 12 * (long)Math.Pow(s, length); continue;
            case 'D': decNumber = decNumber + 13 * (long)Math.Pow(s, length); continue;
            case 'E': decNumber = decNumber + 14 * (long)Math.Pow(s, length); continue;
            case 'F': decNumber = decNumber + 15 * (long)Math.Pow(s, length); continue;
            default:
               decNumber = decNumber + (item - '0') * (long)Math.Pow(s, length);
               continue;
         }
      }

      long current;
      string result = "";
      for (long i = 0; decNumber > 0; i++, decNumber = decNumber / d)
      {
         current = (decNumber % d);
         switch (current)
         {
            case 10: result = "A" + result; continue;
            case 11: result = "B" + result; continue;
            case 12: result = "C" + result; continue;
            case 13: result = "D" + result; continue;
            case 14: result = "E" + result; continue;
            case 15: result = "F" + result; continue;
            default:
               result = current.ToString() + result;
               continue;
         }
      }
      //output
      Console.WriteLine(result);
   }
}