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
                //���菈���������ɏ����Ă�������
                //�o�͂�Console.WriteLine(i);��Console.WriteLine("hoge");�ȂǂƏ���
                Console.WriteLine(i % 15 == 0 ? "hogepiyo" : i % 3 == 0 ? "hoge" : i % 5 == 0 ? "piyo" : i.ToString());
            }
        }
    }
}
