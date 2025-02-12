using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System_311.Threading
{
    internal class ThreadingDemo
    {
        private int nThreads;
        public void Run()
        {
            Console.WriteLine("Homework");
            int N = 10;

            Thread[] threads = new Thread[N];
            nThreads = N;
            for (int i = 0; i < N; i++)
            {
                threads[i] =                   
                    new Thread(CalcOneMonth);
                threads[i]                     
                    .Start(i + 1);             
            }
           
        }

        public string? rthred;
        private object strLocker = new();
        private void CalcOneMonth(object? thread)
        {

            int m = (int)(thread ?? -1);
            Thread.Sleep(300);        
            string? strLocal;
            string rthredLocal;
            string? c;
            lock (strLocker)
            {
                if (m == 10)
                {
                    m = 0;
                    c = "0";
                }
                else
                {
                    c = Convert.ToString(m);
                }
                strLocal = rthred += c;
            }
            Console.WriteLine("Thread {1}:  {0:F1}", strLocal, m);

            lock (this)   
            {
                nThreads--;
                if (nThreads == 0)
                {
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Total: {0:F2}", strLocal);
                }
            }
        }
    }
}
