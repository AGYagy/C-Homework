using System;

namespace Homework2._1
{
     public class FindPrimeGene
    {
        public static void Main(string[] args)
        {
            string a = "";
            int param = 0;
            Console.Write("Please input a int :");
            a = Console.ReadLine();
            param = Int32.Parse(a); 
            int pa_sqrt = (int)param / 2;
            int[] result = new int[pa_sqrt];
            int[] prime_num = new int[pa_sqrt];
            Boolean isPrime = true;
            int r_p = 0, p_p = 0;

            prime_num[p_p++] = 2;
            if (param % 2 == 0)
                result[r_p++] = 2;

                for(int i = 3; i <= pa_sqrt; i++)
            {
                for(int j = 0; j < p_p; j++)
                {
                    if (i % prime_num[j] != 0)
                    {
                        isPrime = true;
                        continue;
                    }
                    else
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    prime_num[p_p++] = i;
                    if (param % i == 0)
                        result[r_p++] = i;
                }
            }
            Console.WriteLine("The prime numbers of " + param + " are");
            for (int i = 0; i < r_p; i++)
                Console.WriteLine("" + result[i]);
            Console.WriteLine();
                Console.WriteLine("The prime array is");
            for (int i = 0; i < p_p; i++)
                Console.WriteLine("" + prime_num[i]);
            Console.WriteLine();
        }
    }
}
