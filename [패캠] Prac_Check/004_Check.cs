﻿/* Check : 표준 출력으로 여러 줄의 코드 작성하기 (다양한 입출력) */
using System; // Console을 사용하기 위해 using 함


namespace _004_Check
{
    internal class Program
    { // ＠ internal : 클래스의 멤버 접근 권한 제어로, 이를 가진 멤버는 어셈블리 코드에서만 사용할 수 있음 

        static void Main()
        {
            // 출력 1
            Console.WriteLine("다양한 출력해보기");
            
            // 출력 2
            Console.Write("{0} * {1} = {2}\n", 2, 10, 2*10);
            
            // 출력 3
            for (int i = 1; i <= 3; i++)
            {
                // 앞 : 빈 칸
                for(int j = 1; j + i <= 5; j++)
                {
                    Console.Write(" ");
                }

                // 뒤 : * 채우기
                for(int j = 1; j <= (i * 2 - 1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
