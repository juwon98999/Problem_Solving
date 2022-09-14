using System;

namespace Example_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string num = "1";


            for (int i = 0; i < input; i++)
            {
                num = (Recursive(num));
                Console.WriteLine("총 결과값 : " + num);
            } 

        }

        
        static string Recursive(string num) //재귀함수
        {
            if (string.IsNullOrEmpty(num))
            {
                return "";
            }       
            else if(num.Length == 1)
            {
                return num[0] + "1";
            }

            if(num[num.Length - 1] != num[num.Length - 2])
            {
                Console.WriteLine("서브 스트링 값 확인 :" + num.Substring(0, num.Length - 1));
                Console.WriteLine("그 다음값 확인 :" + num[num.Length - 1]);
                Console.WriteLine("마무리 확인 :" + Recursive(num.Substring(0, num.Length - 1)) + num[num.Length - 1] + "1");
                return Recursive(num.Substring(0, num.Length - 1)) + num[num.Length - 1] + "1";
            }
            else
            {
                Console.WriteLine("Num 개수는 : " + num.Length);
                string a = Recursive(num.Substring(0, num.Length - 1));
                Console.WriteLine("A는 : "+ a);
                int last_Num = int.Parse(a.Substring(a.Length - 1, 1)) + 1;
                Console.WriteLine("마지막 Num은 : " + last_Num);
                return a.Substring(0, a.Length - 1) + last_Num.ToString();
            }

        }
    }
}
