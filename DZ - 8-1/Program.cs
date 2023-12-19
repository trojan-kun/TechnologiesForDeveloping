using System.Collections;
using System.Diagnostics;

namespace Array_vs_List
{
    public class SampleArrays
    {

        private ArrayList AL_i = new ArrayList();
        private ArrayList AL_s = new ArrayList();
        private List<int> List_Array_int = new List<int>();
        private List<string> List_Array_string = new List<string>();
        private Stopwatch stopwatch = Stopwatch.StartNew();
        private string elapsed_time = "";

        protected void TimerStart()
        {
            stopwatch = Stopwatch.StartNew();
        }

        protected string TimerStop()
        {
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            elapsed_time = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            return elapsed_time;
        }

        private void ArrayList_int()
        {
            TimerStart();
            for (int i = 0; i < 10000000; i++)
            {
                AL_i.Add(i);
            }
            Console.WriteLine("Array List добавление int: 10 миллионов операций за: " + TimerStop());
        }

        private void ArrayList_string()
        {
            TimerStart();
            for (int i = 0; i < 10000000; i++)
            {
                AL_s.Add("array list");
            }
            Console.WriteLine("Array List добавление string: 10 миллионов операций за: " + TimerStop());
        }

        private void List_string()
        {
            TimerStart();
            for (int i = 0; i < 10000000; i++)
            {
                List_Array_string.Add("string list");
            }
            Console.WriteLine("List<> добавление string: 10 миллионов операций за: " + TimerStop());
        }

        private void List_int()
        {
            TimerStart();
            for (int i = 0; i < 10000000; i++)
            {
                List_Array_int.Add(i);
            }
            Console.WriteLine("List<> добавление int: 10 миллионов операций за: " + TimerStop());
        }

        private void CheckElem<T>(ref string input_element)
        {
            Clear();
            for (int i = 0; i < 10000000; i++)
            {
                List_Array_string.Add("string list");
            }
            List_Array_string.Add("u found me");
            for (int i = 0; i < 10000000; i++)
            {
                AL_s.Add("array list");
            }
            AL_s.Add("u found me");
            TimerStart();
            int index = AL_s.IndexOf(input_element);
            string timer_AL = TimerStop();
            TimerStart();
            int index_2 = List_Array_string.IndexOf(input_element);
            string timer_L = TimerStop();
            if (index != -1) Console.WriteLine("Искомый элемент был найден под индексом " + index + " в Array List при помощи IndexOf за " + timer_AL);
            if (index_2 != -1) Console.WriteLine("Искомый элемент был найден под индексом " + index_2 + " в List при помощи IndexOf за " + timer_L);
            if (index == -1 && index_2 == -1) Console.WriteLine("Элемент не найден");
        }

        private void Clear()
        {
            AL_i.Clear();
            AL_s.Clear();
            List_Array_int.Clear();
            List_Array_string.Clear();
        }

        private void Find_in_AL(int index)
        {
            for (int i = 0; i <= 10000000; i++)
            {
                AL_i.Add(i);
            }
            TimerStart();
            int element = AL_i.IndexOf(index);
            Console.WriteLine("Array List бинарный поиск элемента по индексу: " + element + " выполнен за " + TimerStop());
        }

        private void Find_in_List(int index)
        {
            for (int i = 0; i <= 10000000; i++)
            {
                List_Array_int.Add(i);
            }
            TimerStart();
            int element = List_Array_int.IndexOf(index);
            Console.WriteLine("List<> бинарный поиск элемента по индексу: " + element + " выполнен за " + TimerStop());
        }

        public static void Main()
        {
            while (true)
            {
                var AL = new SampleArrays();
                Console.WriteLine("1 - Сравнение скорости int элементов\n2 - Сравнение скорости string элементов\n3 - Сравнение скорости поиска элемента по индексу\n4 - Проверка элемента\n5 - Выход");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    AL.ArrayList_int();
                    AL.List_int();
                }
                if (input == 2)
                {
                    AL.ArrayList_string();
                    AL.List_string();
                }
                if (input == 3)
                {
                    Console.WriteLine("Введите элемент: ");
                    int index = Convert.ToInt32(Console.ReadLine());
                    AL.Find_in_AL(index);
                    AL.Find_in_List(index);
                }
                if (input == 5)
                {
                    Console.WriteLine("See you, Space Cowboy!");
                    AL.Clear();
                    break;
                }
                if (input == 4)
                {
                    Console.WriteLine("Введите искомый элемент");
                    string input_element = Console.ReadLine();
                    AL.CheckElem<string>(ref input_element);
                }
                if (input > 5 && input < 1)
                {
                    Console.WriteLine("Неверный ввод");
                }
            }
        }

    }

}