namespace DZ_13_5
{
    class Threads
    {
        
        public void Create()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread Thread = new Thread(Sum);
                Thread.Start();
            }
        }
        void Sum()
        {
            
        }

    }
    class Programm
    {

        static void Main()
        {
            int sum = 0;
            for (int i = 1; i <= 1000000; i++)
            {
                sum+=i;
                
            }
            Console.WriteLine(sum);
        }
    }
    //1783293664
}