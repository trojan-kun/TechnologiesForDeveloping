using System.Diagnostics;

namespace DZ
{
    class Program
    {
        public static void Print(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-----");
        }
        public static void BubbleSort(int[] array)
        {
            Stopwatch time = new Stopwatch();
            time.Start();
            
            for (int i = 0; i < array.Length; i++)
            {
                for (int index = 0; index < array.Length - i - 1; index++)
                {
                    if (array[index] > array[index + 1])
                    {
                        (array[index + 1], array[index]) = (array[index], array[index + 1]);
                    }
                }
            }
            time.Stop();
            Console.WriteLine(time.Elapsed);
            Print(array);
        }
        public static void InsertionSort(int[] array)
        {
            Stopwatch time = new Stopwatch();
            time.Start();
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i], index = i;
                while (index > 0 && array[index - 1] > key)
                {
                    (array[index], array[index - 1]) = (array[index - 1], array[index]);
                    index--;
                }
                array[index] = key;
            }
            time.Stop();
            Console.WriteLine(time.Elapsed);
            Print(array);
        }
        public static void GnomeSort(int[] array)
        {
            Stopwatch time = new Stopwatch();
            time.Start();
            int index = 1, nextIndex = index + 1;
            while (index < array.Length)
            {
                if (array[index - 1] < array[index])
                {
                    index = nextIndex;
                    nextIndex++;
                }
                else
                {
                    (array[index - 1], array[index]) = (array[index], array[index - 1]);
                    index--;
                    if (index == 0)
                    {
                        index = nextIndex;
                        nextIndex++;
                    }
                }
            }
            time.Stop();
            Console.WriteLine(time.Elapsed);
            Print(array);
        }

        public delegate void BubbleDelegate(int[] array);
        public delegate void InsertionDelegate(int[] array);
        public delegate void GnomeDelegate(int[] array);


        static void Main()
        {
            Random random = new Random();
            int n = random.Next(10, 20);
            int[] array = new int[n];
            Console.Write("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 20);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-----");

            int sortview = 0;
            bool t = true;
            while (t)
            {
                while (sortview > 4 | sortview < 1)
                {
                    Console.WriteLine("Виды сортировки");
                    Console.WriteLine("1. Сортировка пузырьком");
                    Console.WriteLine("2. Сортировка вставками");
                    Console.WriteLine("3. Гномья сортировка");
                    Console.WriteLine("4. Выход");
                    sortview = Convert.ToInt32(Console.ReadLine());
                    if (sortview > 4 | sortview < 1)
                    {
                        Console.WriteLine("Ошибка");
                    }
                }

                int[] arraysort = new int[n];
                array.CopyTo(arraysort, 0);
                if (sortview == 1)
                {
                    BubbleDelegate bubbleDelegate = new(BubbleSort);
                    bubbleDelegate(arraysort);
                }
                if (sortview == 2)
                {
                    InsertionDelegate insertionDelegate = new(InsertionSort);
                    insertionDelegate(arraysort);
                }
                if (sortview == 3)
                {
                    GnomeDelegate gnomeDelegate = new(GnomeSort);
                    gnomeDelegate(arraysort);
                }
                if (sortview == 4) t = false;
                sortview = 0;
            }
        }
    }
}

// Создать несколько экземпляров делегатов, на разные виды сортировки.
// Создать случайный массив достаточной длины.Показать, что пользователь
// может выбрать тот или иной вариант сортировки в командной строке и
// получить результат сортировки.При сортировке подсчитывать время
// затраченное на сортировку