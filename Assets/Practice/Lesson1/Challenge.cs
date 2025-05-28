using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson1
{
    class Challenge
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; ++i)
            {
                //”»’èˆ—‚ð‚±‚±‚É‘‚¢‚Ä‚­‚¾‚³‚¢
                //o—Í‚ÍConsole.WriteLine(i);‚âConsole.WriteLine("hoge");‚È‚Ç‚Æ‘‚­
                Console.WriteLine(i % 15 == 0 ? "hogepiyo" : i % 3 == 0 ? "hoge" : i % 5 == 0 ? "piyo" : i.ToString());
            }
        }
    }
}
