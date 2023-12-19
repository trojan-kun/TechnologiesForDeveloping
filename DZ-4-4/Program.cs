namespace DZ
{
    class dz
    {
        static void Ref(ref int One, ref int Two)
        {
            int n=One;
            One=Two;
            Two=n;
        }

        static void Main()
        {
            int One =1;
            int Two =2;

            Console.WriteLine(One + ", " + Two) ;
            Ref(ref One, ref Two);
            Console.WriteLine(One + ", " + Two);
        }
    }
}