namespace DZ
{
    class Program
    {
        static void Main()
        {           
            Random rnd = new Random();
            int n = rnd.Next(10, 20);
            int[] Mass = new int[n];
            Console.Write("Вывод всех элементов массива: ");
            for (int i = 0; i < n; i++)
            {
                Mass[i] = rnd.Next(-1, 5);
                Console.Write(Mass[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Вывод всех элементов массива в обратном порядке: ");
            for (int i = n-1; i >= 0; i--)
            {
                Console.Write(Mass[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Вывод чётных элементов массива: ");
            for (int i = 0; i < n; i++)
            {
                if(Mass[i] % 2 == 0 && Mass[i]!=0)
                {
                    Console.Write(Mass[i] + " ");
                }
            }
            Console.WriteLine();
            Console.Write("Вывод всех элементов массива через 1: ");
            for (int i = 0; i < n; i=i+2)
            {
                Console.Write(Mass[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Вывод всех элементов массива пока не встретится элемент -1: ");
            for (int i = 0; i < n; i++)
            { 
                if (Mass[i] != -1)
                {
                    Console.Write(Mass[i] + " ");
                }
                else
                {
                    break;
                }
            }
        }
    }
}