// 간단한 성적 프로그램 만들기
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _033_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 국,영,수,과 4과목의 점수를 입력 받은 후 총점과 평균을 출력한다.
            // 방법 1 (ReadLine 사용) : string으로 받아서, Parse 혹은 Convert로 int로 변환해서 값 구하기
            
            // 방법 2 (ReadKey 사용) : ConsoleKeyInfo 구조체 변수로 받아서, 이 또한 숫자형으로 형변환 함수 사용할 수 있나..?
            // -> X (이유) 키보드 하나 누르면 바로 다음으로 넘어감 (즉, 한 자리 이상 입력 불가능)

            // 방법 3 (Read 사용)
            // -> X ( 이유) 사용자 입력 키에 대한 아스키 코드를 int로 반환하기 때문에 사용 안 됨!

            string kor;
            string eng;
            string mth;
            string sci;

            int sum;
            double avg;

            Console.Write("국어 점수 입력하세요 : ");
            kor = Console.ReadLine();

            Console.Write("영어 점수 입력하세요 : ");
            eng = Console.ReadLine();

            Console.Write("수학 점수 입력하세요 : ");
            mth = Console.ReadLine();

            Console.Write("과학 점수 입력하세요 : ");
            sci = Console.ReadLine();

            sum = Convert.ToInt32(kor) + Convert.ToInt32(eng) + Convert.ToInt32(mth) + Convert.ToInt32(sci);
            avg = sum / 4;

            Console.WriteLine("국어 : {0}\t영어 : {1}\t수학 : {2}\t과학 : {3}", kor, eng, mth, sci);
            Console.WriteLine("총점 : {0}\t평균 : {1:0.0}", sum, avg);

        }
    }
}
