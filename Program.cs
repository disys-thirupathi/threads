using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace threads
{
    public class Threadmethods
    {
        public void methods()
        {
           for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void method1()
        {
            Console.WriteLine("2nd thread");
            int i = 9;
            while (i >= 0)
            {
                Console.WriteLine(i);
                i--;
            }
        }
    }
    internal class Program
    {
        [Obsolete]
        static void Main(string[] args)
        {
            Threadmethods tm = new Threadmethods();
            Thread th = new Thread(new ThreadStart(tm.methods));
            Thread th2 = new Thread(new ThreadStart(tm.method1));
            Console.WriteLine("Thread start method and state method " + th.ThreadState);
            th.Start();
            Console.WriteLine("Thread suspend method which suspend the object "+th.ThreadState);
            th.Suspend();
            Console.WriteLine("Resuming the suspended state "+th.ThreadState);
            th.Resume();
            Console.WriteLine("joining threads " + th.ThreadState);
            Console.WriteLine(th.ThreadState);
            th.Join();
            th2.Start();
            Console.ReadLine();

        }
    }
}
