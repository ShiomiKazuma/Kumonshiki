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
                //���菈���������ɏ����Ă�������
                //�o�͂�Console.WriteLine(i);��Console.WriteLine("hoge");�ȂǂƏ���
                if(i % 15 == 0) //3�ł�5�ł�����؂��ꍇ
                {
                    Console.WriteLine("hogepiyo");
                }
                else if(i % 3 == 0) //3�Ŋ���؂��ꍇ
                {
                    Console.WriteLine("hoge");
                }
                else if(i % 5 == 0) //5�Ŋ���؂��ꍇ
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
