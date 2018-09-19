using System;

namespace Homework2._3
{
    public class FindPrime
    {
        public static void Main(string[] args)
        {
            int[] a = new int[99];
            for (int i1 = 0; i1 < 99; i1++)
            {
                a[i1] = i1 + 2;
            }

            for (int i = 2; i <= 100; i++)
            {
                for (int j = 0; j < 99; j++)
                {
                    if (a[j] != 0)
                    {
                        if (a[j] % i == 0 && a[j] / i != 1)
                        { a[j] = 0; }
                    }
                }
            }

            Console.WriteLine("输出2——100之间的所有素数");
            int cout = 0;
            for (int ii = 0; ii < 99; ii++)
            {
                if (a[ii] != 0)
                {
                    Console.WriteLine(a[ii] + " ");
                    cout++;
                    if (cout % 10 == 0)
                    { Console.WriteLine(); }
                }
            }
        }
    }
}
