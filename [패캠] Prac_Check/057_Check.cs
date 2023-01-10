// 5명의 성적(정수)을 입력 받아 가장 높은 점수와 가장 낮은 점수를 출력하는 프로그램
using System;
using System.CodeDom.Compiler;

namespace _057_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] students = new int[5];
            // 배열 선언 방식이 C#과 C/C++은 다르다. []의 위치가..

            for (int i = 0; i < 5; i++)
            {
                Console.Write("학생의 성적을 입력하세요: ");
                students[i] = int.Parse(Console.ReadLine());
            }

            // 최대값 찾기
            int maxIndex = 0;
            for(int i = 1; i < 5; i++)
            {
                if (students[maxIndex] < students[i])
                {
                    maxIndex = i;
                }
            }
            Console.WriteLine("최대값: " + students[maxIndex]);

            // 최소값 찾기
            int minIndex = 0;
            for (int i = 1; i < 5; i++)
            {
                if (students[minIndex] > students[i])
                {
                    minIndex = i;
                }
            }
            Console.WriteLine("최소값: " + students[minIndex]);
        }
    }
}
