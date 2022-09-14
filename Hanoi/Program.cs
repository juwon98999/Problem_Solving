using System;

namespace Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("원반의 개수를 입력하세요.");
            int input = int.Parse(Console.ReadLine());
            Hanoi(input, 'A', 'C', 'B');
        }

        private static void Hanoi(int n, char from, char to, char end)
        {
            if (n == 1)
            {
                Console.WriteLine($"Move: {from} -> {to}");
            }
            else
            {
                Hanoi(n - 1, from, end, to);
                Console.WriteLine($"Move: {from} -> {to}");
                Hanoi(n - 1, end, to, from);
            }
        }
    }
}
