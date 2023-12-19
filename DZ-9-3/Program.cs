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
        public static string AgeSize(this string size)
        {
            string adult = "Взрослый размер", child = "Детский размер";
            if (size == Convert.ToString(ClothingSize.XXS))
                return child;
            else return adult;
        }
    }
    public interface IManClothing
    {
        string DressMan();
    }
    public interface IWomanClothing
    {
        string DressWoman();
    }
    public abstract class Clothes
    {
        public string size;
        public int price;
        public string color;
    }
    public class Tshirt : Clothes, IWomanClothing , IManClothing
    {
        public Tshirt(string size, int price, string color)
        {
            this.size = size;
            this.price = price;
            this.color = color;
        }
        public string DressMan()
        {
            return ("Мужская Футболка");
        }
        public string DressWoman()
        {
            return ("Женская Футболка");
        }
    }
    public class Trousers : Clothes, IWomanClothing, IManClothing
    {
        public Trousers(string size, int price, string color)
        {
            this.size = size;
            this.price = price;
            this.color = color;
        }
        public string DressMan()
        {
            return ("Мужские Штаны");
        }
        public string DressWoman()
        {
            return ("Женские Штаны");
        }
    }
    public class Skirt : Clothes, IWomanClothing
    {
        public Skirt(string size, int price, string color)
        {
            this.size = size;
            this.price = price;
            this.color = color;
        }
        public string DressWoman()
        {
            return ("Юбка");
        }
    }
    public class Tie : Clothes, IManClothing
    {
        public Tie(string size, int price, string color)
        {
            this.size = size;
            this.price = price;
            this.color = color;
        }
        public string DressMan()
        {
            return("Галстук");
        }
    }
    public class Atelier
    {
        public void DressMan(Clothes[] clothes)
        {
            foreach (Clothes item in clothes) 
            {
                if (item is IManClothing)
                {
                    Console.WriteLine(((IManClothing)item).DressMan());
                    string agesize = item.size.AgeSize();
                    Console.WriteLine("Размер: " + Convert.ToString(item.size) + " (" + agesize + ")");
                    Console.WriteLine("Цена: " + item.price + " золотых");
                    Console.WriteLine("Цвет: " + item.color);
                    Console.WriteLine("-----");
                }
            }
        }
        public void DressWoman(Clothes[] clothes)
        {
            foreach (Clothes item in clothes)
            {
                if (item is IWomanClothing)
                {
                    Console.WriteLine(((IWomanClothing)item).DressWoman());
                    string agesize = item.size.AgeSize();
                    Console.WriteLine("Размер: " + Convert.ToString(item.size) + " (" + agesize + ")");
                    Console.WriteLine("Цена: " + item.price + " золотых");
                    Console.WriteLine("Цвет: " + item.color);
                    Console.WriteLine("-----");
                }
            }
        }
    }
    public class Programm: Atelier
    {
        static void Main()
        {
            Atelier atelier = new Atelier();

            Clothes[] clothes = {
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

            atelier.DressMan(clothes);
            atelier.DressWoman(clothes);
        }
    }
}

// 3) Одежда:
// а) Создать перечисление, содержащее размеры одежды (XXS, XS, S, M, L) с
//      соответствующими значениями (32, 34, 36, 38, 40).
// б) Определить метод расширитель для перечисления размеров одежды, который 
//      возвращает строку "Взрослый размер"
//      для констант XS, S, M, L и "Детский размер" для константы XS.
// в) Создать интерфейсы "Мужская Одежда" с методом "одетьМужчину" и "Женская 
//      Одежда" с методом "одетьЖенщину". 
// г) Создать абстрактный класс Одежда, содержащий переменные - размер одежды, стоимость, цвет.
// д) Создать классы наследники Одежды - Футболка (реализует интерфейсы "Мужская Одежда" и "Женская Одежда"),
//      Штаны (реализует интерфейсы "Мужская Одежда" и "Женская Одежда"), Юбка
//      (реализует интерфейсы "Женская Одежда"), Галстук(реализует интерфейсы "Мужская Одежда").
// е) Создать массив, содержащий все типы одежды. Создать класс Ателье, содержащий
//      методы одетьЖенщину, одетьМужчину, на вход которых будет поступать массив, содержащий все типы одежды.
//      Метод одетьЖенщину выводит на консоль всю информацию о женской одежде. То же самое для метода одетьМужчину