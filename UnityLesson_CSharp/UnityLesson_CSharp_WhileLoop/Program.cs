using System;

namespace UnityLesson_CSharp_WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // while의 구조
            /*while (조건)
                {
                    조건이 참일 때 반복할 내용
                }*/
            // 무한루프 (while의 조건이 상상 참일 경우)
            // 절대 코드에 있어서 안되는 존재
            /*while (true)
            {

            }*/

            string[] arr_PersonName = new string[3];
            arr_PersonName[0] = "김아무개";
            arr_PersonName[1] = "이아무개";
            arr_PersonName[2] = "박아무개";

            int count = 0;
            while (count < arr_PersonName.Length)
            {
                Console.WriteLine(arr_PersonName[count]);
                count++;
            }

            count = 0;
            while (true)
            {
                if (count < arr_PersonName.Length)
                {
                    Console.WriteLine(arr_PersonName[count]);
                }
                else
                {
                    break;
                }
                count++;
            }
        }
    }
}
