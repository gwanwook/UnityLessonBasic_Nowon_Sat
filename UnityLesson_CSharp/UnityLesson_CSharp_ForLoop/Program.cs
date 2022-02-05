using System;

namespace UnityLesson_CSharp_ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for문
            // 기본형태
            /*for (int i = 0; i < length; 반복문 마지막에 실행할 문장)
            {

            }*/

            string[] arr_PersonName = new string[9];
            arr_PersonName[0] = "김아무개";
            arr_PersonName[1] = "이아무개";
            arr_PersonName[2] = "박아무개";
            arr_PersonName[3] = "김아무개";
            arr_PersonName[4] = "이아무개";
            arr_PersonName[5] = "박아무개";
            arr_PersonName[6] = "김아무개";
            arr_PersonName[7] = "이아무개";
            arr_PersonName[8] = "박아무개";

            for (int i = 0; i < arr_PersonName.Length; i++)
            {
                Console.WriteLine(arr_PersonName[i]);
            }

            // 김아무개만 출력. 김아무개의 인덱스 규칙은 : 3n
            // 모든 배열 요소를 검색하는 예시
            for (int i = 0; i < arr_PersonName.Length; i++)
            {
                if(arr_PersonName[i] == "김아무개")
                {
                    Console.WriteLine(arr_PersonName[i]);
                }
            }

            // 인덱스 규칙을 활용한 예시
            for (int i = 0; i < arr_PersonName.Length; i+=3)
            {
                Console.WriteLine(arr_PersonName[i]);
            }
        }
    }
}
