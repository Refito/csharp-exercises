using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var moneyNeeded = double.Parse(Console.ReadLine());
            var money = double.Parse(Console.ReadLine());

            int spendingDays = 0, days = 0;

            while (spendingDays < 5)
            {
                days++;
                var action = Console.ReadLine();
                var amount = double.Parse(Console.ReadLine());

                switch (action)
                {
                    case "spend":
                        spendingDays++;
                        money -= Math.Min(money, amount);
                        break;

                    case "save":
                        spendingDays = 0;
                        money += amount;
                        break;
                }

                if (money >= moneyNeeded)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    return;
                }
            }

            Console.WriteLine($"You can't save the money.");
            Console.WriteLine(days);
        }
    }
}
