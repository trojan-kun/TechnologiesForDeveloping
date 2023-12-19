using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Arrays
{
    int[] numbers1;
    int[] numbers2;
    string[] string1;
    int[] numbers_asc;
    public Arrays(int n)
    {
        numbers1 = new int[n];
        numbers2 = new int[n];
        numbers_asc = new int[n];
        string1 = new string[n];
        var rand = new Random();
        for (int i = 0; i < n; i++)
        {
            numbers1[i] = rand.Next(0, 100);
            numbers2[i] = rand.Next(0, 100);
            numbers_asc[i] = rand.Next(0, 10);
        }
        for (int i = 0; i < (n / 4); i++)
        {
            string1[i] = "aA" + "ot";
        }
        for (int i = (n / 4); i < (n / 2); i++)
        {
            string1[i] = "Bb" + "ot";
        }
        for (int i = n / 2; i < n; i++)
        {
            string1[i] = "Cc" + "ot";
        }
    }
    public void show_arrays(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(numbers1[i]);
        }
        Console.WriteLine("\nnext array\n");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(numbers2[i]);
        }
    }

    public void Compare_arrays(int n)
    {
        for (int i = 0; i < n; i++)
        {
            if (numbers1[i] % 5 == 0 && numbers2[i] % 5 == 0)
            {
                Console.WriteLine("Пара чисел кратных 5: " + numbers1[i] + " " + numbers2[i]);
            }
        }
    }

    public void Alphabet_sort(int n)
    {
        string[] string2;
        string2 = new string[n];
        for (int i = 0; i < n; i++)
        {
            string2[i] = string1[i];
        }
        Array.Sort(string2, (a, b) => a.CompareTo(b));
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(string2[i]);
        }
    }

    public void ALpahbet_sort_linq()
    {
        var selected_strings = string1.OrderBy((s) => s);
        foreach (string s in selected_strings)
        {
            Console.WriteLine(s);
        }
    }

    public void Compare_linq_arrays()
    {
        var selected_numbers_1 = from num in numbers1
                                 from num2 in numbers2
                                 where num % 5 == 0 && num2 % 5 == 0
                                 where num != 0
                                 select num;
        var selected_numbers_2 = from num in numbers1
                                 from num2 in numbers2
                                 where num % 5 == 0 && num2 % 5 == 0
                                 where num2 != 0
                                 select num2;

        Console.WriteLine("Числа кратные 5 в первом массиве:");
        foreach (int num in selected_numbers_1)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("Числа кратные 5 во втором массиве:");
        foreach (int num in selected_numbers_2)
        {
            Console.WriteLine(num);
        }

    }

    public void asc(int n)
    {
        int[] arr_no_linq;
        arr_no_linq = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr_no_linq[i] = numbers_asc[i];
        }
        var res1 = numbers_asc.OrderBy(r => r).GroupBy(r => r % 2 == 0);
        Console.WriteLine();
        foreach (var group in res1)
        {
            Console.WriteLine(group.Key == true ? "Чётные числа" : "Нечётные числа");
            foreach (var num in group)
                Console.WriteLine(num);
        }

        int odd_sum_no_linq = 0, even_sum_no_linq = 0;
        Console.WriteLine("Отсоритрованный массив четных без LinQ");
        Array.Sort(arr_no_linq);

        IEnumerable<int> groupped_no_linq_even = from elem in arr_no_linq
                                                 where elem % 2 == 0
                                                 select elem;
        foreach (int elem in groupped_no_linq_even)
        {
            even_sum_no_linq += elem;
            Console.Write(elem + " | ");
        }
        Console.WriteLine();

        Console.WriteLine("Отсоритрованный массив нечетных без LinQ");

        IEnumerable<int> groupped_no_linq_odd = from elem in arr_no_linq
                                                where elem % 2 == 1
                                                select elem;

        foreach (int elem in groupped_no_linq_odd)
        {
            odd_sum_no_linq += elem;
            Console.Write(elem + " | ");
        }
        Console.WriteLine();

        //2) Дан массив целых чисел. Сгруппировать их по четности. Для каждой группы посчитать сумму входящих в нее элементов.Итоговая коллекция должна содержать для каждой группы поле, с суммой группы.
        Console.WriteLine("Итоговая коллекция");
        var res2 = numbers_asc.OrderBy(r => r).GroupBy(r => r % 2 == 0).Select(r => new { Key = r.Key == true ? "Чётные числа" : "Нечётные числа", Summary = r.Sum() });
        foreach (var an in res2)
            Console.WriteLine(an);
        Console.WriteLine("Итоговая коллекция без linq");
        Console.WriteLine(new { Key = "Чётные числа", Summary = even_sum_no_linq });
        Console.WriteLine(new { Key = "Нечётные числа", Summary = odd_sum_no_linq });
    }
}

class programm
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Arrays arrays = new Arrays(n);
        arrays.Compare_arrays(n);
        arrays.Compare_linq_arrays();
        arrays.ALpahbet_sort_linq();
        Console.WriteLine();
        arrays.Alphabet_sort(n);
        arrays.asc(n);
    }
}
