using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread thread1 = new Thread(new ThreadStart(ThreadMethod));
        Thread thread2 = new Thread(new ThreadStart(ThreadMethod));
        Thread thread3 = new Thread(new ThreadStart(ThreadMethod));

        thread1.Start();
        thread2.Start();
        thread3.Start();
        thread1.Join();
        thread2.Join();
        thread3.Join();

        Console.WriteLine("threads have completed");
    }

    static void ThreadMethod()
    {
        for (int i = 1; i < 3; i++)
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is working. Iteration {i}");
            Thread.Sleep(1000); 
        }
    }
}
