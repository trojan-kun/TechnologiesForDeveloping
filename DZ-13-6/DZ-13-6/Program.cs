using System;
using System.Threading;


namespace threading
{
    class Threads
    {
        public delegate void Msg_written();
        public event Msg_written? Msg;
        string msg;
        public bool check_if_msg = true;

        public void create_thread()
        {
            Thread thread1 = new Thread(printer_thread);
            Thread thread2 = new Thread(printer_thread);
            thread1.Name = "1st Thread";
            thread1.Start();
            thread2.Name = "2nd Thread";
            thread2.Start();
        }

        void printer_thread()
        {
            while (true)
            {
                if (check_if_msg == false)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " is stopped");
                    break;
                }
                Console.WriteLine(Thread.CurrentThread.Name + " is active ");
                Thread.Sleep(5000);
            }

        }

        public void message_resieved()
        {
            if (check_if_msg != false) { msg = Console.ReadLine(); }
            if (msg == "End")
            {
                Msg?.Invoke();
            }
        }

        public void stop_threads()
        {
            Console.WriteLine("threads stopping");
            var Rand = new Random();
            int rnd = Rand.Next(1000, 10000);
            Thread.Sleep(Convert.ToInt32(rnd));
            check_if_msg = false;
        }
    }

    class programm
    {
        static void Main()
        {
            Threads thread = new Threads();
            thread.Msg += thread.stop_threads;
            thread.create_thread();
            while (thread.check_if_msg == true)
            {
                thread.message_resieved();
            }
        }
    }
}
