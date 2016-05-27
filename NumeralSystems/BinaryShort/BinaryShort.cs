using System;

class BinaryShort
{
   static void Main()
   {
      //input
      short N = short.Parse(Console.ReadLine());

      //logic
      bool flag = false;
      short current;
      string shortBinary = "";
      string result = "";

      if (N == short.MinValue)
      {
         Console.WriteLine("1000000000000000");
         return;
      }
      if (N == 0)
      {
         shortBinary = "0";
      }
      else if (N < 0)
      {
         flag = true;
         N = Math.Abs(N);
      }

      for (int i = 0; Math.Abs(N) > 0; i++, N = Convert.ToInt16(N / 2))
      {
         current = Convert.ToInt16(Convert.ToInt32(N) % 2);
         shortBinary = current.ToString() + shortBinary;
      }
      shortBinary = shortBinary.PadLeft(16, '0');

      if (flag)
      {
         result = shortBinary[15] + result;
         for (int i = 14; i >= 0; i--)
         {
            if (shortBinary[i] == '1')
            {
               result = '0' + result;
            }
            else
            {
               result = '1' + result;
            }
         }
      }
      else
      {
         result = shortBinary;
      }
      //output
      Console.WriteLine(result);
   }
}