using System.Data;
using System.Reflection.Metadata;

namespace DZ
{
    class Exercisex
    {
        public const int constant = 1;

        public int field;

        public readonly int RO_field1 = 3;

        public readonly int RO_field2;

        public static readonly int RO_st_field;

        public Exercisex()
        {
            //constant = 0;

            field = 2;
            RO_field2 = 4;

            //RO_st_field = 5;
        }

        static Exercisex()
        {
            RO_st_field = 5;
        }

        public void Print()
        {
            Console.WriteLine(constant);
            Console.WriteLine(field);
            Console.WriteLine(RO_field1);
            Console.WriteLine(RO_field2);
            Console.WriteLine(RO_st_field);
            Console.WriteLine("----");
        }

        static void Main()
        {
            Exercisex exercisex = new Exercisex();
            exercisex.Print();

            exercisex.field = exercisex.field * 3;

            //exercisex.RO_field1 = exercisex.RO_field1 * 2;

            exercisex.Print();

            exercisex.field = constant;
            exercisex.field = exercisex.RO_field2;

            exercisex.Print();
        }

    }
}