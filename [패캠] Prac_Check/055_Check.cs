// 2개의 정수(1~99) 합을 맞추는 프로그램 -> 5번 반복
using System;

/* Hint 1 : 0~99까지 랜덤 수를 생성하기
 * ▼
 * Random rnd = new Random(); // 랜덤 클래스 사용
 * int a = rnd.Next(0, 100);  // 0 ~ 99 사이의 랜덤한 수 (0 이상 100 미만)
 * int b = rnd.Next(0, 100);
*/

namespace _055_Check
{
    internal class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int input;
            int correct = 0;

           for(int i = 1; i <= 5; i++)
            {
                int num1 = rnd.Next(1, 100);
                int num2 = rnd.Next(1, 100);
                int sum = num1 + num2;

                Console.WriteLine("다음 두 수의 합은 몇?(총 5문제)");
                Console.WriteLine("{0} + {1} = ??", num1, num2);
                input = Convert.ToInt32(Console.ReadLine());

                if (input == sum)
                {
                    Console.WriteLine("== 정답 ==");
                    correct++;
                }
                else // input != sum
                {
                    Console.WriteLine("오답(정답은: " + sum);
                }
            }

            Console.WriteLine("{0} 문제 맞췄습니다!", correct);



        }
    }
}

// 오류 "네임스페이스는 필드, 메서드 또는 문과 같은 멤버를 직접 포함할 수 없습니다."
// ▶ 이유 : 네임 스페이스 바디 부분에 그냥 선언함
// ▶ 해결 ; 반드시 구조체 또는 클래스 내부에서 선언해야 한다.
