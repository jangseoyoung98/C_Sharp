/* 메인 함수 파라미터를 받은 데이터를 사용하기 */
using System;

namespace _005_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("지금 듣는 강의는 {0}", args[0]);
            Console.WriteLine("{0} 좋아요!!", args[1]);
        }
        // ★ (Windows 프로그래밍할 때와 달리) cmd를 통해 .exe 다음의 파라미터들은 0부터 시작!
        // ★ C#은 %s 사용 불가능. 대신 자료형에 상관 없이 {#} 형태로 모두 출력 가능! 단, 인수의 인덱스에 맞춰야 함.
    }
}
