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
                //判定処理をここに書いてください
                //出力はConsole.WriteLine(i);やConsole.WriteLine("hoge");などと書く
                if(i % 15 == 0) //3でも5でも割り切れる場合
                {
                    Console.WriteLine("hogepiyo");
                }
                else if(i % 3 == 0) //3で割り切れる場合
                {
                    Console.WriteLine("hoge");
                }
                else if(i % 5 == 0) //5で割り切れる場合
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
