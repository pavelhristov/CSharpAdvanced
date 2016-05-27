namespace ParseURL
{
   using System;

   class ParseURL
   {
      static void Main()
      {
         //input
         var str = Console.ReadLine();
         //logic
         string protocol = str.Split(new[] { @"://" }, StringSplitOptions.None)[0];
         str = str.Split(new[] { @"://" }, StringSplitOptions.None)[1];
         string server = string.Empty;
         string resource = string.Empty;

         int separation = str.IndexOf(@"/");
               server = str.Substring(0, separation);
         resource = str.Substring(separation, str.Length - separation);

         //output
         Console.WriteLine("[protocol] = {0}",protocol);
         Console.WriteLine("[server] = {0}", server);
         Console.WriteLine("[resource] = {0}", resource);
      }
   }
}
