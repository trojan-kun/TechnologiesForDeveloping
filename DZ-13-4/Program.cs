namespace DZ_13_4
{
    class Threads
    {
        Mutex mutex = new();
        public void Create()
        {        
            Thread Thread1 = new Thread(Print);
            Thread1.Name = "1  ";
            Thread Thread2 = new Thread(Print);
            Thread2.Name = " 2 ";
            Thread Thread3 = new Thread(Print);
            Thread3.Name = "  3";

            Thread1.Start();           
            Thread2.Start();          
            Thread3.Start();
            
        }
        void Print()
        {
            while(true) 
            {

                mutex.WaitOne();
            
                Console.WriteLine(Thread.CurrentThread.Name);
               

                mutex.ReleaseMutex();
                Thread.Sleep((int)new Random().NextInt64(1, 100));
            }

        }
        
    }
    class Programm
    {
       
        static void Main()
        {
            Threads threads = new Threads();
            threads.Create();
        }
    }
}