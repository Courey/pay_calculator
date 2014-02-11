using System;

public class PayCalculator
{
   public static void Main(string[] args)
   {
      int days;
      int pay;
      int i;
      int payPlus;
      int pay2;
      decimal total;

      Console.WriteLine("Enter pay days:");
      days = Convert.ToInt32(Console.ReadLine());
      i = days;
      pay = 0;
      payPlus = 1;
      pay2 = 1;

      if (i <= 0)
      {
         Console.WriteLine("Please enter positive value.");
         days = Convert.ToInt32(Console.ReadLine());

      }

      i = days;

      if (i >= 0)
      {

         if (i == 1)
         {
            pay = 1;
            total = (decimal)pay/100;

         }

         if (i >= 15)
         {
            pay = (1050 * (days - 14)) + 16383;

            total = (decimal)(pay) / 100;
         }

         if (i < 15 && i > 1)
         {
            for (i = 1; i < days; i++)
            {
               payPlus = (payPlus * 2);
               pay2 = pay2 + payPlus;

            }
            total = (decimal)(pay2) / 100;

            Console.WriteLine("pay is {0:C}", total);
            Console.ReadLine();

         }
      }
      Console.ReadLine();
   }
}
