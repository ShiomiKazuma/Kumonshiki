using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; ++i)
            {
                //”»’èˆ—‚ð‚±‚±‚É‘‚¢‚Ä‚­‚¾‚³‚¢
                //o—Í‚ÍConsole.WriteLine(i);‚âConsole.WriteLine("hoge");‚È‚Ç‚Æ‘‚­
                if(i % 15 == 0) //3‚Å‚à5‚Å‚àŠ„‚èØ‚ê‚éê‡
                {
                    Console.WriteLine("hogepiyo");
                }
                else if(i % 3 == 0) //3‚ÅŠ„‚èØ‚ê‚éê‡
                {
                    Console.WriteLine("hoge");
                }
                else if(i % 5 == 0) //5‚ÅŠ„‚èØ‚ê‚éê‡
                {
                    Console.WriteLine("piyo");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
