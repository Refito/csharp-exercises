using System;

namespace Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            var pieces = width * height;

            var input = Console.ReadLine();
            while (input != "STOP")
            {
                var count = int.Parse(input);

                pieces -= count;
                if (pieces < 0)
                {
                    Console.WriteLine($"No more cake left! You need {pieces * -1} pieces more.");
                    return;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{pieces} pieces are left.");
        }
    }
}
