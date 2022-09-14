using System;

namespace Example_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Char[] Char_Name = input.ToCharArray();
            char index = Char.Parse(".");

            string file_Name = "";
            string Last_Name = "";
            string result_Name = "";

            int count = 1;

            string another_File = "test.txt";

            for (int i = 0; i < input.Length; i++)
            {
                if (Char_Name[i] == index)
                {
                    for(int j = 0; j < i; j++)
                    {
                        file_Name += Char_Name[j];
                    }

                    for (int k = i; k < input.Length; k++)
                    {
                        Last_Name += Char_Name[k];
                    }
                }
            }

            if(file_Name + Last_Name == another_File)
            {
                result_Name = file_Name + $"({count})" + Last_Name;
                count += 1;
            }
            else
            {
                result_Name = file_Name + Last_Name;
            }

            Console.WriteLine(result_Name);
            
            
        }
    }
}
