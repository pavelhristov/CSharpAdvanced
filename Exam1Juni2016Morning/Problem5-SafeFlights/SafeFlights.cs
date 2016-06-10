namespace Problem5_SafeFlights
{
   using System;
   using System.Linq;

   class SafeFlights
   {
      static void Main()
      {
         //input
         int n = int.Parse(Console.ReadLine());
         string current = Console.ReadLine();
         int[,] flights = new int[n, n];
         while (current != "-1 -1")
         {
            var islands = current.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            if (flights[islands[0], islands[1]] == 0 && flights[islands[1], islands[0]] == 0)
            {
               flights[islands[0], islands[1]] = 1;
               flights[islands[1], islands[0]] = 1;
            }
            else if (flights[islands[0], islands[1]] >= 1 || flights[islands[1], islands[0]] >= 1)
            {
               flights[islands[0], islands[1]] = -1;
               flights[islands[1], islands[0]] = -1;
            }
            current = Console.ReadLine();
         }

         //logic
         int count = 0;
         
         Console.WriteLine(count);
      }
   }
}
//for participation
