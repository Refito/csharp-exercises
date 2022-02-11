using System;

namespace Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = double.Parse(Console.ReadLine());
            int count = 0, change = Convert.ToInt32(input * 100);

            var typesOfCoins = new int[8] { 200, 100, 50, 20, 10, 5, 2, 1 };

            foreach (var coin in typesOfCoins)
            {
                count += change / coin;
                change %= coin;
            }

            Console.WriteLine(count);
        }
    }
}
