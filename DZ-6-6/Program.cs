namespace DZ
{
    class Program
    {
        static void Main()
        {
            string a = "a";
            string a_b = a + "b";
            string ab = "ab";
            Console.WriteLine("{0}, {1}", ab == a_b, object.ReferenceEquals(ab, a_b));
            //True, False
            ab = String.Intern(ab);
            Console.WriteLine("{0}, {1}", ab == a_b, object.ReferenceEquals(ab, a_b));
            //True, False
            Console.WriteLine("{0}, {1}", ab == a_b,object.ReferenceEquals(ab, String.Intern(a_b)));
            //True, True

            string s = new string(new char[] { 'x', 'y', 'z' });
            Console.WriteLine(String.IsInterned(s) ?? "Не интернированная строка");
            //Не интернированная строка
            String.Intern(s);
            Console.WriteLine(String.IsInterned(s) ?? "Не интернированная строка");
            //xyz
            string S = new string(new char[] { 'x', 'y', 'z' });
            Console.WriteLine(object.ReferenceEquals(S, s));
            //False
            Console.WriteLine(object.ReferenceEquals(String.IsInterned(S), s));
            //True
        }
    }
}