﻿using System;
using System.Threading;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random seconds = new Random();

            Thread one = new Thread(new Threads("ONE", seconds).ThreadsInfo);
            Thread two = new Thread(new Threads("TWO", seconds).ThreadsInfo);
            Thread three = new Thread(new Threads("THREE", seconds).ThreadsInfo);
            Thread four = new Thread(new Threads("FOUR", seconds).ThreadsInfo);
            Thread five = new Thread(new Threads("FIVE", seconds).ThreadsInfo);

            one.Start();
            two.Start();
            three.Start();
            four.Start();
            five.Start();
        }
    }
}