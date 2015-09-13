using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassworkMultithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Random seconds = new Random();

            Thread one = new Thread(new Threads("ONE", seconds).ThreadsInfo);
            Thread two = new Thread(new Threads("TWO", seconds).ThreadsInfo);
            Thread three = new Thread(new Threads("THREE", seconds).ThreadsInfo);

            one.Start();
            two.Start();
            three.Start();
        }
    }
}