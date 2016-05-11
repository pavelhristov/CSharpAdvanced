using System;

class FrequentNumber
{
   static void Main()
   {
      //input
      int N = int.Parse(Console.ReadLine());
      int[] numbers = new int[N];
      for (int i = 0; i < N; i++)
      {
         numbers[i] = int.Parse(Console.ReadLine());
      }

      //logic
      int currentCounter = 1;
      int maxCounter = 1;
      int mostFrequentNumber=0;

      for (int i = 0; i < N; i++)
      {
         for (int j = 0; j < N; j++)
         {
            if ((numbers[i] == numbers[j]) && (i!=j))
            {
               currentCounter++;
            }
         }
         if (currentCounter>maxCounter)
         {
            maxCounter = currentCounter;
            mostFrequentNumber = numbers[i];
            currentCounter = 1;
         }
         else
         {
            currentCounter = 1;
         }
      }

      //output
      Console.WriteLine("{0} ({1} times)",mostFrequentNumber,maxCounter);
   }
}