using System;
using System.Threading;

namespace Home_work
{
    internal class Program
    {
        static void Print_numbers()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            // Задание 1
            // Программа создает 3 потока и каждый поток выводит 10 чисел
            Console.WriteLine();
            Thread myThread1 = new Thread(Print_numbers);
            Thread myThread2 = new Thread(Print_numbers);
            Thread myThread3 = new Thread(Print_numbers);
            myThread1.Start();
            myThread2.Start();
            myThread3.Start();
            myThread1.Join();
            myThread2.Join();
            myThread3.Join();
        }

        public async static long Calculate_factorial(long number)
        {
            Thread.Sleep(8000);
            int result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        public static int Calculate_the_square_of_a_numberl(int n)
        {
            return n * n;
        }
    }
}