﻿using System;
using System.Threading;

namespace Task2
{
    class Program
    {
        public static void ThreadsInfo(object name)
        {
            Random seconds = new Random();

            Console.WriteLine("The thread is started!");
            Console.WriteLine("This is thread {0}!", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(seconds.Next(1000, 10000));
            Console.WriteLine("The thread {0} is complete!", Thread.CurrentThread.ManagedThreadId);
        }

        static void Main()
        {
            Console.WriteLine("Press [Enter] to exit!");
            Console.WriteLine("Program has started using thread: " + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine();

            for (int i = 1; i <= 5; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadsInfo));
            } Console.ReadLine();
        }
    }
}