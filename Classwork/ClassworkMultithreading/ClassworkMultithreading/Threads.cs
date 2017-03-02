using System;
using System.Threading;

namespace ClassworkMultithreading
{
    class Threads
    {
        private string name;
        private int sleep;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Sleep
        {
            get { return sleep; }
            set { sleep = value; }
        }

        public Threads(string name, Random seconds)
        {
            this.name = name;
            this.sleep = seconds.Next(100, 600);
        }

        public void ThreadsInfo()
        {
            Console.WriteLine("Thread {0} started!", name);
            Thread.Sleep(sleep);
            Console.WriteLine("Thread {0} sleep time: {1} miliseconds", name, sleep);
        }
    }
}