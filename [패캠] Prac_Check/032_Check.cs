// GetType() 함수로 (int, string, float, char)형 CTS 표준 출력하기
using System;

namespace _032_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            string b = "AAA";
            // Single c = 0.123f; -> Single 구조체 - 4바이트 (단정밀도) 실수. 리터럴 접미사 'f' 붙여야 함
            float c = 0.123f; // System.Single은 float이라고 보면 됨
            char d = 'A';


            Console.Write("a:  {0}, a.GetType():  {1}\n", a, a.GetType());
            Console.Write("b:  {0}, b.GetType():  {1}\n", b, b.GetType());
            Console.Write("c:  {0}, c.GetType():  {1}\n", c, c.GetType());
            Console.Write("d:  {0}, d.GetType():  {1}\n", d, d.GetType());

        }
    }
}
 
