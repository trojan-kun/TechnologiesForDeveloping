using System.Diagnostics;
using System.Text;

namespace DZ
{
    class Program
    {
        static void StringMethod()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            string s1 = "Hello";
            string s2 = " Wordld";
            string s3 = "!!!";
            string str = string.Concat(s1, s2, s3);

            stopWatch.Stop();
            Console.WriteLine(str);
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine(ts);
        }
        static void StringBuilderMethod()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            StringBuilder sb = new StringBuilder("Hello", 14);
            sb.Append("Wordld");
            sb.Append("!!!");

            stopWatch.Stop();
            Console.WriteLine(sb);
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine(ts);
        }
        static void Main()
        {
            StringMethod();
            Console.WriteLine();
            StringBuilderMethod();
        }
    }
}