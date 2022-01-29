using System;

namespace UnityLesson_CSharp_InstantiationExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Orc orc1 = new Orc();
            orc1.name = "상급오크";
            orc1.height = 240.2f;
            orc1.width = 200;
            orc1.age = 140;
            orc1.gender = '남';
            orc1.isResting = false;

            Orc orc2 = new Orc();
            orc2.name = "하급오크";
            orc2.height = 140.4f;
            orc2.width = 120;
            orc2.age = 60;
            orc2.gender = '여';
            orc2.isResting = true;

            if (orc1.isResting)
            {
                orc1.Jump();
                orc1.Smash();
            }
            else
            {
                Console.WriteLine($"{orc1.name}(이)가 바쁘다.");
            }

            if (orc2.isResting)
            {
                orc2.Jump();
                orc2.Smash();
            }
            else
            {
                Console.WriteLine($"{orc2.name}(이)가 바쁘다.");
            }
        }
    }

    public class Orc
    {
        public string name;
        public float height;
        public float width;
        public int age;
        public char gender;
        public bool isResting;

        public void Jump()
        {
            Console.WriteLine($"{name}(이)가 점프했다.");
        }

        public void Smash()
        {
            Console.WriteLine($"{name}(이)가 휘둘렀다.");
        }
    }
}
