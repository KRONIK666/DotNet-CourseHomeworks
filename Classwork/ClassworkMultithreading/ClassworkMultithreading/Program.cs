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
            Thread one = new Thread(new ThreadStart(new Threads().Job));
            Thread two = new Thread(new ThreadStart(new Threads().Job));
            Thread three = new Thread(new ThreadStart(new Threads().Job));
        }
    }
}