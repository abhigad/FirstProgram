using System;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace FirstProgram
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.WriteLine("No of thread running in Async code {0}", Process.GetCurrentProcess().Threads.Count);
            Console.WriteLine("Process memory {0}",Process.GetCurrentProcess().WorkingSet.ToString());
            //SyncCall();
            Console.WriteLine("====================");
            AsyncCall(); //creating 6 more threads
            Console.WriteLine("No of thread running in Async code {0}", Process.GetCurrentProcess().Threads.Count);
            Console.WriteLine("Process memory {0}", Process.GetCurrentProcess().WorkingSet.ToString());
            Console.ReadLine();
            }

        private static void AsyncCall()
            {
            Console.WriteLine("Start Async");
            Task.Run(()=>Pause());
            //Console.WriteLine("No of thread running in Async code {0}", Process.GetCurrentProcess().Threads.Count);
            for (int i=0;i<100000000;i++)
                {
                if(i>99999998)
                    {
                    Console.WriteLine(i);
                    }
                }
            Console.WriteLine("End Async");
            }

        private static void SyncCall()
            {
            Console.WriteLine("Start Sync");
            Pause();
            //Console.WriteLine("No of thread running in Sync Code {0}", Process.GetCurrentProcess().Threads.Count);
            for (int i = 0; i < 100000000; i++)
                {
                if (i > 99999998)
                    {
                    Console.WriteLine(i);
                    }
                }
            Console.WriteLine("End Sync");
            }

        static void Pause()
            {
            Thread.Sleep(400);
            Console.WriteLine("Done");
            }
        }
    }
