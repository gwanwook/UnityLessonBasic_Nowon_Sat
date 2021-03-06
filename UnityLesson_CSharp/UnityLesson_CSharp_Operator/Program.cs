using System;

namespace UnityLesson_CSharp_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 14;
            int b = 5;
            int c = 0;
            // 산술 연산
            // 더하기, 빼기, 나누기(몫 반환), 곱하기, 나머지(몫 제외 나머지 반환)
            //===================================================================
            // 더하기
            c = OperatorMothods.Sum(a, b);
            // 빼기
            c = OperatorMothods.Minus(a, b);
            // 나누기
            c = OperatorMothods.Nanoogi(a, b);
            // 곱하기
            c = OperatorMothods.NumBy(a, b);
            // 나머지
            c = OperatorMothods.Namugi(a, b);


            // 증감 연산
            // 증가 연산자, 감소 연산자
            //===================================================================
            // 증가 연산자
            c++; // c = c + 1;
            // 감소 연산자
            c--; // c = c - 1;

            // 관계 연산
            // 수학에서 등호와 부등호
            // 같음, 다름, 크기 비교 연산 수행
            // 관계 연산 결과가 참이면 true, 거짓이면 false 반환
            //===================================================================
            bool result;
            // 같음 비교
            result = a == b;
            Console.WriteLine(result);
            // 다름 비교
            result = a != b;
            Console.WriteLine(result);
            // 크다
            result = a > b;
            Console.WriteLine(result);
            // 크거나 같다
            result = a >= b;
            Console.WriteLine(result);
            // 작다
            result = a < b;
            Console.WriteLine(result);
            // 작거나 같다
            result = a <= b;
            Console.WriteLine(a <= b);

            // 논리 연산(논리 자료형 연산 - bool 형끼리의 연산)
            // 양측의 피연산자들을 비교해서 연산 수행
            // or, and, xor, not
            //===================================================================
            Console.WriteLine("여기부터 논리연산");
            bool A = true;
            bool B = false;
            // or
            // a 와 b 둘중 하나라도 true이면 true반환, 나머지경우 false반환
            result = A | B;
            Console.WriteLine(result);
            // and
            // a 와 b 둘중 true이면 true반환, 나머지경우 false반환
            result = A & B;
            Console.WriteLine(result);
            // xor
            // a 와 b 둘중 하나만 true일 때 true반환, 나머지경우 false반환
            result = A ^ B;
            Console.WriteLine(result);
            // not
            // a의 반대 부호 반환(true이면 false, false면 true반환)
            result = !A;
            Console.WriteLine(result);

            // 조건부 논리연산
            // 왼쪽 피연산자 조건에 따라서 오른쪽 피연산자와 비교할지 말지 평가 후에 연산한다.
            //===================================================================
            // conditional or
            // 만약 A가 true이면 B의 값에 관계없이 결과값이 true이므로
            // 연산을 수행하지 않고 A를 반환함.
            result = A || B;
            // conditional and
            // 만약 A가 false면 B의 값에 관계없이 결과값이 false이므로
            // 연산을 수행하지 않고 A를 반환함.
            result = A && B;

            // 비트 연산
            // 비트 연산을 하는 이유 : 데이터를 효율적으로 관리하기 위함
            // or, and, xor, not, shift-left, shift-right
            //===================================================================
            int howManyBitsYouWantToShift = 3;
            // or
            c = a | b;
            Console.WriteLine(c);
            // and
            c = a & b;
            Console.WriteLine(c);
            // xor
            c = a ^ b;
            Console.WriteLine(c);
            // not
            c = ~a;
            Console.WriteLine(c);
            // shift-left
            c = a << howManyBitsYouWantToShift;
            Console.WriteLine(c);
            // shift-right
            c = a >> howManyBitsYouWantToShift;
            Console.WriteLine(c);
        }
    }
    // FSM (Finite State Machine) 유한상태머신
    // 클래스의 상태에 따라서 다른 동작을 하기위해 사용
    // ex_플레이어가 IDLE 일 때 귀환 누르면 귀환 시작
    // 피격상태/공격상태일 때는 귀환 누르면 귀환 안되게 하는 조건을
    // 아래 플레이어 상태에 따라서 나눈다.
    [Flags]
    public enum e_FSM
    {
        IDLE = 0,
        피격당한상태 = 1 << 0,
        공격중인상태 = 1 << 1,
        STATE_3 = 1 << 2,
        STATE_4 = 1 << 3,
    }
}
