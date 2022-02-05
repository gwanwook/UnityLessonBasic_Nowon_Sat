using System;

namespace UnityLesson_CSharp_Array
{
    internal class Program
    {
        // array
        // 형태 : 자료형[]
        // 자료형이 '정적'으로 나열되어있는 형태
        // 크기를 한번 정해놓으면 바꿀 수 없다.
        static int[] arr_TestInt = new int[5];
        static float[] arr_TestFloat = new float[3];
        static float[] arr_TestFloat2 = { 1.0f, 2.0f, 3.0f, 4.0f };
        static string[] arr_TestString = new string[3];
        static void Main(string[] args)
        {
            arr_TestInt[0] = 5;
            arr_TestInt[1] = 4;
            arr_TestInt[2] = 3;
            arr_TestInt[3] = 2;
            arr_TestInt[4] = 1;

            Console.WriteLine(arr_TestInt[0]);
            Console.WriteLine(arr_TestInt[1]);
            Console.WriteLine(arr_TestInt[2]);
            Console.WriteLine(arr_TestInt[3]);
            Console.WriteLine(arr_TestInt[4]);

            arr_TestFloat[0] = 111;
            arr_TestFloat[1] = 222;
            arr_TestFloat[2] = 333;

            Console.WriteLine(arr_TestFloat[0]);
            Console.WriteLine(arr_TestFloat[1]);
            Console.WriteLine(arr_TestFloat[2]);

            Console.WriteLine(arr_TestFloat2[0]);
            Console.WriteLine(arr_TestFloat2[1]);
            Console.WriteLine(arr_TestFloat2[2]);
            Console.WriteLine(arr_TestFloat2[3]);

            arr_TestString[0] = "aaa";
            arr_TestString[1] = "bbb";
            arr_TestString[2] = "ccc";

            for (int i = 0; i < arr_TestString.Length; i++)
            {
                Console.WriteLine(arr_TestString[i]);
            }

            float testFlaot = 1.2f;
            string testString = testFlaot.ToString();
            Console.WriteLine(testString);

        }
    }
}
