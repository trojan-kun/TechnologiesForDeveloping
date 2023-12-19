using System.IO;
using System.Runtime.CompilerServices;

namespace DZ
{
    class dz
    {
        async void Reader()
        {
            string path = "Test.txt";

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = await sr.ReadLineAsync()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

        async void Writer()
        {
            string path = "Test_Writer.txt";
            string text = "It is awfully hard work doing nothing.";

            using (StreamWriter sw = new StreamWriter(path, false))
            {
                await sw.WriteLineAsync(text);
            }

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                text = "Watermelon – it’s a good fruit. You eat, you drink, you wash your face.";
                await sw.WriteLineAsync(text);
                await sw.WriteAsync("123");
            }
        }

        static void Main()
        {
            dz DZ = new dz();
            DZ.Reader();
            DZ.Writer();
        }
    }
}
