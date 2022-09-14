using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = 1.ToString();
            Console.WriteLine(num);
            for (int i = 0; i < 10; i++)
            {
                num = LookAndSayRecursive(num);
                Console.WriteLine(num);
            }
        }

        static string LookAndSayRecursive(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";
            if (s.Length == 1) return s[0] + "1";

            if (s[s.Length - 1] != s[s.Length - 2])
            {
                return LookAndSayRecursive(s.Substring(0, s.Length - 1))
                       + s[s.Length - 1] + "1";
            }
            else
            {
                string r = LookAndSayRecursive(s.Substring(0, s.Length - 1));
                int lastN = int.Parse(r.Substring(r.Length - 1, 1)) + 1;
                return r.Substring(0, r.Length - 1) + lastN.ToString();
            }
        }
    }
}
