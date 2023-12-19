namespace DZ
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Введите символ: ");
            var Symbol= Console.Read();
            Console.WriteLine("Вы ввлели: ", Symbol);

            Console.WriteLine(Char.GetUnicodeCategory((char)Symbol));
        }
    }
}