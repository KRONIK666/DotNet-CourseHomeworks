using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassworkMultithreading
{
    class Threads
    {
        public void Job()
        {
            Console.WriteLine("Thread {0} started!", Thread.CurrentThread.Name);
            Console.WriteLine("Thread {0} sleep time: {1}", Thread.CurrentThread.Name);
        }
    }
}