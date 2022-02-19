using System;
using System.Collections.Generic;

namespace UnityLesson_CSharp_ClassInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Creature creature = new Creature();
            
            for (int i = 0; i < 10; i++)
            {
                creature.Breath();
            }
            Console.WriteLine("creature.age : "+creature.age);

            Human human = new Human();

            for (int i = 0;i < 10; i++)
            {
                human.Breath();
            }
            Console.WriteLine("human.age : " + human.age + ", human.height : " + human.height + ", human.weight : " + human.weight);

            WhiteMan whiteMan = new WhiteMan();
            BlackMan blackMan = new BlackMan();
            YellowMan yellowMan = new YellowMan();

            for (int i = 0; i < 10; i++)
            {
                whiteMan.Breath();
                blackMan.Breath();
                yellowMan.Breath();
            }
            Console.WriteLine("whiteMan.age : " + whiteMan.age + ", whiteMan.height : " + whiteMan.height + ", whiteMan.weight : " + whiteMan.weight); 
            Console.WriteLine("blackMan.age : " + blackMan.age + ", blackMan.height : " + blackMan.height + ", blackMan.weight : " + blackMan.weight);
            Console.WriteLine("yellowMan.age : " + yellowMan.age + ", yellowMan.height : " + yellowMan.height + ", yellowMan.weight : " + yellowMan.weight);

            Dog dog = new Dog();
            dog.tailLength = 1f;

            // 각 인종 20명, 두발로 걷기
            // --------------------------------------------------------
            // case : 각 인종에 대한 리스트 별개로 생성하기
            Console.WriteLine("-----------------------------");

            List<WhiteMan> arr_WhiteMan = new List<WhiteMan>();
            List<BlackMan> arr_BlackMan = new List<BlackMan>();
            List<YellowMan> arr_YellowMan = new List<YellowMan>();
            for (int i = 0; i < 20; i++)
            {
                WhiteMan tmpMan = new WhiteMan();
                arr_WhiteMan.Add(tmpMan);
            }
            for (int i = 0; i < 20; i++)
            {
                BlackMan tmpMan = new BlackMan();
                arr_BlackMan.Add(tmpMan);
            }
            for (int i = 0; i < 20; i++)
            {
                YellowMan tmpMan = new YellowMan();
                arr_YellowMan.Add(tmpMan);
            }

            foreach (var item in arr_WhiteMan)
            {
                item.TwoLeggedWalk();
            }
            foreach (var item in arr_BlackMan)
            {
                item.TwoLeggedWalk();
            }
            foreach (var item in arr_YellowMan)
            {
                item.TwoLeggedWalk();
            }

            // WhiteMan 객체화 -> Human 으로 인스턴스화
            // Human변수에 있는 Breath를 호출하면 WhiteMan에 있는 Breath가 호출됨
            //
            // 자식 객체를 부모 클래스 타입으로 인스턴스화 시키고
            // 해당 변수의 virtual 멤버 함수를 호출하면
            // 자식 객체의 override된 함수가 호출된다.
            Human testHuman = new WhiteMan();
            testHuman.Breath();
            Console.WriteLine($"{testHuman.height}, {testHuman.weight}");

            // case : 위 성질을 이용하여 부모 클래스(Human) 리스트 하나만 생성
            List<Human> arr_Human = new List<Human>();
            for (int i = 0; i < 20; i++)
            {
                Human tmpHuman1 = new WhiteMan();
                arr_Human.Add(tmpHuman1);
                Human tmpHuman2 = new BlackMan();
                arr_Human.Add(tmpHuman2);
                Human tmpHuman3 = new YellowMan();
                arr_Human.Add(tmpHuman3);
            }
            foreach(var item in arr_Human)
            {
                item.TwoLeggedWalk();
            }

            // 인터페이스 인스턴스화 예시
            ITwoLeggedWalker iTwoLeggedWalker = new WhiteMan();
            iTwoLeggedWalker.TwoLeggedWalk();
            // case : 인터페이스로 인스턴스화 시키는 방법
            List<ITwoLeggedWalker> walkers = new List<ITwoLeggedWalker>();
            for(int i = 0; i < 20; i++)
            {
                ITwoLeggedWalker tmpWalker1 = new WhiteMan();
                walkers.Add(tmpWalker1);
                ITwoLeggedWalker tmpWalker2 = new BlackMan();
                walkers.Add(tmpWalker2);
                ITwoLeggedWalker tmpWalker3 = new YellowMan();
                walkers.Add(tmpWalker3);
            }
            foreach(var item in walkers)
            {
                item.TwoLeggedWalk();
            }
        }
    }
}
