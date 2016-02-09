using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgramacaoTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Inicio Task");
            //Task task = Task.Run(new Action(Method));
            //Console.WriteLine("Fim Task");
            // use an Action delegate and named method


            //Task task1 = new Task(new Action(printMessage));
            //// use an anonymous delegate
            //Task task2 = new Task(delegate { printMessage(); });
            //// use a lambda expression and a named method
            //Task task3 = new Task(() => printMessage());
            //// use a lambda expression and an anonymous method
            //Task task4 = new Task(() => { printMessage(); });

            //task1.Start();
            //task2.Start();
            //task3.Start();
            //task4.Start();
            //Console.WriteLine("Main method complete. Press <enter> to finish.");
            //Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Inicio task!");
                Task task1 = Task.Factory.StartNew(new Action(printMessage));
                //task1.Start();
                //task1.Wait();
                Console.WriteLine("Final 1 task!");
                Console.ReadKey();
            }

            
        }

        private static void printMessage()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello, world!");
                Thread.Sleep(600);
            }
            
        }

        static void Method()
        {
            Console.WriteLine("Task 1...");
            Console.WriteLine("Task 2...");
            Console.WriteLine("Task 3...");
        }
    }
}
