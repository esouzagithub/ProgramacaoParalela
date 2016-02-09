using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgramacaoParalelaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            while (true)
            {

                //for (var i = 0; i < 100000; i++)
                //{
                //    Method(100000);
                //}
                //Console.WriteLine("Time For:{0}",time.ElapsedMilliseconds);

                //Parallel.For
                //time = Stopwatch.StartNew();
                //Parallel.For(0, 1000000, i =>
                //{
                //    Method(1000000);
                //});
                //Console.WriteLine("Time Parallel.For:{0}", time.ElapsedMilliseconds);
                //Console.ReadKey();

                //stopwatch.Start();
                stopwatch = Stopwatch.StartNew();
                for (var i = 0; i < 5000; i++)
                {
                    MethodString();
                }
                stopwatch.Stop();
                Console.WriteLine("Time For:{0}", stopwatch.ElapsedMilliseconds);
                //Console.ReadKey();

                //Thread
                var thread = new Thread(MethodString);
                stopwatch = Stopwatch.StartNew();
                thread.Start();
                stopwatch.Stop();
                Console.WriteLine("Time Thread:{0}", stopwatch.ElapsedMilliseconds);


                // Parallel.For
                stopwatch = Stopwatch.StartNew();
                Parallel.For(0, 5000, i => MethodString());
                stopwatch.Stop();
                Console.WriteLine("Time Parallel.For:{0}", stopwatch.ElapsedMilliseconds);
                Console.ReadKey();
            }
        }


        static void Method(int x)
        {
            var y = 1;
            for (var i = 0; i < x; i++)
            {
                y += y * i;
            }
        }

        static void MethodString()
        {
            var y = "";
            for (var i = 0; i < 5000; i++)
            {
                y += "x";
            }
        }
    }
}
