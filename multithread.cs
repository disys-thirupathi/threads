using System;
using System.Threading;
namespace multithread
{
    public class multithread
    {
        public static void thread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("#1 : " + i);
                if (i == 5)
                {
                    Console.WriteLine("Sleeping for 5 seconds");
                    Thread.Sleep(5000);
                }
            }
        }
        public static void thread2()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("2#  " + i);
            }
        }
    }
    public class program
    {
        static void Main(string[] args)
        {

            Thread t1 = new Thread(multithread.thread1);
            Thread t2 = new Thread(multithread.thread2);
            t1.Start();
            t2.Start();
            Console.ReadLine();

        }

    }
}