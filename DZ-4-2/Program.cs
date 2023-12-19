namespace Dz
{
    class Program : ArrE1
    {
        static void main()
        {
            ArrE1[] arre = new ArrE1[5];
            arre[0].name = "Ефим";
            arre[0].val = 1;
            arre[1].name = "Миша";
            arre[1].val = 2;
            arre[2].name = "Серёжа";
            arre[2].val = 3;
            arre[3].name = "Максим";
            arre[3].val = 4;
            arre[4].name = "Юра";
            arre[4].val = 5;

            Index(arre);
            Indexer();
        }

        void Index(ArrE1[] arre)
        {
            Console.WriteLine("Введите индекс массива: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(arre[i].name + " " + arre[i].val);
        }

        void Indexer()
        {
            Console.WriteLine("Введите имя элемента: ");

        }
    }

    class ArrE1
    {
        public string name { get; set; }
        public int val { get; set; }
    }
}