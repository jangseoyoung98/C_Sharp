// 랜덤한 정수(1~99)를 맞추는 프로그램
using System;

namespace _056_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndNum = rnd.Next(1, 100);

            int input;
            int i = 0;
            
            Console.Write("1~99 사이 어떤 숫자일까요~? (단, 0은 나가기) : ");

            while (true)
            {
                input = int.Parse(Console.ReadLine());

                if (input == 0)
                    break;
                
                i++;

                if (rndNum == input)
                {
                    Console.WriteLine("== 축! 정답입니다. ==");
                    break;
                }
                else if (rndNum > input)
                {
                    Console.WriteLine("흠..입력한 수는 작습니다!");
                }
                else // rndNum < input
                {
                    Console.WriteLine("흠..입력한 수는 큽니다!");
                }
            }

            Console.WriteLine("총 {0}번 시도", i);

        }
    }
}
