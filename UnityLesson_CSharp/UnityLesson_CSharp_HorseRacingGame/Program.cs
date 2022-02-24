using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace UnityLesson_CSharp_HorseRacingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool racingIsFinished = true;

            string[] rankName = new string[5];
            int[] rankScore = new int[5];

            List<Horse> arr_Horse = new List<Horse>();

            int[] rankings = Enumerable.Repeat(1, 5).ToArray();

            for (int i = 0; i < 5; i++)
            {
                arr_Horse.Add(new Horse());
                arr_Horse[i].setHorseStats($"horse{i}", 0, 0);
            }

            Random random = new Random();

            while (racingIsFinished)
            {
                Thread.Sleep(1000);

                for (int i = 0; i < 5; i++)
                {
                    int randomInt = random.Next(10, 21);
                    arr_Horse[i].horseStats.horseSpeed = randomInt;
                    arr_Horse[i].run();

                    Console.WriteLine($"{arr_Horse[i].horseStats.name} : {arr_Horse[i].horseStats.runLength}");
                }

                Console.WriteLine("=====================================================");

                for (int i = 0; i < 5; i++)
                {
                    if (arr_Horse[i].horseStats.runLength >= 200)
                    {
                        racingIsFinished = false;
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                rankings[i] = 1; //1등으로 초기화, 순위 배열을 매 회전마다 1등으로 초기화
                for (int j = 0; j < 5; j++)
                {
                    if (arr_Horse[i].horseStats.runLength < arr_Horse[j].horseStats.runLength) //현재(i)와 나머지(j) 비교
                    {
                        rankings[i]++;         //RANK: 나보다 큰 점수가 나오면 순위 1증가
                    }
                }
            }

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{rankings[i]}등 -> {arr_Horse[i].horseStats.name} : {arr_Horse[i].horseStats.runLength}");
            }


            /*
            if (rankName[i] != arr_Horse[i].horseStats.name)
            {
                rankScore[i] = arr_Horse[i].horseStats.runLength;
                rankName[i] = arr_Horse[i].horseStats.name;
            }
            */


        }
    }
}
