using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLesson_CSharp_Operator
{
    static public class OperatorMothods
    {
        // 산술 연산
        //============================================================
        // 더하기
        static public int Sum(int a, int b)
        {
            return a + b;
        }
        // 빼기
        static public int Minus(int a, int b)
        {
            return a - b;
        }
        // 나누기
        static public int Div(int a, int b)
        {
            return a / b;
        }

        // 실수형 나누기
        // 오버로드 ( overload )
        static public float Div(float a, float b)
        {
            return a / b;
        }

        // 곱하기
        static public int NumBy(int a, int b)
        {
            return a * b;
        }
        // 나머지
        static public int Namugi(int a, int b)
        {
            return a % b;
        }

        // 논리 연산
        //============================================================
        static public bool LogicOr(bool A, bool B)
        {
            return A | B;
        }
    }
}
