using System;

namespace DZ
{

    public delegate void SortDelegate(NumberArray[] numbers);

    public class NumberArray
    {
        public int numbers;
        public int Numbers
        {
            get { return numbers; }
        }
        public NumberArray(int numbers)
        {
            this.numbers = numbers;
        }

        public bool MoreComparison(int numbers, int numbers1)
        {
            if (numbers > numbers1) { return true; }
            return false;
        }

        public int[] CopyArray(NumberArray[] numbers, int N)
        {
            int[] copynumbers = new int[N];
            numbers.CopyTo(copynumbers, 0);
            return copynumbers;
        }

        public void Sort()
        {

        }
    }

    public class Sorting
    {
        public static void Print(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("-----");
        }
        public static void BubbleSort(NumberArray[] numbers)
        {
            int[] numberint = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numberint[i] = Convert.ToInt32(numbers[i]);
            }
            for (int i = 0; i < numberint.Length; i++)
            {
                for (int index = 0; index < numberint.Length - i - 1; index++)
                {
                    if (numberint[index] > numberint[index + 1])
                    {
                        (numberint[index + 1], numberint[index]) = (numberint[index], numberint[index + 1]);
                    }
                }
            }
            Print(numberint);
        }

        public static void InsertionSort(NumberArray[] numbers)
        {
            int[] numberint = new int[10];
            for (int i = 0; i < numberint.Length; i++)
            {
                numberint[i] = Convert.ToInt32(numberint[i]);
            }
            for (int i = 1; i < numberint.Length; i++)
            {
                int key = numberint[i], index = i;
                while (index > 0 && numberint[index - 1] > key)
                {
                    (numberint[index], numberint[index - 1]) = (numberint[index - 1], numberint[index]);
                    index--;
                }
                numberint[index] = key;
            }
            Print(numberint);
        }

    }

    public class Program : Sorting
    {
        const int N = 10;
        static void Main()
        {
            Random random = new Random();
            NumberArray[] number = new NumberArray[N];
            for (int i = 0; i < number.Length; i++)
            {
                int rnd = random.Next(-5,N);
                number[i] = new NumberArray(rnd);
            }

            SortDelegate sort = new(BubbleSort);
            sort += InsertionSort;
            sort(number);
        }
    }
}

//1) Реализовать несколько методов сортировки с одинаковой сигнатурой: void 
//Sort(Numbernumbers numbers)
//2) Создать делегат SortDelegate, который будет совпадать по сигнатуре с 
//сигнатурой методов сортировки
//3) Реализовать класс "массив чисел" Numbernumbers. В классе массиве 
//предусмотреть, метод сортировки,в который передается делегат сортировки, 
//а также основные методы манипуляции содержимым,в частности получение и 
//сохранение значения элементов массива через индексатор, 
//а также создание копии массива