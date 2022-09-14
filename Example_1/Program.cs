using System;
using System.Collections.Generic;

namespace Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input_ = Console.ReadLine();
            Char[] Ch_input = input_.ToCharArray();

            Stack<char> _stack = new Stack<char>();

            if(input_.Length < 50)
            {
                for (int i = 0; i < Ch_input.Length; i++)
                {
                    _stack.Push(Ch_input[i]);
                }

                foreach (object obj in _stack)
                {
                    Console.Write(obj);
                }
            }
            else
            {
                Console.Write("50글자 이상이라 안됨");
            }
           

        }
    }
}
