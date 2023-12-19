namespace DZ
{
    class program
    {
        static void Main()
        {
            int n, m;
            Console.Write("Введите m: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int[,] matrix = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rnd.Next(-3, 5);
                    Console.Write(matrix[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            if (m == n)
            {
                int I = n, sum_diagonal = 0;
                for (int i = 0; i < n; i++)
                {
                    sum_diagonal += matrix[I, i];
                    I--;
                }
                Console.WriteLine("Сумма элементов главной диагонали: "+ sum_diagonal);
            }
            else
            {
                Console.WriteLine("Нет главной диагонали");
            }
            int average_matrix = 0;
            int max = matrix[0, 0], min = matrix[0, 0], min_line = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    average_matrix += matrix[i, j];
                    if (max < matrix[i, j])
                    {
                        max = matrix[i, j];
                    }
                    if (min > matrix[i, j])
                    {
                        min = matrix[i, j];
                        min_line = i;
                    }
                }
            }
            average_matrix /= m * n;
            Console.WriteLine("Среднее арифметическое элементов матрицы: "+ average_matrix);
            Console.WriteLine("Максимальный элемент: "+ max);
            Console.WriteLine("Минимальный элемент: "+ min);
            int average_column = 0;
            Console.WriteLine("Среднее арифметическое каждого из столбцов: ");
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < m; i++)
                {
                    average_column += matrix[i, j];
                }
                average_column /= n;
                Console.WriteLine("\tСтолбец "+ (j+1) + ": "+ average_column);
                average_column = 0;
            }
            Console.WriteLine("Среднее арифметическое каждого из столбцов, имеющих четные номера: ");
            int I_column = 0;
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < m; i++)
                {
                    if (0 == i % 2)
                    {
                        average_column += matrix[i, j];
                        I_column++;
                    }
                }
                average_matrix /= I_column;
                Console.WriteLine("\tСтолбец "+ (j + 1) + ": "+ average_column);
                average_column = 0;
            }
            int sum_column = 0;
            for (int i = 0; i < n; i++)
            {
                sum_column += matrix[0, i];
            }
            Console.WriteLine("Сумму элементов 1-го столбца матрицы: "+ sum_column);
            int sum_line = 0;
            for (int i = 0; i < m; i++)
            {
                sum_line += matrix[min_line, i];
            }
            Console.WriteLine("Сумму элементов строки, в которой расположен наименьший элемент: "+ sum_line);
            int module = matrix[0, 0];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (Math.Abs(matrix[i, j]) > module)
                    {
                        module = matrix[i, j];
                    }
                }
            }
            Console.WriteLine("Значение наибольшего по модулю элемента матрицы: "+ module);
            int max_lin = 0, sum_max_line=0;
            for (int i = 0; i < m; i++)
            {
                max_lin = matrix[i, 0];
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j]> max_lin)
                    {
                        max_lin=matrix[i, j];
                    }
                }
                sum_max_line += max_lin;
            }
            Console.WriteLine("Сумму наибольших значений элементов ее строк: "+ sum_max_line);
            int k, minus= 0, multiplication_three = 1, multiplication_module=1;
            Console.WriteLine("Ввведите k-ую строку: ");

            k = Convert.ToInt32(Console.ReadLine());
            k--;
            max_lin = matrix[k, 0];
            for (int j = 0; j < n; j++)
            {
                if (matrix[k, j] > max_lin)
                {
                    max_lin = matrix[k, j];
                }
                if(matrix[k, j] < 0)
                {
                    minus++;
                }
                if (matrix[k, j] > 1 & matrix[k, j] < 3)
                {
                    multiplication_three*= matrix[k, j];
                }
                multiplication_module *= Math.Abs(matrix[k, j]);
            }
            Console.WriteLine("Наибольшее из значений элементов k-ой строки: "+ max_lin);
            Console.WriteLine("Число отрицательных элементов в k-ой строке: "+ minus);
            int multiplication = 1;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    multiplication*=matrix[i, j];
                }
            }
            Console.WriteLine("Произведение всех элементов матрицы: "+ multiplication);
            Console.WriteLine("Произведение квадратов тех элементов k-ой строки, которые больше 1, но меньше 3: "+ multiplication_three);
            Console.WriteLine("Произведение модулей элементов k-ой строки: "+ multiplication_module);
        }
    }
}