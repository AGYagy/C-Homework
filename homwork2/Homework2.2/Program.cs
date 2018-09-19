using System;

namespace Homework2._2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int max = arr[0];
            int min = arr[0];
            double avg = 0;
            double sum = 0;
            for(int i = 0; i < 10; i++)
            {
                if (max < arr[i])
                    max = arr[i];
                if (min > arr[i])
                    min++;
                avg += arr[i];
                sum += arr[i];
            }
            Console.WriteLine("最大值:{0}", max);
            Console.WriteLine("最小值:{0}", min);
            Console.WriteLine("平均值:{0}", avg);
            Console.WriteLine("元素和:{0}", sum);
        }
    }
}
