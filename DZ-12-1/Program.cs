using System.Collections.Generic;
using System.Linq;

class Programm
{
	public void AB(int n, Random random)
	{
		int[] array = new int[n];
		Console.WriteLine("Обычный массив:");
		for(int i = 0; i < array.Length; i++)
		{
			array[i] = random.Next(0,n*n);
			Console.Write($"{array[i]}; ");
		}
		Console.WriteLine();
        int max = 0, maxi = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxi = i;
            }
        }

        Console.WriteLine("LINQ:");
		List<int> list = array.ToList();
		foreach(int i in list)
		{
			Console.Write($"{i}; ");
		}
		Console.WriteLine();
		var selectedmax = list.Max();
		var index = list.LastIndexOf(list.Max());

		Console.WriteLine($"Максимальное число: LINQ: {selectedmax}, обычный: {max}");
		Console.WriteLine($"Элемент максимального числа: LINQ: {index+1} , обычный: {maxi + 1}");
	}

	struct StructOne
	{
		public int x, y;
	}
	public void V(int n, Random random)
	{
		int max = 0, maxi=0;
		StructOne[] structs = new StructOne[n];
		Console.WriteLine("Обычный массив:");
		for (int i = 0; i < structs.Length; i++)
		{
			structs[i].x = random.Next(0, n*n);
			structs[i].y = random.Next(0, n*n);
			Console.WriteLine($"x: {structs[i].x} - y: {structs[i].y}");
		}
        for (int i = 0; i < structs.Length; i++)
        {
            if (structs[i].y > max)
            {
                max = structs[i].y;
                maxi = i;
            }
        }

        Console.WriteLine("LINQ:");
		StructOne[] strlinq = structs.ToArray();
		for (int i = 0; i < structs.Length; i++)
		{		
			Console.WriteLine($"x: {strlinq[i].x} - y: {strlinq[i].y}");
		}
		var maxy = strlinq.Max(m => m.y);

        Console.WriteLine($"Максимальная структура обчным способом: {structs[maxi].x}, {structs[maxi].y}");
        Console.WriteLine($"Максимальная структура LINQ: {maxy}");
    }

	struct StructIntDouble
	{
		public int x;
		public double y;
	}
	struct StructDoubleInt
	{
		public double x;
		public  int y;
	}
	public void G(int n, Random random)
	{
		StructIntDouble[] structs = new StructIntDouble[n];
		StructDoubleInt[] stcurtsdi = new StructDoubleInt[n];
		Console.WriteLine("Обычный массив:");
		for (int i = 0; i < structs.Length; i++)
		{
			structs[i].x = random.Next(0, n * n);
			structs[i].y = random.NextDouble()*100;
			Console.WriteLine($"x: {structs[i].x} - y: {structs[i].y}; ");
		}

		Console.WriteLine("LINQ:");
        StructIntDouble[] strlinq = structs.ToArray();
        for (int i = 0; i < structs.Length; i++)
        {
            Console.WriteLine($"x: {structs[i].x} - y: {structs[i].y}");
        }

        Console.WriteLine("Обычный отсортированный:");
		Array.Sort<StructIntDouble>(structs, (one, two)=> one.y.CompareTo(two.y));
		for (int i = 0; i < structs.Length; i++)
		{
			stcurtsdi[i].x = Convert.ToDouble(structs[i].x) + 0.001;
			stcurtsdi[i].y = Convert.ToInt32(structs[i].y);
			Console.WriteLine($"x: {stcurtsdi[i].x} - y: {stcurtsdi[i].y}");
		}

		Console.WriteLine("LINQ отсортированный:");
        IEnumerable<StructIntDouble> strsort = structs.OrderBy(s => s.y);
		StructDoubleInt[] strsortdoubleint = new StructDoubleInt[n];
		int ind = 0;
        foreach(StructIntDouble s in strsort)
		{
            strsortdoubleint[ind].x = Convert.ToDouble(s.x) + 0.002;
            strsortdoubleint[ind].y = Convert.ToInt32(s.y);
            Console.WriteLine($"x: {strsortdoubleint[ind].x} - y: {strsortdoubleint[ind].y}");
			ind++;
        }
    }

	public static void Main()
	{
		Random random = new Random();
		const int n = 6;

		Programm programm = new();
		programm.AB(n, random);
		Console.WriteLine("---------");
		programm.V(n, random);
		Console.WriteLine("---------");
		programm.G(n, random);
	}
}