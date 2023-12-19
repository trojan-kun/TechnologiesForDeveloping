namespace DZ
{
	enum ClothingSize
	{
		XXS = 32,
		XS = 34,
		S = 36,
		M = 38,
		L = 40
	}
	static class Expander
	{
		public static string DetermineTheAgeOfTheWearer(this string Size)
		{
			if (Size == Convert.ToString(ClothingSize.XXS))
				return "Детский размер";
			else return "Взрослый размер";
		}
	}
	public interface IManClothing
	{
		string GetDressMan();
	}
	public interface IWomanClothing
	{
		string GetDressWoman();
	}
	public abstract class Clothes
	{
		public string Size;
		public int Price;
		public string Color;

		public Clothes(string Size, int Price, string Color)
		{
			this.Size = Size;
			this.Price = Price;
			this.Color = Color;
		}
	}
	public class Tshirt : Clothes, IWomanClothing, IManClothing
	{
		public Tshirt(string Size, int Price, string Color) : base(Size, Price, Color) { }
		public string GetDressMan()
		{
			return ("Мужская Футболка");
		}
		public string GetDressWoman()
		{
			return ("Женская Футболка");
		}
	}
	public class Trousers : Clothes, IWomanClothing, IManClothing
	{
		public Trousers(string Size, int Price, string Color) : base(Size, Price, Color) { }
		public string GetDressMan()
		{
			return ("Мужские Штаны");
		}
		public string GetDressWoman()
		{
			return ("Женские Штаны");
		}
	}
	public class Skirt : Clothes, IWomanClothing
	{
		public Skirt(string Size, int Price, string Color) : base(Size, Price, Color) { }
		public string GetDressWoman()
		{
			return ("Юбка");
		}
	}
	public class Tie : Clothes, IManClothing
	{
		public Tie(string Size, int Price, string Color) : base(Size, Price, Color) { }
		public string GetDressMan()
		{
			return ("Галстук");
		}
	}
	public class Atelier
	{
		public void CatalogDisplay(Clothes[] Cloth)
		{
			foreach (Clothes item in Cloth)
			{
				if (item is IManClothing)
					Console.WriteLine(((IManClothing)item).GetDressMan());
				else
					Console.WriteLine(((IWomanClothing)item).GetDressWoman());

				Console.WriteLine($"Размер: {Convert.ToString(item.Size)} ({item.Size.DetermineTheAgeOfTheWearer()})");
				Console.WriteLine($"Цена: {item.Price} золотых");
				Console.WriteLine("Цвет: " + item.Color);
				Console.WriteLine("-----");
			}
		}
	}
	public class Programm
	{
		static void Main()
		{
			Atelier Atelier = new Atelier();

			Clothes[] Cloth = {
				new Tshirt("XS", 150,"темно-серый"),
				new Tshirt("M", 250,"черный"),
				new Tshirt("L", 300,"белый"),
				new Trousers("M", 250,"голубой"),
				new Trousers("XXS", 100,"синий"),
				new Trousers("S", 200,"синий"),
				new Skirt("S", 175,"розовый"),
				new Skirt("XXS", 75,"красный"),
				new Tie("L", 120,"синий"),
				new Tie("M", 110,"красный")
			};

			Atelier.CatalogDisplay(Cloth);
		}
	}
}

//  3) Одежда:
//  а) Создать перечисление, содержащее размеры одежды (XXS, XS, S, M, L) с
//      соответствующими значениями (32, 34, 36, 38, 40).
//  б) Определить метод расширитель для перечисления размеров одежды, который 
//      возвращает строку "Взрослый размер"
//      для констант XS, S, M, L и "Детский размер" для константы XS.
//  в) Создать интерфейсы "Мужская Одежда" с методом "одетьМужчину" и "Женская 
//      Одежда" с методом "одетьЖенщину". 
//  г) Создать абстрактный класс Одежда, содержащий переменные - размер одежды, стоимость, цвет.
//  д) Создать классы наследники Одежды - Футболка (реализует интерфейсы "Мужская Одежда" и "Женская Одежда"),
//      Штаны (реализует интерфейсы "Мужская Одежда" и "Женская Одежда"), Юбка
//      (реализует интерфейсы "Женская Одежда"), Галстук(реализует интерфейсы "Мужская Одежда").
//  е) Создать массив, содержащий все типы одежды. Создать класс Ателье, содержащий
//      методы одетьЖенщину, одетьМужчину, на вход которых будет поступать массив, содержащий все типы одежды.
//      Метод одетьЖенщину выводит на консоль всю информацию о женской одежде. То же самое для метода одетьМужчину