using System;

namespace Example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Char[] input = str.ToCharArray();

            Random Ran_ = new Random();


            for(int i = 0; i < input.Length; i++)
            {
                int Ran_Num = Ran_.Next(0, input.Length);
                char temp = input[i];
                input[i] = input[Ran_Num];
                input[Ran_Num] = temp;
            }

            for(int j = 0; j < input.Length; j++)
            {
                Console.Write(input[j]);
            }
        }
    }
}
