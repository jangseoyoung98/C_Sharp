// type 1. enum (열거형)
// 게임 작동법을 열거형으로 만들어 보겠다.
using System;

namespace _000_practiceDataType
{
    internal class Program
    {
        // type1. enum (열거형)
        enum CHAR_STATE
        {
            IDLE, WALK, RUN, DIE
          //  0     1    2    3
          // ★V 콤마(,) 안 붙여도 되는지? 3번 -> 가능!
        }

        enum CLICK_STATE
        {
            NONE, // 0
            CLICK = 100, 
            DOUBLE_CLICK = 200,
            UP, // 201
        }

        static void Main(string[] args)
        {
            CHAR_STATE charState = CHAR_STATE.IDLE;
            Console.WriteLine("캐릭터 상태 : {0}  {1}", charState, (int)charState);

            // more examples..!


        }
    }
}
