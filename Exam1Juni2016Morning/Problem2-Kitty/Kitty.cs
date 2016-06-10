namespace Problem2_Kitty
{
   using System;
   using System.Linq;


   class Kitty
   {
      static void Main()
      {
         //input
         char[] path = Console.ReadLine().ToCharArray();
         int[] moves = ("0 " + Console.ReadLine()).Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

         //logic
         int souls = 0;
         int food = 0;
         int dreadlocks = 0;
         int position = 0;
         bool flag = true;
         int jumps = -1;
         foreach (var item in moves)
         {
            jumps++;
            position = PositionCheck(position + item, path.Length);
            switch (path[position])
            {
               case '@': souls++; path[position] = '0'; break;
               case '*': food++; path[position] = '0'; break;
               case 'x':
                  dreadlocks++;
                  if (position % 2 == 1)
                  {
                     if (food > 0)
                     {
                        food--;
                     }
                     else
                     {
                        flag = false;
                     }
                  }
                  else
                  {
                     if (souls > 0)
                     {
                        souls--;
                     }
                     else
                     {
                        flag = false;
                     }
                  }
                  break;
               default:
                  break;
            }
            if (flag == false)
            {
               break;
            }
         }

         //output
         if (flag)
         {
            Console.WriteLine("Coder souls collected: {0}", souls);
            Console.WriteLine("Food collected: {0}", food);
            Console.WriteLine("Deadlocks: {0}", dreadlocks);
         }
         else
         {
            Console.WriteLine("You are deadlocked, you greedy kitty!");
            Console.WriteLine("Jumps before deadlock: {0}", jumps);
         }
      }

      public static int PositionCheck(int position, int length)
      {
         if (position >= length)
         {
            while (position >= length)
            {
               position -= length;
            }
         }
         else
         {
            while (position<0)
            {
               position += length;
            }
         }

         return position;
      }
   }
}
