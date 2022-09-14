using System;

namespace Example_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num = int.Parse(input);

            for(int i = -num; i < num; i++) // x제곱 + y제곱 = r 제곱
            {
                for(int j = -num; j < num; j++)
                {
                    if(i * i + j * j <= num * num)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
