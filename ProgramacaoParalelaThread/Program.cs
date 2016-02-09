using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgramacaoParalelaThread
{

    public class MyThread
    {

        public void Thread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread1 {0}", i);
            }
        }

        public void Thread2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread2 {0}", i);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var t1 = new Thread(myFun);
            //t1.Start();
            //Console.WriteLine("Main thread Running");
            //Console.ReadKey();

            //var t2 = new Thread(myFun2);
            //t2.Name = "Thread1";
            //t2.IsBackground = false;
            //t2.Start();
            //Console.WriteLine("Main thread Running");
            //Console.ReadKey();

            //MyThread th =new MyThread();
            //Console.WriteLine("Before start thread");
            //Thread tid1 = new Thread(th.Thread1);
            //Thread tid2 = new Thread(th.Thread2);
            //tid1.Start();
            //tid2.Start();

            Thread th = new Thread(WriteY);
            //th.Priority = ThreadPriority.;
            th.Start();            
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Hello");
            }

            Console.ReadKey();
        }

        private static void WriteY()
        {
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("world");
            }
        }

        static void myFun()
        {
            Console.WriteLine("Running other Thread");
        }

        static void myFun2()
        {
            Console.WriteLine("Thread {0} started", Thread.CurrentThread.Name);
            Thread.Sleep(2000);
            Console.WriteLine("Thread {0} completed", Thread.CurrentThread.Name);
        }
    }
}
