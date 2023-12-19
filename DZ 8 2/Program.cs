namespace dz82
{
    class array
    {
        public void massivegeneration()
        {
            int[] arr = new int[10];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-10, 10);
                Console.WriteLine("Элемент " + (i+1) + " = " + arr[i]);
            }
            GenericsMethod<int[]>.arr = arr;
        }
    }

    class GenericsMethod<P> 
    {
        public static int[]? arr;
        public void Swapgeneration()
        {
            Console.WriteLine("Введите первый номер элемента, которые хотите переставить");
            string i1, i2;           
            i1 = Console.ReadLine();
            Console.WriteLine("Введите второй номер элемента, которые хотите переставить");
            i2 = Console.ReadLine();
            Swap<string>(ref i1, ref i2);
        }

        public void Swap<T>(ref string i1, ref string i2)
        {
            int I1 = (int)Convert.ToInt32(i1);
            I1--;
            int I2 = (int)Convert.ToInt32(i2);
            I2--;
            (arr[I2], arr[I1]) = (arr[I1], arr[I2]);
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine("Элемент " + (i+1) + " = " + arr[i]);
        }

        public void MaxValue<T>()
        {
            int maxValue = arr.Max();
            Console.WriteLine("\nМаксимальное значение массива = " + maxValue + "\n");
        }

        public void MinValue<T>()
        {
            int minValue = arr.Min();
            Console.WriteLine("Минимальное значение массива = " + minValue + "\n");
        }

        public void Summ<T>(ref int summ)
        {
            for (int i = 0; i < arr.Length; i++)
                summ = summ + arr[i];
            Console.WriteLine("Сумма всех элементов массива = " + summ + "\n");
        }

        public void BubbleSort<T>()
        {
            int swapper;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        swapper = arr[i];
                        arr[i] = arr[j];
                        arr[j] = swapper;
                    }
                }
            }
            Console.WriteLine("Отсортированный пузырьком массив:");
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine("Элемент " + (i+1) + " = " + arr[i]);
        }
    }

    class Vision
    {
        static void Main()
        {
            array array = new array();
            array.massivegeneration();
            GenericsMethod<int[]> generics = new GenericsMethod<int[]>();
            generics.Swapgeneration();
            generics.MaxValue<int>();
            generics.MinValue<int>();
            int summ = 0;
            generics.Summ<int>(ref summ);
            generics.BubbleSort<int[]>();
        }
    }
}

